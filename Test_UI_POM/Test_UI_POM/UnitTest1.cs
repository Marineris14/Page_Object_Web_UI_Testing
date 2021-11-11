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


namespace Test_UI_POM
{
    public class Tests_UI
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            driver = new ChromeDriver(options);
            Actions actions = new Actions(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://newbookmodels.com/");
        }

        [Test]
        public void SignIn()
        {
            IWebElement singUpButton = driver.FindElement(By.CssSelector("[class=\"Navbar__signUp--12ZDV\"]"));
            singUpButton.Click();
            string inputFirstName = "Amy";
            IWebElement firstNameSpace = driver.FindElement(By.CssSelector("[name=\"first_name\"]"));
            firstNameSpace.SendKeys(inputFirstName);
            string inputSecondtName = "Parker";
            IWebElement secondNameSpace = driver.FindElement(By.CssSelector("[name=\"last_name\"]"));
            secondNameSpace.SendKeys(inputSecondtName);
            IWebElement email = driver.FindElement(By.CssSelector("[name='email']"));
            DateTime dataTime = new DateTime();
            dataTime = DateTime.Now;
            string name = dataTime.ToString();
            name = name.Replace(".", "");
            name = name.Replace(" ", "");
            name = name.Replace(":", "");
            email.SendKeys("newMail" + name + "@test.com");
            string inputPassword = "12345Nm$";
            IWebElement passwordSpace = driver.FindElement(By.CssSelector("[name=\"password\"]"));
            passwordSpace.SendKeys(inputPassword);
            string confirmPassword = "12345Nm$";
            IWebElement confirmPasswordSpace = driver.FindElement(By.CssSelector("[name=\"password_confirm\"]"));
            confirmPasswordSpace.SendKeys(confirmPassword);
            string mobileNumber = "444.567.7893";
            IWebElement phoneNumperSpace = driver.FindElement(By.CssSelector("[name=\"phone_number\"]"));
            phoneNumperSpace.SendKeys(mobileNumber);
            IWebElement nextButton = driver.FindElement(By.CssSelector("[class=\"SignupForm__submitButton--1m1C2 " +
                "Button__button---rQSB Button__themePrimary--E5ESP Button__sizeMedium--uLCYD Button__fontSmall--1EPi5 " +
                "Button__withTranslate--1qGAH\"]"));
            nextButton.Click();
            string companyName = "Tionele";
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            IWebElement companyNameSpace = driver.FindElement(By.CssSelector("[name=\"company_name\"]"));
            companyNameSpace.SendKeys(companyName);
            Assert.AreEqual("https://newbookmodels.com/join/company", driver.Url);
            string companyWebsite = companyName + ".com";
            IWebElement companyWebsiteSpace = driver.FindElement(By.CssSelector("[name=\"company_website\"]"));
            companyWebsiteSpace.SendKeys(companyWebsite);
            string companyLocation = "4417 Aylesford Street, Big Spring, TX, USA";
            IWebElement locationSpace = driver.FindElement(By.CssSelector("input[name=\"location\"]"));
            locationSpace.SendKeys(companyLocation);
            Thread.Sleep(1500);
            locationSpace.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            locationSpace.SendKeys(Keys.Enter);
            IWebElement buttonIndustry = driver.FindElement(By.CssSelector("[name=\"industry\"]"));
            buttonIndustry.Click();
            buttonIndustry.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            buttonIndustry.SendKeys(Keys.Enter);
            IWebElement buttonFinish = driver.FindElement(By.CssSelector("[class=\"SignupCompanyForm__submitButton--3mz3p " +
                "Button__button---rQSB Button__themePrimary--E5ESP Button__sizeMedium--uLCYD Button__fontSmall--1EPi5 " +
                "Button__withTranslate--1qGAH\"]"));
            buttonFinish.Click();
            Assert.AreEqual("https://newbookmodels.com/join/company", driver.Url);
        }

        [Test]

        public void AccountingSettings_General_Info()
        {
            IWebElement logInButton1 = driver.FindElement(By.CssSelector("[class *=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx " +
                "Navbar__login--28b35\"]"));
            logInButton1.Click();
            IWebElement logInEmail = driver.FindElement(By.CssSelector("[type='email']"));
            logInEmail.SendKeys("marineriscr@gmail.com");
            IWebElement logInPassword = driver.FindElement(By.CssSelector("[name='password']"));
            logInPassword.SendKeys("14finans14Se*");
            IWebElement Finish = driver.FindElement(By.CssSelector("[type='submit']"));
            Finish.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras
                .WaitHelpers
                .ExpectedConditions
                .ElementIsVisible(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]")));
            IWebElement avatarIcon = driver.FindElement(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]"));
            avatarIcon.Click();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class=\"header header_type_page\"]")));
            IWebElement editForFirstName = driver.FindElement(By.CssSelector("[class='ng-untouched ng-pristine ng-valid'] [class='edit-switcher__icon_type_edit']"));
            editForFirstName.Click();
            IWebElement firstNameField = driver.FindElement(By.CssSelector("input[placeholder='Enter First Name']"));
            firstNameField.SendKeys("Tionel");
            IWebElement lastNameField = driver.FindElement(By.CssSelector("input[placeholder='Enter Last Name']"));
            lastNameField.SendKeys("Jupiterya");
            IWebElement locationField = driver.FindElement(By.CssSelector("input[placeholder='Enter Company Location']"));
            locationField.SendKeys("Sacramento St, San Francisco, CA, USA");
            IWebElement indastryField = driver.FindElement(By.CssSelector("input[placeholder='Enter Industry']"));
            indastryField.SendKeys("Apparel");
            IWebElement safeGeneralInfo = driver.FindElement(By.CssSelector("[type=\"submit\"]"));
            safeGeneralInfo.Click();
            Assert.AreEqual("https://newbookmodels.com/account-settings/account-info/edit", driver.Url);
        }

        public void AccountingSettings_EmailPasswordAndCreditCard()
        {
            IWebElement logInButton1 = driver.FindElement(By.CssSelector("[class *=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx " +
                "Navbar__login--28b35\"]"));
            logInButton1.Click();
            IWebElement logInEmail = driver.FindElement(By.CssSelector("[type='email']"));
            logInEmail.SendKeys("marineriscr@gmail.com");
            IWebElement logInPassword = driver.FindElement(By.CssSelector("[name='password']"));
            logInPassword.SendKeys("14finans14Se*");
            IWebElement Finish = driver.FindElement(By.CssSelector("[type='submit']"));
            Finish.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras
                .WaitHelpers
                .ExpectedConditions
                .ElementIsVisible(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]")));
            IWebElement avatarIcon = driver.FindElement(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]"));
            avatarIcon.Click();
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class=\"header header_type_page\"]")));
            IWebElement editForEmail = driver.FindElement(By.CssSelector("[class='ng-untouched ng-pristine ng-valid'] [class='edit-switcher__icon_type_edit']"));
            editForEmail.Click();
            IWebElement currentEmailPassword = driver.FindElement(By.CssSelector("input[placeholder='Enter Password']"));
            currentEmailPassword.SendKeys("14finans14Se*");
            IWebElement newEmail = driver.FindElement(By.CssSelector("input[placeholder='Enter E-mail']"));
            newEmail.SendKeys("tedfdnb@gmail.com");
            IWebElement saveEdit = driver.FindElement(By.CssSelector("[type='submit']"));
            saveEdit.Click();
            IWebElement cardNumber = driver.FindElement(By.CssSelector("[name='company_website']"));
            cardNumber.SendKeys("6011000000000004");
            IWebElement expCartDate = driver.FindElement(By.CssSelector("[name='exp-date']"));
            expCartDate.SendKeys("12/24");
            IWebElement cvc = driver.FindElement(By.CssSelector("[name='cvc']"));
            cvc.SendKeys("123");
            IWebElement saveCard = driver.FindElement(By.CssSelector("[type='submit']"));
            saveCard.Click();
            IWebElement editPhoneNum = driver.FindElement(By.XPath("/html/body/nb-app/ng-component/" +
                "nb-internal-layout/common-layout/section/div/ng-component/nb-account-info-edit/common-border" +
                "/div[5]/div/nb-account-info-phone/div[1]/div/nb-edit-switcher/div/div"));
            editPhoneNum.Click();
            IWebElement currentPassword = driver.FindElement(By.CssSelector("[class=\"ng-pristine ng-valid " +
                "input__self input__self_error input__self_type_password-underline ng-touched\"]"));
            currentPassword.SendKeys("14finans14Se*");
            IWebElement phoneNum = driver.FindElement(By.CssSelector("[class=\"ng-pristine ng-valid input__self " +
                "input__self_error input__self_type_text-underline ng-touched\"]"));
            phoneNum.SendKeys("5678762345");
            IWebElement saveinfo = driver.FindElement(By.CssSelector("[type='submit']"));
            saveinfo.Click();
            Assert.AreEqual("https://newbookmodels.com/explore", driver.Url);
        }

        [Test]

        public void AddImageAvatar()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras
                .WaitHelpers
                .ExpectedConditions
                .ElementIsVisible(By.CssSelector("[class *='Navbar__signUp--12ZDV']")));
            IWebElement SignUpButton = driver.FindElement(By.CssSelector("[class *='Navbar__signUp--12ZDV']"));
            SignUpButton.Click();
            IWebElement avatarIcon = driver.FindElement(By.CssSelector("[class *='FileInput__container--DGYl- SignupAvatar__avatarFieldInner--Tu71w']"));
            avatarIcon.Click();
            Assert.AreEqual("https://newbookmodels.com/explore", driver.Url);
        }

        [Test]
        public void LogIn()
        {
            IWebElement logInButton = driver.FindElement(By.CssSelector("[class *=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx Navbar__login--28b35\"]"));
            logInButton.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string title = driver.Title;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement logInEmailField = driver.FindElement(By.CssSelector("[class *= 'Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp']"));
            logInEmailField.SendKeys("marineriscr@gmail.com");
            IWebElement logInPasswordField = driver.FindElement(By.CssSelector("[name=\"password\"]"));
            logInPasswordField.SendKeys("14finans14Se*");
            IWebElement autologInButton = driver.FindElement(By.CssSelector("[type=\"submit\"]"));
            autologInButton.Click();
            Assert.AreEqual("https://newbookmodels.com/auth/signin", driver.Url);
        }

        [Test]

        public void LogOut()
        {
            IWebElement logInButton = driver.FindElement(By.CssSelector("[class *=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx Navbar__login--28b35\"]"));
            logInButton.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string title = driver.Title;
            IWebElement logInEmailField = driver.FindElement(By.CssSelector("[class *= 'Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp']"));
            logInEmailField.SendKeys("marineriscr@gmail.com");
            IWebElement logInPasswordField = driver.FindElement(By.CssSelector("[name=\"password\"]"));
            logInPasswordField.SendKeys("14finans14Se*");
            IWebElement autologInButton = driver.FindElement(By.CssSelector("[type=\"submit\"]"));
            autologInButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras
                .WaitHelpers
                .ExpectedConditions
                .ElementIsVisible(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]")));
            Assert.AreEqual("https://newbookmodels.com/explore", driver.Url);
            IWebElement avatarIconForExit = driver.FindElement(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]"));
            avatarIconForExit.Click();
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            action.SendKeys(Keys.PageDown).Perform();
            action.SendKeys(Keys.PageDown).Perform();
            IWebElement exit = driver.FindElement(By.CssSelector("[class=\"link link_type_logout link_active\"]"));
            exit.Click();
            Assert.AreEqual("https://newbookmodels.com/auth/signin", driver.Url);
        }

        [Test]
        public void NewbookAppButtonLinkTest_LogIn()
        {
            IWebElement logInButton = driver.FindElement(By.CssSelector("[class *=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx Navbar__login--28b35\"]"));
            logInButton.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string title = driver.Title;
            IWebElement NewbookAppLink = driver.FindElement(By.CssSelector("[class *= 'SignInPage__modelLink--22zhX']"));
            NewbookAppLink.Click();
            Assert.AreEqual("https://newbookmodels.com/auth/signin", driver.Url);
        }

        [Test]
        public void NewbookAppButtonLinkTest_SignIn()
        {
            IWebElement SignUpButton = driver.FindElement(By.CssSelector("[class *='Navbar__signUp--12ZDV']"));
            SignUpButton.Click();
            IWebElement NewbookAppLink = driver.FindElement(By.CssSelector("[class *= 'SignupPageLayout__modelsLink--2zxUb']"));
            NewbookAppLink.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            string title = driver.Title;
            Assert.AreEqual("https://apps.apple.com/us/app/newbook/id1316969583?ls=1", driver.Url);
        }

        [TearDown]
        public void After()
        {
            driver.Dispose();
        }
    }
}
