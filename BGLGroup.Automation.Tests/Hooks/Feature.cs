using BGLGroup.Automation.Framework.Common;
using TechTalk.SpecFlow;

namespace BGLGroup.Automation.Tests.Hooks
{
    [Binding]
    public class Feature
    {
        private static Journey _journey;

        [BeforeFeature]
        public static void Initialize()
        {
            _journey = new Journey();
        }

        [AfterFeature]
        public static void CleanUp()
        {
            _journey.Quit();
        }

        public static Journey Journey => _journey;
    }
}