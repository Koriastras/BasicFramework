using System;
using BasicFramework.Framework;
using BasicFramework.Framework.Models;
using BasicFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace BasicFramework.Tests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        private User _user;
        private const string ExpectedTitle = "Thanks for submitting the form";


        [SetUp]
        protected void Initialize()
        {
            _user = User.GetDefaultUser();
        }

        [Test]
        public void ValidLoginTest()
        {
            HomePage homePage = SiteNavigator.NavigateToLoginPage(Driver).Login(_user);

            Logger.Info("Wait example");
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(x => x.FindElement(By.CssSelector("#submit")).Enabled);
           // IWebElement title = Driver.FindElement(By.CssSelector("#example-modal-sizes-title-lg"));
           // Assert.IsNotNull(title);
            Assert.AreEqual(ExpectedTitle, homePage.GetHeaderTitle(), "Title text differs from expected!");




        }
    }
}