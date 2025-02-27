using SwagLabProject.Selenium.Actions;
using SwagLabProject.Selenium.Drivers;
using Xunit;

namespace SwagLabProject.Selenium.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Fact]
        public void Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(driver);
            loginActions.Login("standard_user", "secret_sauce");

            var loginPage = new SwagLabProject.Selenium.Pages.LoginPage(driver);
            Assert.True(driver.Url.Contains("inventory"), "Login failed!");
        }
    }
}