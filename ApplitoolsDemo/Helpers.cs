using OpenQA.Selenium;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplitoolsDemo
{

    public class Helpers
    {
        public static Size GetBrowserSize(string browserSize, IWebDriver driver)
        {
            Size size;

            switch (browserSize)
            {
                case "Full":
                    driver.Manage().Window.Maximize();
                    size = driver.Manage().Window.Size;
                    return size;
                case "Half":
                    driver.Manage().Window.Size = new Size(985, 1061);
                    size = driver.Manage().Window.Size;
                    return size;
                case "Mobile":
                    driver.Manage().Window.Size = new Size(414, 736);
                    size = driver.Manage().Window.Size;
                    return size;
                default:
                    Console.WriteLine("None of the browser sizes were provided.");
                    size = driver.Manage().Window.Size;
                    return size;
            }
        }
    }
}
