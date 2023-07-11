global using NUnit.Framework;
using KatalonWebApplication.Library;
using KatalonWebApplication.WebPageObjects;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace VAA.LoyaltySystems.UITests.Core
{
    [Binding]
    public class TestInitialize
    {

        [BeforeScenario]
        public void TestSetup()
        {
            //launching Chrome Browser for execution of the test cases
            GenericHelpers.LaunchBrowser(LandingPage.katalonMainPageLogo);

        }
        [AfterScenario]
        public void TearDown()
        {
            foreach (Process proc in Process.GetProcessesByName("chromedriver"))
            {
                proc.Kill();
            }
        }
    }
}