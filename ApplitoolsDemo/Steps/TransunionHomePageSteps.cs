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

        [When(@"the Base Home Page Image is Compared to the Current Home Page Image")]
        public void WhenTheBaseHomePageImageIsComparedToTheCurrentHomePageImage(string browserSize)
        {
            

            try
            {
                // Start the test and set the browser's viewport size to 800x600.
                eyes.Open(driver, "Transunion Website", "Transunion Home Page " + browserSize + " " + 
                    ConfigurationManager.AppSettings["Browser"].ToString(), Helpers.GetBrowserSize(browserSize, driver));

                // Visual checkpoint #1.
                eyes.CheckWindow("TU Home Page");

                // Click the "Get your credit" button.
                driver.FindElement(By.XPath("//a[contains(text(),'Get your credit')]")).Click();

                // Visual checkpoint #2.
                eyes.CheckWindow("Get My Credit Score");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            

        }



    }
}
