using BGLGroup.Automation.Framework.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace BGLGroup.Automation.Framework.Common
{
    public class FirefoxBrowser : IBrowser
    {
        public IWebDriver Initialize()
        {
            var firefoxDriver = new FirefoxDriver();
            firefoxDriver.Manage().Window.Maximize();
            return firefoxDriver;
        }
    }
}