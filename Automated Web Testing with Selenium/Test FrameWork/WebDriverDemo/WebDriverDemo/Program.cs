using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = @"C:\Users\louise.braddick\Documents\Visual Studio 2015\Projects\Automated Web Testing with Selenium\WebDriverDemo\WebDriverDemo\TestPage.html";

            // Choosing a radio Button
            //var radioButton = driver.FindElements(By.Name("color"))[1];
            //radioButton.Click();

            // Getting a Radio Button Value
            ////var radioButtons = driver.FindElements(By.Name("color"));
            ////foreach (var radioButton in radioButtons)
            ////{
            ////    if (radioButton.Selected)
            ////        Console.WriteLine(radioButton.GetAttribute("value"));
            ////}
            ////Console.ReadLine();

            // Selecting a Checkbox
            ////var checkBox = driver.FindElement(By.Id("check1"));
            ////checkBox.Click();

            // Using SelectElement
            ////var select = driver.FindElement(By.Id("select1"));

            ////var selectElement = new SelectElement(select);
            ////selectElement.SelectByText("Frank");

            // Getting Table Data
            ////var outerTable = driver.FindElement(By.TagName("table"));
            ////var innerTable = outerTable.FindElement(By.TagName("table"));
            ////var row = innerTable.FindElements(By.TagName("td"))[1];
            ////Console.WriteLine(row.Text);
            ////Console.ReadLine();

            // Getting Table Data with XPath
            ////var row = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
            ////Console.WriteLine(row.Text);
            ////Console.ReadLine();

            // Using the explicit Wait
            IWebDriver driver = new ChromeDriver(@"C:\Users\louise.braddick\Documents\Libraries");

            driver.Url = "http://www.google.co.uk";

            var searchBox = driver.FindElement(By.Id("gbqfq"));
            searchBox.SendKeys("pluralsight");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var imagesLink = wait.Until(d =>
            {
                var elements = driver.FindElements(By.ClassName("kl"));
                if (elements.Count > 0)
                    return elements[0];
                return null;
            });

            imagesLink.Click();

            var ul = driver.FindElement(By.ClassName("rg_ul"));
            var firstImageLink = ul.FindElements(By.TagName("a"))[0];
            firstImageLink.Click();
        }
    }
}
