using TechTalk.SpecFlow;

namespace BGLGroup.Automation.Tests.Steps
{
    public class NavigationHelper
    {
        public static void GetPageModelByPageName(string pageName)
        {
            var pageModel = Hooks.Feature.Journey.NavigateTo(pageName);
            if (FeatureContext.Current.ContainsKey("CurrentPage"))
                FeatureContext.Current.Remove("CurrentPage");
            FeatureContext.Current.Add("CurrentPage", pageModel);
        }
    }
}