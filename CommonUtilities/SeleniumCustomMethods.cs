using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CommonUtilities
{
    public  class SeleniumCustomMethods
    {
        public static void ClickOperation(IWebElement button)
        {
            button.Click();
        }
        public static void EnterText(IWebElement textbox, string text)
        {
            textbox.Clear();
            textbox.SendKeys(text);
        }

        public static void MoveToElement(IWebDriver driver , IWebElement element)
        {
            Actions actions = new(driver);
            actions.MoveToElement(element).Perform();
        }
      
    }
}
