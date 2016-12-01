using BGLGroup.Automation.Framework.Contracts;
using BGLGroup.Automation.Framework.Models;

namespace BGLGroup.Automation.Framework.Common
{
    public class Journey
    {
        private readonly INavigationManager _navigationManager;

        public Journey() : this(new NavigationManager())
        {
        }

        public Journey(INavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public PageModel NavigateTo(string pageName)
        {
           return Pages.By(pageName).Navigate(_navigationManager);
        }

        public void Quit()
        {
            _navigationManager.Quit();
        }
    }
}
