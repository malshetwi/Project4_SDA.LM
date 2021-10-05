using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    class SeleniumTest
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();  // Test Order 1nd Item
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n # Developer Message: Your Security settings of your browser may block the opening of localhost !! \n");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44357/"); // Need for configuring Self Signed localhost SSL Certificates
            Console.WriteLine($"\n Strat testing Pizza Ordering");
            driver.FindElement(By.XPath("/html/body/div[1]/main/div/div/table/tbody/tr[1]/td[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/form/div[4]/input")).Click();
            driver.Close();
            Console.WriteLine($"\n All test lines done successfully");
        }
    }
}
