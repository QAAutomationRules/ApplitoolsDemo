using Applitools;
using Applitools.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium.Android;

namespace ApplitoolsDemo
{
    [Binding]
    public sealed class Hooks
    {


        [BeforeScenario]
        public void BeforeScenario()
        {
            ScenarioContext.Current.Set<IWebDriver>(GetWebDriver(ConfigurationManager.AppSettings["Browser"]), "WebDriver");

            // Initialize the eyes SDK and set your private API key.
            Eyes eyes = new Eyes();
            eyes.ApiKey = "IsXN5ETWMiL1bMaRaQY0DIJrvH3KS7w2z1007WdL3kaA0110";
            eyes.WaitBeforeScreenshots = 2000;
            eyes.ForceFullPageScreenshot = true;
            eyes.HideScrollbars = true;
                       
            //Set Batch ID
            BatchInfo batch = new BatchInfo("Transunion.Com");
            string batchId = Environment.GetEnvironmentVariable("APPLITOOLS_BATCH_ID");

            if (batchId != null)
            {
                batch.Id = Environment.GetEnvironmentVariable("APPLITOOLS_BATCH_ID");
            }

            eyes.Batch = batch;
            
            ScenarioContext.Current.Set<Eyes>(eyes, "Eyes");
        }

        [AfterScenario]
        public void AfterScenario()
        {

            //Close Applitools Eyes.
            ScenarioContext.Current.Get<Eyes>("Eyes")
                .Close();
        
            //Quit Selenium WebDriver
            ScenarioContext.Current.Get<IWebDriver>("WebDriver")
                .Quit();

            //Abort if not closed Applitools Eyes.
            ScenarioContext.Current.Get<Eyes>("Eyes")
                .AbortIfNotClosed();
        }

        public IWebDriver GetWebDriver(string browser)
        {
            IWebDriver driver = null;
            WebDriverWait wait = null;

            switch (browser.ToLower())
            {
                case "firefox":
                    
                    FirefoxOptions ffoptions = new FirefoxOptions();
                    var portNumber = new Random();
                    ffoptions.Profile = new FirefoxProfile();
                    ffoptions.Profile.Clean();
                    ffoptions.Profile.Port = portNumber.Next(7000, 8000);
                    ffoptions.BrowserExecutableLocation = Path.Combine(Hooks.GetBasePath, @"Drivers");
                   
                    driver = new FirefoxDriver();
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    break;

                case "ie":
                    var ieOptions = new InternetExplorerOptions
                    {
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true
                    };

                    driver = new InternetExplorerDriver(Path.Combine(Hooks.GetBasePath, @"Drivers"), ieOptions);
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    break;

                case "edge":

                    EdgeOptions eoptions = new EdgeOptions();
                    eoptions.PageLoadStrategy = EdgePageLoadStrategy.Normal;

                    driver = new EdgeDriver(Path.Combine(Hooks.GetBasePath, @"Drivers"), eoptions);
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    break;

                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    driver = new ChromeDriver(Path.Combine(Hooks.GetBasePath, @"Drivers"));
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    break;

                case "phantomjs":
                    driver = new PhantomJSDriver(Path.Combine(Hooks.GetBasePath, @"Drivers"));
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    break;

                case "android":

                    Console.WriteLine("Connecting to Appium server");

                    DesiredCapabilities androidcapabilities = new DesiredCapabilities();
                    androidcapabilities.SetCapability("chromedriverExecutable", Path.Combine(GetBasePath, @"AppiumDrivers\chromedriver.exe"));
                    //androidcapabilities.SetCapability(CapabilityType.BrowserName, "Browser");
                    androidcapabilities.SetCapability(CapabilityType.BrowserName, "Chrome");
                    androidcapabilities.SetCapability(CapabilityType.Platform, "Android");
                    androidcapabilities.SetCapability(CapabilityType.Version, "7.0");
                    androidcapabilities.SetCapability("Device", "Android");
                    androidcapabilities.SetCapability("deviceName", "Android Emulator");

                    driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), androidcapabilities);
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                    break;

                default:
                    Console.WriteLine("No Driver");
                    break;
            }

            return driver;
        }

        public static string GetBasePath
        {
            get
            {
                var basePath =
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                basePath = basePath.Substring(0, basePath.Length - 10);
                return basePath;
            }
        }
    }
}
