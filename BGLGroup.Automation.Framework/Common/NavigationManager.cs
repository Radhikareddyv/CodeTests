using System.Configuration;
using BGLGroup.Automation.Framework.Contracts;
using BGLGroup.Automation.Framework.Models.AboutYou;
using BGLGroup.Automation.Framework.Models.Welcome;

namespace BGLGroup.Automation.Framework.Common
{
    public class NavigationManager : INavigationManager
    {
        public WelcomeModel GoToWelcomePage()
        {
            WebDriver.Driver.SeleniumDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["UrlToTest"]);
            return new WelcomeModel();
        }

        public void Quit()
        {
            WebDriver.Driver.SeleniumDriver.Close();
            WebDriver.Driver.SeleniumDriver.Quit();
        }

        public AboutYouModel GoToAboutYouPage()
        {
            return new AboutYouModel();
        }
    }
}