﻿using OpenQA.Selenium;
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

            switch (browserSize.ToLower())
            {
                case "full":
                    //driver.Manage().Window.Maximize();
                    size = new Size(1500, 650);
                    break;
                case "half":
                    //driver.Manage().Window.Size = 
                    size = new Size(900, 600);
                    break;
                case "mobile chrome pixel phone":
                    //driver.Manage().Window.Size = new Size(414, 736);
                    size = new Size(412, 604);
                    break;
                default:
                    Console.WriteLine("None of the browser sizes were provided.");
                    size = driver.Manage().Window.Size;
                    break;
            }
            return size;
        }
    }
}
