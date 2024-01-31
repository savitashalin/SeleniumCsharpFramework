using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CommonUtilities
{
    public class DriverUtilitycs : Base
    {

        enum BrowserType
        {
            Chrome,
            Firefox,
        }

        public string browser = "Chrome";

        public void NavigateToURL(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
        public void LaunchBrowser()
        {
            //verificationErrors = new StringBuilder();
            //Get browser name from the config
            switch (browser.ToLower())
            {
                case "ie":

                    break;

                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    Driver = new ChromeDriver();
                    Driver.Manage().Window.Maximize();

                    break;

                case "firefox":
                    Driver = new FirefoxDriver();
                    Driver.Manage().Window.Maximize();
                  
                    break;

                default:
                    break;
            }
        }
    }
}
