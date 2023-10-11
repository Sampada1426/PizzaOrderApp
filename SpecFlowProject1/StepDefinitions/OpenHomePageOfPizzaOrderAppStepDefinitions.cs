using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OpenHomePageOfPizzaOrderAppStepDefinitions
    {
        private IWebDriver driver;
        [Given(@"Open Microsoft Edge Browser")]
        public void GivenOpenMicrosoftEdgeBrowser()
        {
            driver = new EdgeDriver();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://localhost:7277/Pizza";
        }

        [Then(@"Homepage is displayed")]
        public void ThenHomepageIsDisplayed()
        {
            Assert.IsTrue(driver.FindElement(By.Id("homepage")).Displayed);
        }

    }
}
