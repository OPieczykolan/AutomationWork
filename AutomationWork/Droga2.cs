using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace AutomationWork
{
    [Trait("Category", "Applications")]
    public class RoadTwo

    {
        private const string HomeUrl = "https://www.google.pl/maps/";


        [Fact]
        public void OnFoot()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);
                DemoHelper.Pause();
                IWebElement setupRoad = driver.FindElement(By.ClassName("hArJGc"));
                setupRoad.Click();
                DemoHelper.Pause();
                IWebElement setToWalk = driver.FindElement(By.XPath("/html/body/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[4]/button/img"));
                setToWalk.Click();
                DemoHelper.Pause();
                driver.FindElement(By.XPath("/html/body/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[3]/div[1]/div[1]/div[2]/div[1]/div/input")).SendKeys("Chłodna 51");
                DemoHelper.Pause();
                driver.FindElement(By.XPath("/html/body/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[3]/div[1]/div[2]/div[2]/div[1]/div/input")).SendKeys("Plac Defilad 1");
                DemoHelper.Pause();
                IWebElement search = driver.FindElement(By.XPath("/html/body/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[3]/div[1]/div[2]/div[2]/button[1]"));
                search.Click();
                DemoHelper.Pause();

                // First result
                var timeTableOne =
                    driver.FindElements(By.CssSelector("div.Fk3sm.fontHeadlineSmall"));
                var spliting = ' ';
                var timeOne = timeTableOne[0].Text.Split(spliting);
                var timeOnlyOne = int.Parse(timeOne[0]);

                if (timeOnlyOne <= 40)
                {

                }
                else
                {
                    Assert.True(false);
                }

                var rangeTableOne =
                    driver.FindElements(By.CssSelector("div.ivN21e.tUEI8e.fontBodyMedium"));
                var rangeOne = rangeTableOne[0].Text.Split(spliting);
                var rangeOnlyOne = decimal.Parse(rangeOne[0]);

                if (rangeOnlyOne <= 30)
                {

                }

                else
                {
                    Assert.True(false);
                }

                //Secound result

                var timeTableTwo =
                   driver.FindElements(By.CssSelector("#section-directions-trip-1 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
                var timeTwo = timeTableTwo[0].Text.Split(spliting);
                var timeOnlyTwo = int.Parse(timeTwo[0]);

                if (timeOnlyTwo <= 40)
                {

                }
                else
                {
                    Assert.True(false);
                }

                var rangeTableTwo =
                    driver.FindElements(By.CssSelector("#section-directions-trip-1 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
                var rangeTwo = rangeTableTwo[0].Text.Split(spliting);
                var rangeOnlyTwo = decimal.Parse(rangeTwo[0]);

                if (rangeOnlyTwo <= 30)
                {

                }

                else
                {
                    Assert.True(false);
                }

                //Third result
                var timeTableThree =
                  driver.FindElements(By.CssSelector("#section-directions-trip-2 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
                var timeThree = timeTableThree[0].Text.Split(spliting);
                var timeOnlyThree = int.Parse(timeThree[0]);

                if (timeOnlyThree <= 40)
                {

                }
                else
                {
                    Assert.True(false);
                }

                var rangeTableThree =
                    driver.FindElements(By.CssSelector("#section-directions-trip-2 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
                var rangeThree = rangeTableThree[0].Text.Split(spliting);
                var rangeOnlyThree = decimal.Parse(rangeThree[0]);

                if (rangeOnlyThree <= 30)
                {

                }

                else
                {
                    Assert.True(false);
                }

            }
        }
        [Fact]
        public void OnBike()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);
                DemoHelper.Pause();
                IWebElement setupRoad = driver.FindElement(By.ClassName("hArJGc"));
                setupRoad.Click();
                DemoHelper.Pause();
                IWebElement setToBike = driver.FindElement(By.XPath("/html/body/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[2]/div/div/div[2]/div[1]/div[1]/button/img"));
                setToBike.Click();
                DemoHelper.Pause();
                driver.FindElement(By.XPath("/html/body/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[3]/div[1]/div[1]/div[2]/div[1]/div/input")).SendKeys("Chłodna 51");
                DemoHelper.Pause();
                driver.FindElement(By.XPath("/html/body/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[3]/div[1]/div[2]/div[2]/div[1]/div/input")).SendKeys("Plac Defilad 1");
                DemoHelper.Pause();
                IWebElement search = driver.FindElement(By.XPath("/html/body/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[3]/div[1]/div[2]/div[2]/button[1]"));
                search.Click();
                DemoHelper.Pause();

                // First result
                var timeTableOne =
                    driver.FindElements(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
                var spliting = ' ';
                var timeOne = timeTableOne[0].Text.Split(spliting);
                var timeOnlyOne = int.Parse(timeOne[0]);

                if (timeOnlyOne <= 15)
                {

                }
                else
                {
                    Assert.True(false);
                }

                var rangeTableOne =
                    driver.FindElements(By.CssSelector("#section-directions-trip-0 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
                var rangeOne = rangeTableOne[0].Text.Split(spliting);
                var rangeOnlyOne = decimal.Parse(rangeOne[0]);

                if (rangeOnlyOne <= 30)
                {

                }

                else
                {
                    Assert.True(false);
                }

                //Secound result

                var timeTableTwo =
                   driver.FindElements(By.CssSelector("#section-directions-trip-1 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.Fk3sm.fontHeadlineSmall"));
                var timeTwo = timeTableTwo[0].Text.Split(spliting);
                var timeOnlyTwo = int.Parse(timeTwo[0]);

                if (timeOnlyTwo <= 15)
                {

                }
                else
                {
                    Assert.True(false);
                }

                var rangeTableTwo =
                    driver.FindElements(By.CssSelector("#section-directions-trip-1 > div.MespJc > div:nth-child(3) > div.XdKEzd > div.ivN21e.tUEI8e.fontBodyMedium"));
                var rangeTwo = rangeTableTwo[0].Text.Split(spliting);
                var rangeOnlyTwo = decimal.Parse(rangeTwo[0]);

                if (rangeOnlyTwo <= 30)
                {

                }

                else
                {
                    Assert.True(false);
                }



            }
        }

    }
}
