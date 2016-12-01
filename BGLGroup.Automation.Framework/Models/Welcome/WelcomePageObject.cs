using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BGLGroup.Automation.Framework.Models.Welcome
{
    public class WelcomePageObject : PageModel
    {
        [FindsBy(How = How.ClassName, Using = "autoTitle_For_MOTOR__filtered_Answer_list")]
        internal IWebElement TitleElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoFirstNames")]
        internal IWebElement FirstNameElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoSurname")]
        internal IWebElement SurnameElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoDateOfBirth_d")]
        internal IWebElement DateOfBirthDayElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoDateOfBirth_m")]
        internal IWebElement DateOfBirthMonthElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoDateOfBirth_y")]
        internal IWebElement DateOfBirthYearElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoRiskAddress_house")]
        internal IWebElement HouseNameElement { get; set; }

        [FindsBy(How = How.ClassName,Using = "autoRiskAddress_pcode")]
        internal IWebElement PostCodeElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoVehicle_Description_for_Welcome_Screen")]
        internal IWebElement VehicleRegistrationElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoHeaderMessage")]
        internal IWebElement HeaderMessageElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoRetrieveQuote")]
        internal IWebElement RetreiveQuoteElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoBeforeYouBeginSection")]
        internal IWebElement BeforeYouBeginElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoTabFontSize")]
        internal  IWebElement TabFontSizeElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoButtonFindAddressRiskAddress")]
        internal IWebElement FindAddressElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoContinueButton")]
        internal IWebElement ContinueButtonElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoSingleErrorLargeMessage")]
        internal IWebElement SingleErrorLargeMessageElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoSingleErrorSmallMessage")]
        internal IWebElement SingleErrorSmallMessageElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoValidationTitle_For_MOTOR__filtered_Answer_list")]
        internal IWebElement TitleErrorMessageElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoMultipleErrorLargeMessage")]
        internal IWebElement MultipleErrorLargeMessageElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoMultipleErrorSmallMessage")]
        internal IWebElement MultipleErrorSmallMessageElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoValidationFirstNames")]
        internal IWebElement FirstNameValidationElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoValidationSurname")]
        internal IWebElement SurnameValidationElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoValidationDateOfBirth")]
        internal IWebElement DateOfBirthValidationElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoValidationRiskAddress_house")]
        internal IWebElement HouseNameValidationElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "autoValidationRiskAddress_pcode")]
        internal IWebElement PostCodeValidationElement { get; set; }
    }
}