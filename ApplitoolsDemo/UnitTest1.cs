using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using Applitools.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ApplitoolsDemo
{
    [TestClass]
    public class ApplitoolsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Open a Chrome browser.
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArguments("disable-infobars");
            options.AddUserProfilePreference("credentials_enable_service", false);
            var driver = new ChromeDriver(Path.Combine(Hooks.GetBasePath, @"Drivers\"), options);

            // Initialize the eyes SDK and set your private API key.
            var eyes = new Eyes();
            eyes.ApiKey = "IsXN5ETWMiL1bMaRaQY0DIJrvH3KS7w2z1007WdL3kaA0110";

            try
            {
                // Start the test and set the browser's viewport size to 800x600.
                eyes.Open(driver, "Transunion Website", "Transunion Home Page", new Size(800, 600));

                // Navigate the browser to the "hello world!" web-site.
                driver.Url = "https://transunion.com/";

                // Visual checkpoint #1.
                eyes.CheckWindow("TU Home Page");

                // Click the "Click me!" button.
                driver.FindElement(By.XPath("//a[contains(text(),'Get your credit')]")).Click();

                // Visual checkpoint #2.
                eyes.CheckWindow("Get My Credit Score");

                // End the test.
                eyes.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                // Close the browser.
                driver.Quit();

                // If the test was aborted before eyes.Close was called, ends the test as aborted.
                eyes.AbortIfNotClosed();
            }
        }

        
    }
}