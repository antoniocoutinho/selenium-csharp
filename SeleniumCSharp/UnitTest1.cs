using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharp
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/guru99home/");
            driver.Manage().Window.Maximize();
            IWebElement testingBtn = driver.FindElement(By.XPath("//a[@href='http://www.guru99.com/software-testing.html']"));
            testingBtn.Click();
            String testingTutorial = driver.FindElement(By.XPath("//h1")).Text;
            Console.WriteLine(testingTutorial);
            Assert.AreEqual(testingTutorial, "Software Testing Tutorial: Free Course");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}