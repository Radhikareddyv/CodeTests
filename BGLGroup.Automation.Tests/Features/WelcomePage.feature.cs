﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BGLGroup.Automation.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class WelcomePageFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WelcomePage.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Welcome Page", "As a user \r\nI need to provide my personal details \r\nSo that I can continue to get" +
                    " quotes ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Welcome Page")))
            {
                BGLGroup.Automation.Tests.Features.WelcomePageFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Welcome Page content verification")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Welcome Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("content")]
        public virtual void WelcomePageContentVerification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Welcome Page content verification", new string[] {
                        "content"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I am on the \"Welcome\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "HeaderMessage",
                        "Welcome to your Car Insurance Quote"});
            table1.AddRow(new string[] {
                        "RetreiveQuote",
                        @"<p class=""formRow0""> Please enter your details below for a great quote in minutes </p> <p class=""formRow1"">We'll search over 30 different schemes from leading car insurers to find the best policy for you</p> <div class=""formRow""><strong> Already saved a quote? <a id=""retrieveQuoteRedirectLink"" class=""autoRetrieveQuoteRedirectLink"" href=""../../z001/?subchannel=DIR"">Click here to retrieve a saved quote</a></strong></div>"});
            table1.AddRow(new string[] {
                        "BeforeYouBegin",
                        @"<div class=""asideHeader""><h2>Before you begin</h2></div><div class=""asideBody""><p>It is important that the information you provide throughout the quote and duration of the policy is accurate. Failure to disclose correct and complete information to the best of your knowledge and belief may result in increased premiums, refusal of a claim or not being fully paid, your policy being cancelled or being made null &amp; void and treated as if it never existed.</p></div>"});
            table1.AddRow(new string[] {
                        "TabFontSize",
                        @"<li class=""fontSizeSmall active"">        <a href=""#"" rel=""A"" title=""Regular font"">A</a>    </li>    <li class=""fontSizeMedium"">        <a href=""#"" rel=""B"" title=""Medium font"">A</a>    </li>    <li class=""fontSizeLarge"">        <a href=""#"" rel=""C"" title=""Large font"">A</a>    </li>"});
#line 9
testRunner.Then("the following properties have corresponding text", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Welcome page single error validation tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Welcome Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("validations")]
        public virtual void WelcomePageSingleErrorValidationTests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Welcome page single error validation tests", new string[] {
                        "validations"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
testRunner.Given("I am on the \"Welcome\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "FirstName",
                        "Rob"});
            table2.AddRow(new string[] {
                        "Surname",
                        "Smith"});
            table2.AddRow(new string[] {
                        "DateOfBirthDay",
                        "01"});
            table2.AddRow(new string[] {
                        "DateOfBirthMonth",
                        "Jan"});
            table2.AddRow(new string[] {
                        "DateOfBirthYear",
                        "1980"});
            table2.AddRow(new string[] {
                        "HouseName",
                        "Pegasus House"});
            table2.AddRow(new string[] {
                        "PostCode",
                        "PE2 6YS"});
            table2.AddRow(new string[] {
                        "VehicleRegistration",
                        "GU14 SEO"});
#line 19
testRunner.Then("I enter following values in welcome screen", ((string)(null)), table2, "Then ");
#line 29
testRunner.And("I click on the \"FindAddress\" Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
testRunner.Then("I click continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "SingleErrorLargeMessage",
                        "<strong>1 Question</strong> has not been completed or has been filled incorrectly" +
                            ""});
            table3.AddRow(new string[] {
                        "SingleErrorSmallMessage",
                        "Please correct errors marked with <img alt=\"Error(s)\" src=\"../../Resources/BIS/PC" +
                            "/STD/Images/RD_BIMG_47.gif\"> on page below:"});
            table3.AddRow(new string[] {
                        "TitleErrorMessage",
                        "Please select an option"});
#line 31
testRunner.Then("I should see the following validation message", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Welcome page multiple error validation tests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Welcome Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("validations")]
        public virtual void WelcomePageMultipleErrorValidationTests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Welcome page multiple error validation tests", new string[] {
                        "validations"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
testRunner.Given("I am on the \"Welcome\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.When("I click continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "MultipleErrorLargeMessage",
                        "6 Questions have not been completed or have been filled incorrectly"});
            table4.AddRow(new string[] {
                        "MultipleErrorSmallMessage",
                        "Please correct errors marked with on page below:"});
            table4.AddRow(new string[] {
                        "TitleErrorMessage",
                        "Please select an option"});
            table4.AddRow(new string[] {
                        "FirstNameErrorMessage",
                        "Please enter your first name in letters only between 2 and 15 characters in lengt" +
                            "h"});
            table4.AddRow(new string[] {
                        "SurnameErrorMessage",
                        "Please enter your surname in letters only between 2 and 20 characters in length"});
            table4.AddRow(new string[] {
                        "DateOfBirthErrorMessage",
                        "Please enter a valid date of birth"});
            table4.AddRow(new string[] {
                        "HouseNameErrorMessage",
                        "Please enter your house number or name. House names should be between 2 and 40 ch" +
                            "aracters in length"});
            table4.AddRow(new string[] {
                        "PostCodeErrorMessage",
                        "Postcode is required"});
#line 41
testRunner.Then("I should see the following validation message", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Welcome page input values")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Welcome Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("WelcomeData")]
        public virtual void WelcomePageInputValues()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Welcome page input values", new string[] {
                        "WelcomeData"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line 54
testRunner.Given("I am on the \"Welcome\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Title",
                        "Mr"});
            table5.AddRow(new string[] {
                        "FirstName",
                        "Rob"});
            table5.AddRow(new string[] {
                        "Surname",
                        "Smith"});
            table5.AddRow(new string[] {
                        "DateOfBirthDay",
                        "01"});
            table5.AddRow(new string[] {
                        "DateOfBirthMonth",
                        "Jan"});
            table5.AddRow(new string[] {
                        "DateOfBirthYear",
                        "1980"});
            table5.AddRow(new string[] {
                        "HouseName",
                        "Pegasus House"});
            table5.AddRow(new string[] {
                        "PostCode",
                        "PE2 6YS"});
            table5.AddRow(new string[] {
                        "VehicleRegistration",
                        "GU14 SEO"});
#line 55
testRunner.Then("I enter following values in welcome screen", ((string)(null)), table5, "Then ");
#line 66
testRunner.Then("I click on the \"FindAddress\" Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
testRunner.When("I click continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
testRunner.Then("I Should be navigated to \"AboutYou\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "HeaderText",
                        "About you"});
#line 69
testRunner.Then("I should see the following values", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
