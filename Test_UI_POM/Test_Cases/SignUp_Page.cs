using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Test_Cases
{
    class SignUp_Page
    {
        private readonly IWebDriver _webDriver;
        private readonly By _SignUpButton = By.CssSelector("[class='Navbar__signUp--12ZDV']");
        private readonly By _firstNameField = By.CssSelector("[name = 'first_name']");
        private readonly By _lastNameField = By.CssSelector("[name = 'last_name']");
        private readonly By _emailField = By.CssSelector("[name='email']");
        private readonly By _paswordField = By.CssSelector("[name='password']");
        private readonly By _confirmPaswordField = By.CssSelector("[name='password_confirm']");
        private readonly By _phoneNumberField = By.CssSelector("[name='phone_number']");
        private readonly By _nextButton = By.CssSelector("[type='submit']");
        private readonly By _companyNameField = By.CssSelector("[name='company_name']");
        private readonly By _companyWebSiteField = By.CssSelector("[name='company_website']");
        private readonly By _addressField = By.CssSelector("[name='location']");
        private readonly By _industryList = By.CssSelector("[name='industry']");
        private readonly By _finishButton = By.CssSelector("[type='submit']");
        // Error Messages for incorrect data entering in fields on SignUp page
        private readonly By _errorMessageIvalidFirstName = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='first_name']../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorMessageInvalidLastName = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='last_name']/../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorMessageInvalidEmail = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='email']/../div[@class = 'FormErrorText__error---nzyq']/div");
        private readonly By _errorMessageInvalidPassword = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='password']/../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorMessageInvalidPasswordLenght = By.XPath(".//*[text()='From 8 to 25 characters']/..");
        private readonly By _errorMessageInvalidPasswordNumbers = By.XPath(".//*[text()='At least one number']/..");
        private readonly By _errorMessageInvalidPasswordUpperCase = By.XPath(".//*[text()='At least one capital letter']/..");
        private readonly By _errorMessageInvalidPasswordLowCase = By.XPath(".//*[text()='At least one lowercase letter']/..");
        private readonly By _errorMessageInvalidPasswordMarks = By.XPath(".//*[text()='At least one special character such as an exclamation mark']/..");
        private readonly By _errorMessagePasswordMath = By.XPath(".//*[text()='Passwords match']/..");
        private readonly By _errorMessagePasswordConfirmation = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']" +
            "//input[@name='password_confirm']/../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorMessagePhone = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']" +
            "//input[@name='phone_number']/../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorMessageCompanyWebSiteInput = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']" +
            "//input[@name='company_website']/../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorMessageIncorrectAddress = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='location']/../div[@class = 'FormErrorText__error---nzyq']");

        public SignUp_Page(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public SignUp_Page GoToSignUpPage()
        {
            _webDriver
                .Navigate()
                .GoToUrl("https://newbookmodels.com/");
            return this;
        }

        public SignUp_Page SignUpButtonClick()
        {
            _webDriver
                .FindElement(_SignUpButton)
                .Click();
            return this;
        }

        public SignUp_Page EnterFirstName(string firstName)
        {
            _webDriver
                .FindElement(_firstNameField)
                .SendKeys(firstName);
            return this;
        }

        public SignUp_Page EnterLastName(string lastName)
        {
            _webDriver
                .FindElement(_lastNameField)
                .SendKeys(lastName);
            return this;
        }

        public SignUp_Page EnterEmail(string email)
        {
            _webDriver
                .FindElement(_emailField)
                .SendKeys(email);
            return this;
        }

        public SignUp_Page EnterPassword(string password)
        {
            _webDriver
                .FindElement(_paswordField)
                .SendKeys(password);
            return this;
        }

        public SignUp_Page ConfirmPassword(string password)
        {
            _webDriver
                .FindElement(_confirmPaswordField)
                .SendKeys(password);
            return this;
        }

        public SignUp_Page EnterPhoneNumber(string phoneNumber)
        {
            _webDriver
                .FindElement(_phoneNumberField)
                .SendKeys(phoneNumber);
            return this;
        }

        public void NextButtonClick()
        {
            _webDriver
                .FindElement(_nextButton).Click();
        }

        public SignUp_Page EnterNameOfCompany(string companyName)
        {
            _webDriver
                .FindElement(_companyNameField)
                .SendKeys(companyName);
            return this;
        }

        public SignUp_Page EnterCompanyWebSite(string companyWebsite)
        {
            _webDriver
                .FindElement(_companyWebSiteField)
                .SendKeys(companyWebsite);
            return this;
        }

        public SignUp_Page EnterAddress(string companyAddress)
        {
            _webDriver
                .FindElement(_addressField)
                .SendKeys(companyAddress);
            return this;
        }

        public SignUp_Page ClickOnIndustryListItem(string indastryItem)
        {
            _webDriver
                .FindElement(_industryList)
                .SendKeys(indastryItem);
            return this;
        }

        public void FinishButtonClick()
        {
            _webDriver
                .FindElement(_finishButton).Click();
        }

        public string ErrorInFirstNameFieldInput() => 
            _webDriver.FindElement(_errorMessageIvalidFirstName).Text;

        public string ErrorInLastNameFieldInput() =>
            _webDriver.FindElement(_errorMessageInvalidLastName).Text;

        public string ErrorInEmailFieldInput() => 
            _webDriver.FindElement(_errorMessageInvalidEmail).Text;

        public string ErrorInPasswordFieldInput() => 
            _webDriver.FindElement(_errorMessageInvalidPassword).Text;

        public string ErrorInPasswordFieldInputLenght() => 
            _webDriver.FindElement(_errorMessageInvalidPasswordLenght).Text;

        public string ErrorInPasswordFieldInputNumbers() => 
            _webDriver.FindElement(_errorMessageInvalidPasswordNumbers).Text;

        public string ErrorInPasswordFieldInputUpperCase() => 
            _webDriver.FindElement(_errorMessageInvalidPasswordUpperCase).Text;

        public string ErrorInPasswordFieldInputLowerCase() => 
            _webDriver.FindElement(_errorMessageInvalidPasswordLowCase).Text;

        public string ErrorInPasswordFieldInputMarks() =>
            _webDriver.FindElement(_errorMessageInvalidPasswordMarks).Text;

        public string ErrorInPasswordFieldInputMatch() => 
            _webDriver.FindElement(_errorMessagePasswordMath).Text;

        public string ErrorInPasswordFieldInputConfirmation() =>
           _webDriver.FindElement(_errorMessagePasswordConfirmation).Text;

        public string ErrorInPhoneNumberFieldInput() =>
           _webDriver.FindElement(_errorMessagePhone).Text;

        public string ErrorInCompanyWebsiteFieldInput() =>
          _webDriver.FindElement(_errorMessageCompanyWebSiteInput).Text;

        public string ErrorInCompanyAddressFieldInput() =>
          _webDriver.FindElement(_errorMessageIncorrectAddress).Text;
    }
}