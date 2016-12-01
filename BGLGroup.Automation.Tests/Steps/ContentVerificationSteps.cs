using BGLGroup.Automation.Framework.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BGLGroup.Automation.Tests.Steps
{
    [Binding]
    public class ContentVerificationSteps
    {
        [Then(@"the following properties have corresponding text")]
        public void ThenTheFollowingPropertiesHaveCorrespondingText(Table table)
        {
            CompareTableWithInstance(table);
        }

        [Then(@"I should see the following validation message")]
        public void ThenIShouldSeeTheFollowingValidationMessage(Table table)
        {
            CompareTableWithInstance(table);
        }

        [Then(@"I should see the following values")]
        public void ThenIShouldSeeTheFollowingValues(Table table)
        {
            CompareTableWithInstance(table);
        }


        private static void CompareTableWithInstance(Table table)
        {
            PageModel pageModel;
            FeatureContext.Current.TryGetValue("CurrentPage", out pageModel);
            table.CompareToInstance(pageModel);
        }
    }
}