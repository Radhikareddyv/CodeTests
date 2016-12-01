using BGLGroup.Automation.Framework.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BGLGroup.Automation.Framework.Common
{
    public class ChromeBrowser : IBrowser
    {
        public IWebDriver Initialize()
        {
            return new ChromeDriver();
        }
    }
}