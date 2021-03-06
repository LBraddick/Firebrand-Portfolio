﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Test_FrameWork
{
    public static class Browser
    {

        static IWebDriver webDriver = new FirefoxDriver();

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
