using Applitools.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ApplitoolsDemo.Steps
{
    [Binding]
    public sealed class TransunionHomePageSteps
    {

        IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("WebDriver");
        Eyes eyes = ScenarioContext.Current.Get<Eyes>("Eyes");

        [Given(@"I navigate to the ""(.*)"" Home Page")]
        public void GivenINavigateToTheHomePage(string url)
        {
            driver.Navigate().GoToUrl(url);
            
        }

        [Given(@"the Transunion Home Page is a certain (.*)")]
        public void GivenTheTransunionHomePageIsACertainFull(string browserSize)
        {
            Helpers.GetBrowserSize(browserSize, driver);

        }


        [Then(@"the Home Page Images should match the proper (.*)")]
        public void ThenTheHomePageImagesShouldMatchTheProperFull(string browserSize)
        {
            try
            {
                // Start the test and set the browser's viewport size to 800x600.
                eyes.Open(driver, "Transunion Website", "Transunion Home Page " + browserSize + " " +
                    ConfigurationManager.AppSettings["Browser"].ToString(), Helpers.GetBrowserSize(browserSize, driver));

                // Visual checkpoint #1.
                eyes.CheckWindow("TU Home Page");

                // Click the "My Credit Score & Report" button.
                driver.FindElement(By.XPath("//span[contains(text(),'My Credit Score & Report')]")).Click();

                // Visual checkpoint #2.
                eyes.CheckWindow("My Credit Score & Report");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }


    }
}
