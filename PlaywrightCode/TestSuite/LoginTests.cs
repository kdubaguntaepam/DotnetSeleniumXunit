using System.Threading.Tasks;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;
using Xunit;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    public class LoginTests : IClassFixture<WebDriverSetup>
    {
        private readonly WebDriverSetup _setup;

        public LoginTests(WebDriverSetup setup) => _setup = setup;

        [Fact]
        public async Task Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(_setup.Page);
            await loginActions.LoginAsync("standard_user", "secret_sauce");

            Assert.True(_setup.Page.Url.Contains("inventory"), "Login failed!");
        }
    }
}