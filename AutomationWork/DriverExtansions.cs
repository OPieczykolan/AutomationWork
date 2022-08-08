using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace AutomationWork
{
    public static class DriverExtansions
    {
        public static void Click(this IWebDriver driver, string xPath)
        {
            IWebElement element = driver.FindElement(By.XPath(xPath));
            element.Click();
        }

        public static void SendKeys(this IWebDriver driver, string xPath, string parameter)
        {
            IWebElement element = driver.FindElement(By.XPath(xPath));
            element.SendKeys(parameter);
        }

        public static void Wait(this IWebDriver driver, string xPath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement elemment = wait.Until(e => e.FindElement(By.XPath(xPath)));
            if (elemment.Displayed)
            {

            }
            else
            {
                //throw new Xunit.Sdk.XunitException();
                Assert.True(false, "Element not found");
            }
        }
    }
}
