using BGLGroup.Automation.Framework.Models;
using TechTalk.SpecFlow;

namespace BGLGroup.Automation.Tests.Steps
{
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I am on the ""(.*)"" page")]
        public void GivenIAmOnThePage(string pageName)
        {
            NavigationHelper.GetPageModelByPageName(pageName);
        }

        [Then(@"I Should be navigated to ""(.*)"" page")]
        public void ThenIShouldBeNavigatedToPage(string pageName)
        {
            NavigationHelper.GetPageModelByPageName(pageName);
        }
    }
}