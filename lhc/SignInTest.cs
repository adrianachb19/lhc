using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace lhc
{
    public class Tests
    {
        private RemoteWebDriver driver;

        [SetUp]
        public void TestInitialize(string Browser)
        {
            var remoteWebDriverUrl = "https://lhc-qa-admin.homehero.com/login";

            switch (Browser)

            {
                case "Firefox":
                    var optionsFirefox = new FirefoxOptions();
                    optionsFirefox.AddArguments("--window-size=1400,600");
                    optionsFirefox.AddArguments("--headless");
                    driver = new RemoteWebDriver(new Uri(remoteWebDriverUrl), optionsFirefox);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    break;

                case "Chrome":
                    var optionsChrome = new ChromeOptions();
                    optionsChrome.AddArguments("--window-size=1400,600");
                    optionsChrome.AddArguments("--headless");
                    driver = new RemoteWebDriver(new Uri(remoteWebDriverUrl), optionsChrome);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    break;

            }
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}