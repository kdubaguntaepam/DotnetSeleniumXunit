using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace SwagLabProject.Selenium.Drivers
{
    public class WebDriverSetup : IDisposable
    {
        protected IWebDriver driver;

        public WebDriverSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}