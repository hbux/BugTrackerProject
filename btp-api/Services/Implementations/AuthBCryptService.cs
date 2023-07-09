using btp_api.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace btp_api.Services.Implementations
{
    /// <summary>
    /// As authentication and security-related features is vital to
    /// be kept secure, BCrypt will be used for validating user identity.
    /// </summary>
    public class AuthBCryptService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthBCryptService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Hashes a password using BCrypt's password hashing service.
        /// </summary>
        /// <param name="password">The password to hash</param>
        /// <returns>A hashed password</returns>
        /// <exception cref="ArgumentNullException">Ensures the password provided is not null</exception>
        public string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                // Password must not be null
                throw new ArgumentNullException("password cannot be null");
            }

            // Hashes the password using BCrypt
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            return hashedPassword;
        }

        /// <summary>
        /// Compares a base64 password with an actual hashed password to ensure they are both of
        /// equal value.
        /// </summary>
        /// <param name="actualPassword">The actual password</param>
        /// <param name="passwordProvided">The password provided</param>
        /// <returns>True if passwords are equal, false otherwise</returns>
        public bool ComparePassword(string actualPassword, string passwordProvided)
        {
            // Verifies that the password provided by the user is equal to the users actual password
            var arePasswordssEqual = BCrypt.Net.BCrypt.Verify(passwordProvided, actualPassword);

            return arePasswordssEqual;
        }

        /// <summary>
        /// Creates a valid JWT using user information.
        /// </summary>
        /// <param name="user">The user to create the token for</param>
        /// <returns>A valid JWT</returns>
        /// <exception cref="ArgumentNullException">Ensures the secret is not null</exception>
        public string GenerateToken(User user)
        {
            // Retrieve the secret from appsettings
            var secret = _configuration["Secrets:SecurityKey"];

            if (string.IsNullOrEmpty(secret))
            {
                // Ensures that the secret cannot be null
                throw new ArgumentNullException("No secret found, please ensure secret has been added into configuration files.");
            }

            // Create claims based on user information
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // Create the token
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(secret, secret, claims, expires: DateTime.Now.AddDays(1), signingCredentials: signingCredentials);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);

            return accessToken;
        }
    }
}
