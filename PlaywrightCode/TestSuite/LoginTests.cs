using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;
using Xunit;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Fact]
        public async Task Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(Page);
            await loginActions.LoginAsync("standard_user", "secret_sauce");

            var loginPage = new SwagLabProject.PlaywrightCode.Pages.LoginPage(Page);
            Assert.True(loginPage.IsOnLoginPage(), "Login failed!");
        }
    }
}
