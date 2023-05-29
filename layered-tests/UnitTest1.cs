using LayeredArchitecture;

namespace YourNamespace.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void AuthenticateUser_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            UserService userService = new UserService();

            // Act
            bool isAuthenticated = userService.AuthenticateUser("admin", "admin123");

            // Assert
            Assert.IsTrue(isAuthenticated);
        }

        [TestMethod]
        public void AuthenticateUser_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            UserService userService = new UserService();

            // Act
            bool isAuthenticated = userService.AuthenticateUser("admin", "wrongpassword");

            // Assert
            Assert.IsFalse(isAuthenticated);
        }

        [TestMethod]
        public void GetUserByUsername_ExistingUser_ReturnsUser()
        {
            // Arrange
            UserRepository userRepository = new UserRepository();

            // Act
            User? user = userRepository.GetUserByUsername("user1");

            // Assert
            Assert.IsNotNull(user);
            Assert.AreEqual("user1", user.Username);
            Assert.AreEqual("password1", user.Password);
        }

        [TestMethod]
        public void GetUserByUsername_NonExistingUser_ReturnsNull()
        {
            // Arrange
            UserRepository userRepository = new UserRepository();

            // Act
            User? user = userRepository.GetUserByUsername("nonexistinguser");

            // Assert
            Assert.IsNull(user);
        }
    }
}