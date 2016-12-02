# BGL Group SDET Test

The solution is developed using following technology stack

  - Visual Studio 2015
  - C# 6.0
  - .Net Framework 4.6
  - Specflow 
  - Selenium WebDriver
  - Microsoft Quality Testing tools (MSTests)
  
Tools that were used while developing and refactoring the code

  - Jetbrains Resharper Ultimate 10.0
  - Specflow Assist

Browsers currently supported using this solution

  - Chrome
  - Firefox
  
To change the browser settings in App.Config in the project BGLGroup.Automation.Tests   

     <!-- <add key="browser" value="FirefoxBrowser" />-->
     <add key="browser" value="ChromeBrowser"/>

Design Principle

  - Page Object Model

## Design Philosophy

The solution contains two projects:

  > BGLGroup.Automation.Framework: The responsibility of this project is to handle all the calls to Selenium WebDriver, Browser to start the tests on. This abstraction is created keeping in mind that a change to underlying framework shouldn't cause any ripple effect on the tests. For ex: Using this approach if we wanted to change the Selenium WebDriver to Watin it is much easier to change. 
  
  > BGLGroup.Automation.Tests : This will contain all the Features that are implemented using Specflow. Most of these features here are currently written by our Business Analysts which we then wire up the code to test a feature or Scenario. If you observe the project in Visual Studio this project doesn't have any knowledge about Selenium WebDriver/Browser. It's responsibility is to only write the feature files, provide step definitions etc.,
  
Specflow Assist: This is being used to compare the table in specflow scenario with the relevant PageModel in this aspect it is WelcomeModel and AboutYou Model. The reason to use this is to avoid the for loops or if conditions that we normally write and is much cleaner to map table to a concrete object. 

More Info: https://github.com/techtalk/SpecFlow/wiki/SpecFlow-Assist-Helpers



  
