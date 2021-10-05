using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SpecFlowTest.Steps
{
    [Binding]
    public sealed class TestOrder
    {
        IWebDriver driver = new FirefoxDriver();
        private readonly ScenarioContext _scenarioContext;
        public TestOrder(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I open URL")]
        public void GivenIOpenURL()
        {
            //ScenarioContext.Current.Pending();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44357/"); // Need for configuring Self Signed localhost SSL Certificates
        }

        [Given(@"I Press on fourth pizza")]
        public void GivenIPressOnFourthPizza()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/main/div/div/table/tbody/tr[4]/td[5]/a")).Click();
        }

        [When(@"I Confirm")]
        public void WhenIConfirm()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/form/div[4]/input")).Click();
        }

        [Then(@"I verify order submited")]
        public void ThenIVerifyOrderSubmited(string OrderID)
        {
            driver.FindElement(By.Id("OrderID")).GetAttribute(OrderID);
            driver.Close();
        }

    }
}
