using NUnit.Framework;
using ParabankAutomation.Base;
using ParabankAutomation.Pages;
using FluentAssertions;

namespace ParabankAutomation.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void ValidLoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.EnterUsername("anyUser");
            loginPage.EnterPassword("anyPass");
            loginPage.ClickLogin();

            loginPage.GetPageTitle().Should().Contain("ParaBank");
        }

        [Test]
        public void EmptyFieldsTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickLogin();

            string error = loginPage.GetErrorMessage();
            error.Should().Contain("Please enter a username and password");
        }

        [Test]
        public void OnlyUsernameTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.EnterUsername("user");
            loginPage.ClickLogin();

            string error = loginPage.GetErrorMessage();
            error.Should().Contain("Please enter a username and password");
        }

        [Test]
        public void OnlyPasswordTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.EnterPassword("pass");
            loginPage.ClickLogin();

            string error = loginPage.GetErrorMessage();
            error.Should().Contain("Please enter a username and password");
        }
    }
}