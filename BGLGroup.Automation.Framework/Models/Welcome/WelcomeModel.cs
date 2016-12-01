using BGLGroup.Automation.Framework.Extensions;

namespace BGLGroup.Automation.Framework.Models.Welcome
{
    public class WelcomeModel : WelcomePageObject
    {
        public string HeaderMessage => HeaderMessageElement.Text;

        public string RetreiveQuote => RetreiveQuoteElement.GetAttribute("innerHTML").CleanUpNewLines();

        public string BeforeYouBegin => BeforeYouBeginElement.GetAttribute("innerHTML").CleanUpNewLines();

        public string TabFontSize => TabFontSizeElement.GetAttribute("innerHTML").CleanUpNewLines();

        public string SingleErrorLargeMessage
            => SingleErrorLargeMessageElement.GetAttribute("innerHTML").CleanUpNewLines();

        public string SingleErrorSmallMessage
            => SingleErrorSmallMessageElement.GetAttribute("innerHTML").CleanUpNewLines();

        public string MultipleErrorLargeMessage
            => MultipleErrorLargeMessageElement.Text;

        public string MultipleErrorSmallMessage
            => MultipleErrorSmallMessageElement.Text;

        public string TitleErrorMessage => TitleErrorMessageElement.Text;

        public string FirstnameErrorMessage => FirstNameValidationElement.Text;

        public string SurnameErrorMessage => SurnameValidationElement.Text;

        public string DateOfBirthErrorMessage => DateOfBirthValidationElement.Text;

        public string HouseNameErrorMessage => HouseNameValidationElement.Text;

        public string PostCodeErrorMessage => PostCodeValidationElement.Text;

        public string Title {  set { TitleElement.SendKeys(value); } }

        public string FirstName { set { FirstNameElement.SendKeys(value); } }

        public string SurName {  set { SurnameElement.SendKeys(value); } }

        public string DateOfBirthDay {  set { DateOfBirthDayElement.SendKeys(value); } }

        public string DateOfBirthMonth { set { DateOfBirthMonthElement.SendKeys(value);} }

        public string DateOfBirthYear {  set { DateOfBirthYearElement.SendKeys(value); } }

        public string HouseName { set { HouseNameElement.SendKeys(value); } }

        public string PostCode {  set {  PostCodeElement.SendKeys(value);} }

        public string VehicleRegistration { set { VehicleRegistrationElement.SendKeys(value); } }

        public void ClickFindAddressButton()
        {
            this.FindAddressElement.Click();
        }

        public void ClickContinueButton()
        {
            this.ContinueButtonElement.Click();
        }
    }
}