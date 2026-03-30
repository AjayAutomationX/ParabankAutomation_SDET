using NUnit.Framework;
using ParabankAutomation.Base;
using ParabankAutomation.Pages;
using FluentAssertions;
using AventStack.ExtentReports;

namespace ParabankAutomation.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void ValidLoginTest()
        {
            test = extent.CreateTest("Valid Login Test");

            LoginPage loginPage = new LoginPage(driver);

            loginPage.EnterUsername("user");
            loginPage.EnterPassword("pass");
            loginPage.ClickLogin();

            loginPage.GetPageTitle().Should().Contain("ParaBank");

            test.Pass("Valid login executed successfully");
        }

        [Test]
        public void EmptyFieldsTest()
        {
            test = extent.CreateTest("Empty Fields Test");

            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickLogin();

            string error = loginPage.GetErrorMessage();
            error.Should().Contain("Please enter a username and password");

            test.Pass("Empty fields validation successful");
        }

        [Test]
        public void OnlyUsernameTest()
        {
            test = extent.CreateTest("Only Username Test");

            LoginPage loginPage = new LoginPage(driver);

            loginPage.EnterUsername("user");
            loginPage.ClickLogin();

            string error = loginPage.GetErrorMessage();
            error.Should().Contain("Please enter a username and password");

            test.Pass("Only username validation successful");
        }

        [Test]
        public void OnlyPasswordTest()
        {
            test = extent.CreateTest("Only Password Test");

            LoginPage loginPage = new LoginPage(driver);

            loginPage.EnterPassword("pass");
            loginPage.ClickLogin();

            string error = loginPage.GetErrorMessage();
            error.Should().Contain("Please enter a username and password");

            test.Pass("Only password validation successful");
        }
    }
}