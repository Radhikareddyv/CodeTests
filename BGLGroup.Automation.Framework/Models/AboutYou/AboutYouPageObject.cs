using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BGLGroup.Automation.Framework.Models.AboutYou
{
    public class AboutYouPageObject : PageModel
    {
        [FindsBy(How = How.ClassName, Using = "autoQuestionSetTopHeaderText_block_1")]
        internal  IWebElement HeaderElement { get; set; }
    }
}