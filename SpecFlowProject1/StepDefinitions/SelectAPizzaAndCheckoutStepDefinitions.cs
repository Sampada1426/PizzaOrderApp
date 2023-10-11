using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class SelectAPizzaAndCheckoutStepDefinitions
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
        [Given(@"User is on the homepage")]
        public void GivenUserIsOnTheHomepage()
        {
            driver.Navigate().GoToUrl("https://localhost:7277/Pizza");
        }

        [When(@"User selects pizza with Id ""([^""]*)"" by clicking radio button")]
        public void WhenUserSelectsPizzaWithIdByClickingRadioButton(string p0)
        {
            IWebElement radioButton = driver.FindElement(By.Id(p0));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", radioButton);
        }


        [Then(@"User clicks on checkout button")]
        public void ThenUserClicksOnCheckoutButton()
        {
            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();
        }
    }
}
