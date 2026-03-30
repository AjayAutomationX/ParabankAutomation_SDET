using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace ParabankAutomation.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Locators
        private By username = By.Name("username");
        private By password = By.Name("password");
        private By loginButton = By.XPath("//input[@value='Log In']");
        private By errorMessage = By.ClassName("error");

        // Actions
        public void EnterUsername(string user)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(username)).Clear();
            driver.FindElement(username).SendKeys(user);
        }

        public void EnterPassword(string pass)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(password)).Clear();
            driver.FindElement(password).SendKeys(pass);
        }

        public void ClickLogin()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(loginButton)).Click();
        }

        public string GetErrorMessage()
        {
            try
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(errorMessage)).Text;
            }
            catch
            {
                return "";
            }
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }
    }
}