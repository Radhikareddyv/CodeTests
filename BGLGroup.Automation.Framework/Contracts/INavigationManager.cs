using BGLGroup.Automation.Framework.Models;
using BGLGroup.Automation.Framework.Models.AboutYou;
using BGLGroup.Automation.Framework.Models.Welcome;

namespace BGLGroup.Automation.Framework.Contracts
{
    public interface INavigationManager
    {
        WelcomeModel GoToWelcomePage();

        void Quit();

        AboutYouModel GoToAboutYouPage();
    }
}