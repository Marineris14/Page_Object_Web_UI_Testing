using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Test_Cases
{
    class LogIn_Page
    {
        private readonly IWebDriver _webDriver;
        private readonly By _emailField = By.CssSelector("input[type=email]");
        private readonly By _passwordField = By.CssSelector("input[type=password]");
        private readonly By _logInButton = By.CssSelector("button[class^=SignInForm__submitButton]");
        private readonly By _errorMessageForInvalidEmail = By.XPath("//input[@name = 'email']/../div[@class='FormErrorText__error---nzyq']");
        private readonly By _errorMessageForInvalidPassword = By.XPath("//input[@name = 'password']/../div[@class='FormErrorText__error---nzyq']/div");

        public LogIn_Page(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public LogIn_Page GoToSignInPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");
            return this;
        }

        public LogIn_Page ImputEmailField(string email)
        {
            _webDriver.FindElement(_emailField).SendKeys(email);
            return this;
        }

        public LogIn_Page ImputPasswordField(string password)
        {
            _webDriver.FindElement(_passwordField).SendKeys(password);
            return this;
        }

        public void logInButton() => _webDriver.FindElement(_logInButton).Click();
        public string GetErrorMessageAboutEmail() =>
        _webDriver.FindElement(_errorMessageForInvalidEmail).Text;
        public string GetErrorMessageAboutPassword() =>
        _webDriver.FindElement(_errorMessageForInvalidPassword).Text;

    }
}
