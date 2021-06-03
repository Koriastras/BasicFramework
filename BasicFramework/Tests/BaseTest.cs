using BasicFramework.Framework;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;

namespace BasicFramework.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected ILog Logger;

        [SetUp]
        public virtual void Init()
        {
            Logger = LogManager.GetLogger(GetType());
            Logger.Info("log4net initialized");
            Driver = Settings.GetDriver();
            Driver.Manage().Window.Maximize();
            Logger.Info("Test started");
        }

        [TearDown]
          public virtual void Cleanup()
        {
            Driver.Quit();
        }
    }
}
