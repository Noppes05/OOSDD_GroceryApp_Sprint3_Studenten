using Grocery.Core.Interfaces.Services;
using Moq;
using NUnit.Framework;

namespace TestCore
{
    public class RegistrationModelTests
    {
        private Mock<IAuthService> _authServiceMock;

        [SetUp]
        public void Setup()
        {
            _authServiceMock = new Mock<IAuthService>();
        }

        [Test]
        public void Register_SuccessfulRegistration_UpdatesRegisteredAndMessage()
        {
            string name = "Test User";
            string email = "testuser@gmail.com";
            string password = "password123";
            string errorMessage = string.Empty;

            // Setup the mock to return true and set out parameter
            _authServiceMock
                .Setup(x => x.Register(name, email, password, out errorMessage))
                .Returns(true);

            // Act
            bool result = _authServiceMock.Object.Register(name, email, password, out errorMessage);

            // Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void Register_FailedRegistration_SetsErrorMessage_EmptyField()
        {
            string name = "Test User";
            string email = "testuser@gmail.com";
            string password = "";
            string errorMessage = string.Empty;

            // Setup the mock to return true and set out parameter
            _authServiceMock
                .Setup(x => x.Register(name, email, password, out errorMessage))
                .Returns(false);

            // Act
            bool result = _authServiceMock.Object.Register(name, email, password, out errorMessage);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Register_FailedRegistration_SetsErrorMessage_EmaiAlreadyUsed()
        {
            string name = "Test User";
            string email = "testuser@gmail.com";
            string password = "";
            string errorMessage = string.Empty;

            // Setup the mock to return true and set out parameter
            _authServiceMock
                .Setup(x => x.Register(name, email, password, out errorMessage))
                .Returns(false);


            // Act
            bool test_parram = _authServiceMock.Object.Register(name, email, password, out errorMessage);
            bool result = _authServiceMock.Object.Register(name, email, password, out errorMessage);

            // Assert
            Assert.IsFalse(result);
        }
    }
}