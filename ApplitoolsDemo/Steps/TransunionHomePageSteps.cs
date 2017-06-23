using Applitools.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
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

        [Given(@"the Transunion Home Page is displayed in a certain (.*)")]
        public void GivenTheTransunionHomePageIsDisplayedInACertainFull(string browserSize)
        {
            ScenarioContext.Current.Set<string>(browserSize, "BrowserSize");
            ScenarioContext.Current.Set<Size>(Helpers.GetBrowserSize(browserSize, driver), "Size");
        }

        [When(@"the Base Home Page Image is Compared to the Current Home Page Image")]
        public void WhenTheBaseHomePageImageIsComparedToTheCurrentHomePageImage()
        {
            try
            {
                // Start the test 
                eyes.Open(driver, "Transunion Website", "Transunion Home Page " + 
                    ScenarioContext.Current.Get<string>("BrowserSize") + " " +
                    ConfigurationManager.AppSettings["Browser"].ToString());

                // Visual checkpoint #1.
                eyes.CheckWindow("TU Home Page");            

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        [Then(@"the Home Page images should match correctly")]
        public void ThenTheHomePageImagesShouldMatchCorrectly()
        {
        }

        //// Click the "My Credit Score & Report" button.
        //driver.FindElement(By.XPath("//span[contains(text(),'My Credit Score & Report')]")).Click();

        //// Visual checkpoint #2.
        //eyes.CheckWindow("My Credit Score & Report");

    }
}
