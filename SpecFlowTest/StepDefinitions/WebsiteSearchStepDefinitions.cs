using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class WebsiteSearchStepDefinitions
    {
        private IWebDriver driver; 

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://cft-bristol.org/";
        }

        [Then(@"Verify website has successfully launched")]
        public void ThenVerifyWebsiteHasSuccessfullyLaunched()
        {
            string pageTitle = driver.Title;

            Assert.IsNotNull(pageTitle, "Page title is not displayed.");
            driver.Quit();
        }
    }
}