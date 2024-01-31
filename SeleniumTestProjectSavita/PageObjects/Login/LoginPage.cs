using CommonUtilities;
using CommonUtilities.DataHelper;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Text;

namespace SeleniumTestProjectSavita.PageObjects.Login
{
    public class LoginPage : Base
    {
        public LoginPage(IWebDriver driver) 
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "ap_email")]
        public IWebElement emailId;

        [FindsBy(How = How.XPath , Using = "//span[@class='a-button-inner']//child::input")]
        public IWebElement continueButton;

        public void ClickOnContinue()
        {
            SeleniumCustomMethods.ClickOperation(continueButton);
        }

        public void EnterUserId()
        {
            SeleniumCustomMethods.EnterText(emailId, ExcelOperations.ReadData(0, "UserName"));
        }
    }
}
