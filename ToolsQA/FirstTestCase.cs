using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA
{
    class FirstTestCase
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        static void Main(string[] args)
        {
            //IWebDriver driver = new FirefoxDriver(Environment.CurrentDirectory);
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.google.com";
            IWebElement webElement = driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div/div[1]/div/div[1]/input"));
            webElement.SendKeys("search word");
            webElement.SendKeys(Keys.Enter);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
