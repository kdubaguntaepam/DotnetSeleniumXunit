using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Xunit;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup : IAsyncLifetime
    {
        protected IBrowser Browser;
        protected IPage Page;

        public async Task InitializeAsync()
        {
            var playwright = await Playwright.CreateAsync();
            Browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            Page = await Browser.NewPageAsync();
            await Page.GotoAsync("https://www.saucedemo.com/");
        }

        public async Task DisposeAsync()
        {
            await Page.CloseAsync();
            await Browser.CloseAsync();
        }
    }
}