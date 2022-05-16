using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;

namespace AutomationWork
{
    [Trait("Category", "Applications")]
    public class Tatooine

    {
        private const string HomeUrl = "https://swapi.dev/";

        [Fact]
        public void LoadHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://swapi.dev/api/people/1/");
                ReadOnlyCollection<IWebElement> peopleTable =
                    driver.FindElements(By.ClassName("str"));
                Assert.Equal("\"Luke Skywalker\"", peopleTable[1].Text);
                IWebElement tatooineLink = driver.FindElement(By.CssSelector("#content > div > div.response-info > pre > a:nth-child(56) > span"));
                tatooineLink.Click();
                DemoHelper.Pause();
                ReadOnlyCollection<IWebElement> planetTable =
                    driver.FindElements(By.ClassName("str"));
                Assert.Equal("\"Tatooine\"", planetTable[1].Text);



            }   
        }

    }
}
