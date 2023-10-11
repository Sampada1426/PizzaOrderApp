using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ConfirmOrderStepDefinitions
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void Setup()
        {
            // Initialize WebDriver (you may need to configure this based on your environment)
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void Teardown()
        {
            // Close the WebDriver after the scenario is complete
            driver.Quit();
        }

        [Given(@"User is on the checkout page")]
        public void GivenUserIsOnTheCheckoutPage()
        {
            driver.Navigate().GoToUrl("https://localhost:7277/Order/Checkout");
        }

        [When(@"User clicks on confirm order button")]
        public void WhenUserClicksOnConfirmOrderButton()
        {
            IWebElement confirmOrderButton = driver.FindElement(By.Id("confirmOrder"));
            confirmOrderButton.Click();
        }

        [Then(@"User is redirected to confirmation page")]
        public void ThenUserIsRedirectedToConfirmationPage()
        {
            string confirmationPageUrl = driver.Url;
            Assert.IsTrue(confirmationPageUrl.Contains("https://localhost:7277/Order/Confirmation"));
        }
    }
}
