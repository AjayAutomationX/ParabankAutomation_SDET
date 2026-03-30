using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using ParabankAutomation.Utilities;

namespace ParabankAutomation.Base
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected static ExtentReports extent;
        protected ExtentTest test;

        [OneTimeSetUp]
        public void StartReport()
        {
            extent = ExtentManager.GetInstance();
        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
        }
    }
}