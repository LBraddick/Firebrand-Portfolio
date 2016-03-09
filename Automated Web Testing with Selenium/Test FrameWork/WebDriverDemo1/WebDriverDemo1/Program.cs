using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;


namespace WebDriverDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new InternetExplorerDriver(@"C:\Users\louise.braddick\Documents\Libraries\");
            //IWebDriver driver = new ChromeDriver(@"C:\Users\louise.braddick\Documents\Libraries\");
            driver.Url = "http://www.google.com";

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("pluralsight");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var imagesLink = driver.FindElements(By.ClassName("q qs"))[0];
            imagesLink.Click();

            var ul = driver.FindElement(By.ClassName("rg_di rg_el ivg-i"));
            var firstImageLink = ul.FindElements(By.TagName("a"))[0];
            firstImageLink.Click();

        }
    }
}

