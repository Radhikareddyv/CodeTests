using BGLGroup.Automation.Framework.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BGLGroup.Automation.Framework.Models
{
    public class PageModel
    {
        protected readonly IWebDriver Driver;

        public PageModel() : this (WebDriver.Driver.SeleniumDriver)
        {
        }

        public PageModel(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(this.Driver, this);
        }
    }
}