using System;
using System.Configuration;
using BGLGroup.Automation.Framework.Contracts;
using OpenQA.Selenium;

namespace BGLGroup.Automation.Framework.Common
{
    public sealed class WebDriver
    {
        private static readonly Lazy<WebDriver> _instance = new Lazy<WebDriver>(() => new WebDriver());

        private WebDriver()
        {
            Initialize();
        }

        private void Initialize()
        {
            var appSetting = ConfigurationManager.AppSettings["Browser"];
            var namespaceName = "BGLGroup.Automation.Framework";
            var browserToUse = Activator.CreateInstance(namespaceName, "BGLGroup.Automation.Framework.Common." + appSetting);
            SeleniumDriver = ((IBrowser)browserToUse.Unwrap())?.Initialize();
        }

        public static WebDriver Driver => _instance.Value;

        public IWebDriver SeleniumDriver { get; private set; }
    }
}