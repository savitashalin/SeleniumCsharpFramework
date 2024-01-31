using CommonUtilities;
using SeleniumTestProjectSavita.PageObjects.Home;
using SeleniumTestProjectSavita.PageObjects.Login;

namespace SeleniumTestProjectSavita.Tests.Login
{
    [TestFixture]
    public class LoginTest : DriverUtilitycs
    {
        [OneTimeSetUp]
        public void OpenBrowsers()
        {
            LaunchBrowser();
            NavigateToURL(URLHelper.baseURL);
        }

        [Test]
        public void Login()
        {
           // HomePage homePage = new(Driver);
          //  homePage.ClickOnSignInButton();
          //  LoginPage loginPage = new (Driver);
          //  loginPage.EnterUserId();
          //  loginPage.ClickOnContinue();
        }


        [Test]
        public void Login1()
        {
            // HomePage homePage = new(Driver);
            //  homePage.ClickOnSignInButton();
            //  LoginPage loginPage = new (Driver);
            //  loginPage.EnterUserId();
            //  loginPage.ClickOnContinue();
        }


        [Test]
        public void Login2()
        {
            // HomePage homePage = new(Driver);
            //  homePage.ClickOnSignInButton();
            //  LoginPage loginPage = new (Driver);
            //  loginPage.EnterUserId();
            //  loginPage.ClickOnContinue();
        }

        [OneTimeTearDown]
        public void CloseBrowsers()
        {
           Driver.Quit();
        }

    }
}
