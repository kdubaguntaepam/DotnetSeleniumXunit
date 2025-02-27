using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Xunit;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup : IAsyncLifetime
    {
        protected IPage Page;
        private IPlaywright _playwright;
        private IBrowser _browser;

        public async Task InitializeAsync()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            var context = await _browser.NewContextAsync();
            Page = await context.NewPageAsync();
            await Page.GotoAsync("https://www.saucedemo.com/");
        }

        public async Task DisposeAsync()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }
    }
}
