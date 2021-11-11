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

        private readonly By _errorMessageIvalidFirstName = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='first_name']../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorMessageInvalidLastName = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='last_name']/../div[@class = 'FormErrorText__error---nzyq']");
        private readonly By _errorMessageInvalidEmail = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='email']/../div[@class = 'FormErrorText__error---nzyq']/div");
        private readonly By _errorMessageInvalidPassword = By.XPath("//div[@class='SignupFormLayout__fieldRow--bGt25']//" +
            "input[@name='password']/../div[@class = 'FormErrorText__error---nzyq']");