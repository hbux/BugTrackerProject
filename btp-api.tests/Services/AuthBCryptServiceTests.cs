using btp_api.Services.Implementations;
using btp_api.Services;
using Xunit;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using btp_api.Models;

namespace btp_api.tests.Services
{
    public class AuthBCryptServiceTests
    {
        private IAuthService _authService;
        private IConfiguration _configuration;

        public AuthBCryptServiceTests()
        {

        }

        [Theory]
        [InlineData("P4SSw0rd")]
        [InlineData("Example-Password 1")]
        public void ComparePassword_WhenValid_ShouldBeEqual(string passwordToHash)
        {
            // Arrange
            _configuration = ConfigurationBuilder();
            _authService = new AuthBCryptService(_configuration);

            // Act
            var hashedPassword = _authService.HashPassword(passwordToHash);
            var areHashedPasswordsEqual = _authService.ComparePassword(hashedPassword, passwordToHash);

            // Assert
            Assert.True(areHashedPasswordsEqual);
        }

        [Theory]
        [InlineData("P4SSw0rd")]
        [InlineData("Example-Password 1")]
        public void HashPassword_WhenValid_ShouldHashPassword(string passwordToHash)
        {
            // Arrange
            _configuration = ConfigurationBuilder();
            _authService = new AuthBCryptService(_configuration);

            // Act
            var hashedPassword = _authService.HashPassword(passwordToHash);
            var areHashedPasswordsEqual = _authService.ComparePassword(hashedPassword, passwordToHash);

            // Assert
            Assert.True(areHashedPasswordsEqual);
        }

        [Fact]
        public void HashPassword_WhenEmpty_ShouldThrowException()
        {
            // Arrange
            _configuration = ConfigurationBuilder();
            _authService = new AuthBCryptService(_configuration);

            // Assert
            Assert.Throws<ArgumentNullException>(() => _authService.HashPassword(null));
        }

        [Fact]
        public void GenerateToken_WithValidParameters_ShouldCreateToken()
        {
            // Arrange
            _configuration = ConfigurationBuilder(false);
            _authService = new AuthBCryptService(_configuration);

            var user = CreateSampleUser();

            // Act
            var token = _authService.GenerateToken(user);
            var claimsPrincipal = ValidateToken(token);

            // Assert
            Assert.NotNull(token);
            Assert.NotNull(claimsPrincipal);
            Assert.True(claimsPrincipal.Identity.IsAuthenticated);
            Assert.Equal(user.Id, claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier).Value);
            Assert.Equal(user.UserName, claimsPrincipal.FindFirst(ClaimTypes.Name).Value);
            Assert.Equal(user.Email, claimsPrincipal.FindFirst(ClaimTypes.Email).Value);
        }

        [Fact]
        public void GenerateToken_WithNoSecrets_ShouldThrowException()
        {
            // Arrange
            _configuration = ConfigurationBuilder();
            _authService = new AuthBCryptService(_configuration);

            var user = CreateSampleUser();

            // Assert
            Assert.Throws<ArgumentNullException>(() => _authService.GenerateToken(user));
        }

        /// <summary>
        /// Validates the token and retrieves the claims of the token.
        /// </summary>
        /// <param name="token">The token to validate</param>
        /// <returns>A principal with claims</returns>
        private ClaimsPrincipal ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Secrets:SecurityKey"])),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            var claimsPrincipal = tokenHandler.ValidateToken(token, validationParameters, out var validatedToken);

            return claimsPrincipal;
        }

        /// <summary>
        /// Builds a configuration file.
        /// </summary>
        /// <param name="useEmptyConfigFile">Determines configuration file can be empty</param>
        /// <returns>A configuration interface</returns>
        private IConfiguration ConfigurationBuilder(bool useEmptyConfigFile = true)
        {
            var configurationBuilder = new ConfigurationBuilder();
            var configurationSettings = new Dictionary<string, string>();

            if (useEmptyConfigFile == false)
            {
                configurationSettings.Add("Secrets:SecurityKey", "UseAzureKeyVault");
            }

            configurationBuilder.AddInMemoryCollection(configurationSettings);

            return configurationBuilder.Build();
        }

        /// <summary>
        /// Creates a pre-defined user class used.
        /// </summary>
        /// <returns>A sample user</returns>
        private User CreateSampleUser()
        {
            return new User()
            {
                Id = "100",
                UserName = "Test",
                Email = "Test@test.com",
                HashedPassword = null
            };
        }
    }
}
