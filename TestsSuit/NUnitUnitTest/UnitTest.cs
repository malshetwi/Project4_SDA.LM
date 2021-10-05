using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace NUnitUnitTest
{
    [TestFixture]
    public class UnitTest
    {
        IWebDriver driver = new FirefoxDriver();

        [SetUp]
        public void Initilaize()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44357/"); // Need for configuring Self Signed localhost SSL Certificates
        }
        [TearDown]
        


        [Test]
        public void TestOrder1() // Test Order 2nd Item
        {
            driver.FindElement(By.XPath("/html/body/div[1]/main/div/div/table/tbody/tr[2]/td[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/form/div[4]/input")).Click();
        }

        [Test]
        public void TestOrder2() // Test Order 3nd Item
        {
            driver.FindElement(By.XPath("/html/body/div[1]/main/div/div/table/tbody/tr[3]/td[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/form/div[4]/input")).Click();
        }
    }
}
