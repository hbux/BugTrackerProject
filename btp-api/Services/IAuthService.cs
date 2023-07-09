using btp_api.Models;

namespace btp_api.Services
{
    public interface IAuthService
    {
        /// <summary>
        /// Hashes a password.
        /// </summary>
        /// <param name="password">The password to hash</param>
        /// <returns>A hashed password</returns>
        string HashPassword(string password);

        /// <summary>
        /// Compares two passwords to ensure they both are of equal value.
        /// </summary>
        /// <param name="actualPassword">The actual password</param>
        /// <param name="passwordProvided">The password to compare</param>
        /// <returns>True if passwords are equal, false otherwise</returns>
        bool ComparePassword(string actualPassword, string passwordProvided);

        /// <summary>
        /// Generates a JWT.
        /// </summary>
        /// <param name="user">The user to generate the JWT for</param>
        /// <returns>A JWT</returns>
        string GenerateToken(User user);
    }
}
