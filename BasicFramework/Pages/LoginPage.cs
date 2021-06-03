using BasicFramework.Framework.Models;
using OpenQA.Selenium;
using System;
using System.IO;

namespace BasicFramework.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement FirstNameBox => Driver.FindElement(By.Id("firstName"));
        private IWebElement LastNameBox => Driver.FindElement(By.Id("lastName"));
        private IWebElement EmailBox => Driver.FindElement(By.Id("userEmail"));
        private IWebElement GenderBox => Driver.FindElement(By.XPath("//label[text() = 'Female']"));   //("//*[@class = 'custom-control custom-radio custom-control-inline'] // child :: label"));
        private IWebElement MobileBox => Driver.FindElement(By.Id("userNumber"));
        private IWebElement DateOfBirthBox => Driver.FindElement(By.Id("dateOfBirthInput")); ////div[@aria-label = 'Choose Wednesday, May 18th, 1994']
        private IWebElement ChooseMonth => Driver.FindElement(By.XPath("//select[@class = 'react-datepicker__month-select']//child::option[@value = '4']"));

        private IWebElement ChooseYear => Driver.FindElement(By.XPath("//select[@class = 'react-datepicker__year-select']//child::option[@value = '1994']"));
        private IWebElement ChooseDay => Driver.FindElement(By.XPath("//div[@class = 'react-datepicker__day react-datepicker__day--018']"));
        private IWebElement SubjectsBox => Driver.FindElement(By.XPath("//div[@class = 'subjects-auto-complete__value-container subjects-auto-complete__value-container--is-multi css-1hwfws3']"));

        private IWebElement HobbiesBox => Driver.FindElement(By.XPath("//label[text() = 'Reading']"));
        private IWebElement Picture => Driver.FindElement(By.Id("uploadPicture"));

        private IWebElement CurrentAddressBox => Driver.FindElement(By.Id("currentAddress"));  //("//div[@class = 'col-md-9 col-sm-12']//child::textarea"));

        private IWebElement StateBox => Driver.FindElement(By.CssSelector("#state"));
        private IWebElement StateBoxChoose => Driver.FindElement(By.XPath("//div[text() = 'Uttar Pradesh']"));

        private IWebElement CityBox => Driver.FindElement(By.CssSelector("#city"));

        private IWebElement CityBoxChoose => Driver.FindElement(By.XPath("//div[text() = 'Lucknow']"));
        private IWebElement SubmitButton => Driver.FindElement(By.CssSelector("#submit"));




        public HomePage Login(User user)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)Driver;
            FirstNameBox.Click();
            FirstNameBox.SendKeys(user.FirstName);
            LastNameBox.Click();
            LastNameBox.SendKeys(user.LastName);
            EmailBox.Click();
            EmailBox.SendKeys(user.Email);
            GenderBox.Click();
            MobileBox.Click();
            MobileBox.SendKeys(user.Mobile);
            DateOfBirthBox.Click();
            ChooseMonth.Click();
            ChooseYear.Click();
            ChooseDay.Click();
            SubjectsBox.Click();
            HobbiesBox.Click();
            CurrentAddressBox.SendKeys(user.CurrentAddress);
            Picture.SendKeys(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/Picture_1.jpg"));
            je.ExecuteScript("scroll(0, 250)");
            StateBox.Click();
            StateBoxChoose.Click();
            CityBox.Click();
            CityBoxChoose.Click();
            SubmitButton.Click();
            return new HomePage(Driver);
        }
    }
}