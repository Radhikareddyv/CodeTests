Feature: Welcome Page  
As a user 
I need to provide my personal details 
So that I can continue to get quotes 

@content
Scenario: Welcome Page content verification
Given I am on the "Welcome" page 
Then the following properties have corresponding text
| Field          | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| HeaderMessage  | Welcome to your Car Insurance Quote                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| RetreiveQuote  | <p class="formRow0"> Please enter your details below for a great quote in minutes </p> <p class="formRow1">We'll search over 30 different schemes from leading car insurers to find the best policy for you</p> <div class="formRow"><strong> Already saved a quote? <a id="retrieveQuoteRedirectLink" class="autoRetrieveQuoteRedirectLink" href="../../z001/?subchannel=DIR">Click here to retrieve a saved quote</a></strong></div>                                              |
| BeforeYouBegin | <div class="asideHeader"><h2>Before you begin</h2></div><div class="asideBody"><p>It is important that the information you provide throughout the quote and duration of the policy is accurate. Failure to disclose correct and complete information to the best of your knowledge and belief may result in increased premiums, refusal of a claim or not being fully paid, your policy being cancelled or being made null &amp; void and treated as if it never existed.</p></div> |
| TabFontSize    | <li class="fontSizeSmall active">        <a href="#" rel="A" title="Regular font">A</a>    </li>    <li class="fontSizeMedium">        <a href="#" rel="B" title="Medium font">A</a>    </li>    <li class="fontSizeLarge">        <a href="#" rel="C" title="Large font">A</a>    </li>                                                                                                                                                                                            |

@validations
Scenario: Welcome page single error validation tests
Given I am on the "Welcome" page
Then I enter following values in welcome screen 
| Field               | Value         |
| FirstName           | Rob           |
| Surname             | Smith         |
| DateOfBirthDay      | 01            |
| DateOfBirthMonth    | Jan           |
| DateOfBirthYear     | 1980          |
| HouseName           | Pegasus House |
| PostCode            | PE2 6YS       |
| VehicleRegistration | GU14 SEO      |
And I click on the "FindAddress" Button
Then I click continue button
Then I should see the following validation message
| Field                   | Value                                                                                                                        |
| SingleErrorLargeMessage | <strong>1 Question</strong> has not been completed or has been filled incorrectly                                            |
| SingleErrorSmallMessage | Please correct errors marked with <img alt="Error(s)" src="../../Resources/BIS/PC/STD/Images/RD_BIMG_47.gif"> on page below: |
| TitleErrorMessage       | Please select an option                                                                                                      |

@validations
Scenario: Welcome page multiple error validation tests
Given I am on the "Welcome" page
When I click continue button
Then I should see the following validation message
| Field                     | Value                                                                                                                                                |
| MultipleErrorLargeMessage | 6 Questions have not been completed or have been filled incorrectly																				   |
| MultipleErrorSmallMessage | Please correct errors marked with on page below:																			                           |
| TitleErrorMessage         | Please select an option                                                                                                                              |
| FirstNameErrorMessage     | Please enter your first name in letters only between 2 and 15 characters in length                                                                   |
| SurnameErrorMessage       | Please enter your surname in letters only between 2 and 20 characters in length                                                                      |
| DateOfBirthErrorMessage   | Please enter a valid date of birth                                                                                                                   |
| HouseNameErrorMessage     | Please enter your house number or name. House names should be between 2 and 40 characters in length                                                  |
| PostCodeErrorMessage      | Postcode is required                                                                                                                                 |

@WelcomeData
Scenario: Welcome page input values
Given I am on the "Welcome" page
Then I enter following values in welcome screen 
| Field               | Value         |
| Title               | Mr            |
| FirstName           | Rob           |
| Surname             | Smith         |
| DateOfBirthDay      | 01            |
| DateOfBirthMonth    | Jan           |
| DateOfBirthYear     | 1980          |
| HouseName           | Pegasus House |
| PostCode            | PE2 6YS       |
| VehicleRegistration | GU14 SEO      |
Then I click on the "FindAddress" Button
When I click continue button
Then I Should be navigated to "AboutYou" page
Then I should see the following values
| Field | Value     |
| HeaderText | About you |