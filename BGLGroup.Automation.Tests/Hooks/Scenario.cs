using TechTalk.SpecFlow;

namespace BGLGroup.Automation.Tests.Hooks
{
    public class Scenario
    {
        [BeforeScenario]
        public static void Initialize()
        {
        }

        [AfterScenario]
        public static void CleanUp()
        {
        } 
    }
}