using CommonUtilities;
using CommonUtilities.DataHelper;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTestProjectSavita.PageObjects.Home
{
    public class HomePage : Base
    {
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id = 'nav-tools']/a[2]")]
        public IWebElement singInLink;

        public void ClickOnSignInButton()
        {
            SeleniumCustomMethods.ClickOperation(singInLink);
        }

        public void MoveToSingInLink()
        {
            SeleniumCustomMethods.MoveToElement(Driver, singInLink);
        }
    }
}
