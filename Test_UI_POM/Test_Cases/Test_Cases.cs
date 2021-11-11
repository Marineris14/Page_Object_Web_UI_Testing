using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using SeleniumExtras.WaitHelpers;

namespace Test_Cases
{
    public class Tests
    {
        private IWebDriver _webDriver;

        [SetUp]

        public void Setup()
        {

            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
        }

        [TestCase("", "")]
        public void LoginWithEmptyPasswordAndEmail(string email, string password)
        {
            var logInPage = new LogIn_Page(_webDriver);
            logInPage.GoToLogInPage()
                .EnterInEmailField(email)
                .EnterInPasswordField(password)
                .logInButton();
            var actualResult = logInPage.ErrorInEmailInput() + logInPage.ErrorInPasswordInput();
            Assert.AreEqual(expected: "RequiredRequired", actualResult);
        }

        [TestCase("")]
        public void LoginWithEmptyPasswordField(string email, string passwordEmpty)
        {
            var logInPage = new LogIn_Page(_webDriver);
            logInPage.GoToLogInPage()
                .EnterInEmailField(email)
                .EnterInPasswordField(passwordEmpty)
                .logInButton();
            var actualResult = logInPage.ErrorInPasswordInput();
            Assert.AreEqual(expected: "RequiredRequired", actualResult);
        }

        [TestCase("")]
        public void LoginWithEmptyEmailField(string emailEmpty, string password)
        {
            var logInPage = new LogIn_Page(_webDriver);
            logInPage.GoToLogInPage()
                .EnterInEmailField(emailEmpty)
                .EnterInPasswordField(password)
                .logInButton();
            var actualResult = logInPage.ErrorInEmailInput();
            Assert.AreEqual(expected: "RequiredRequired", actualResult);
        }
    }
}