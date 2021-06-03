using OpenQA.Selenium;

namespace BasicFramework.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CheckTitle => Driver.FindElement(By.CssSelector(".modal-title.h4"));


        public string GetHeaderTitle()
        {
            return CheckTitle.Text;
        }
    }
}