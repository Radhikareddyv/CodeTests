using BGLGroup.Automation.Framework.Models.Welcome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BGLGroup.Automation.Tests.Steps
{
    [Binding]
    public class InputFieldsSteps
    {
        [Then(@"I enter following values in welcome screen")]
        public void ThenIEnterFollowingValuesInWelcomeScreen(Table table)
        {
            table.CreateInstance<WelcomeModel>();
        }

        [Then(@"I click on the ""(.*)"" Button")]
        public void ThenIClickOnTheButton(string p0)
        {
            GetModel().ClickFindAddressButton();
        }

        [Then(@"I click continue button")]
        public void ThenIClickContinueButton()
        {
            GetModel().ClickContinueButton();
        }

        [When(@"I click continue button")]
        public void WhenIClickContinueButton()
        {
            GetModel().ClickContinueButton();
        }

        private static WelcomeModel GetModel()
        {
            WelcomeModel welcomeModel;
            FeatureContext.Current.TryGetValue("CurrentPage", out welcomeModel);
            return welcomeModel;
        }
    }
}