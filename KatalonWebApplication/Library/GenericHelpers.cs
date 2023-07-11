using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KatalonWebApplication.Library
{
    public class GenericHelpers
    {
        public static IWebDriver? driver;

        public static void LaunchBrowser(string xpath)
        {
            ChromeOptions options = new();

            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://cms.demo.katalon.com/");

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);

            Console.WriteLine("Chrome Browser loaded successfully");

            IWebElement element = null;

            element = driver.FindElement(By.XPath(xpath));

            Assert.IsNotNull(element, "katalon website is loaded successfully");

        }

        public static void Click(string xpath, string message)
        {
            bool flag = true;
            try
            {

                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);

                IWebElement element = null;

                element = driver.FindElement(By.XPath(xpath));

                driver.FindElement(By.XPath(xpath)).Click();

                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                flag = false;
            }
            Assert.True(flag, message);
        }

        public static string GetText(string xpath)
        {

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);

            Thread.Sleep(2000);

            string text = driver.FindElement(By.XPath(xpath)).Text;

            return text;

        }

        public static int GetRowCountFromTable(string xpath)
        {

            int rowCount = driver.FindElements(By.XPath(xpath)).Count;

            return rowCount;
        }
    }
}
