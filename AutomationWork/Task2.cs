using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;


namespace AutomationWork
{
    [Trait("Category", "Applications")]
    public class Task2

    {
        private const string HomeUrl = "https://www.google.pl/maps/";
        private const string PDAddress = "Placu Defilad 1";
        private const string ChlodnaAddress = "Chłodna 51";
        private const int TimeLimitWalk = 40;
        private const int TimeLimitBike = 15;
        private const float DistanceLimit = 3;
        private static readonly Dictionary<string, string> TransportMode = new Dictionary<string, string>()
        {
            { "walk", GoogleMapsMapping.walkButton },
            { "bike", GoogleMapsMapping.bike },
        };


        [Theory]
        [InlineData(PDAddress, ChlodnaAddress, "walk", TimeLimitWalk)]
        [InlineData(ChlodnaAddress, PDAddress, "walk", TimeLimitWalk)]
        [InlineData(PDAddress, ChlodnaAddress, "bike", TimeLimitBike)]
        [InlineData(ChlodnaAddress, PDAddress, "bike", TimeLimitBike)]
        public void GoogleMapsJouney(string address1, string address2, string transportType, int TimeLimit)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(HomeUrl);
                driver.Click(GoogleMapsMapping.cookiesAccept);
                driver.Click(GoogleMapsMapping.directionsButton);
                driver.Wait(GoogleMapsMapping.walkButton);
                driver.Click(TransportMode[transportType]);
                driver.SendKeys (GoogleMapsMapping.startDirectionInput, address2);
                driver.SendKeys(GoogleMapsMapping.endDirectionInput, address1 + "\n");
                driver.Wait(GoogleMapsMapping.firstRouteInfo);
                
                var firstRouteInfo = driver.FindElements(By.XPath(GoogleMapsMapping.firstRouteInfo));
                var splitter = ' ';
                var time = firstRouteInfo[0].Text.Split(splitter);
                var isTimeSmallerThan40 = int.Parse(time[0]) <= TimeLimit;
                var distance = firstRouteInfo[1].Text.Split(splitter);
                var isDistanceSmallerThan3 = float.Parse(distance[0]) <= DistanceLimit;

                if (isTimeSmallerThan40 && isDistanceSmallerThan3)
                {
                    Console.WriteLine($"Your road is shorter than {TimeLimit}mins and will not take more than {DistanceLimit}km");
                }
                else if (isTimeSmallerThan40 && !isDistanceSmallerThan3)
                {
                    Console.WriteLine($"Your road is shorter than {TimeLimit}mins and the will take more than {DistanceLimit}km");
                }
                else if (!isTimeSmallerThan40 && isDistanceSmallerThan3)
                {
                    Console.WriteLine($"Your road is longer than {TimeLimit}mins and the will not take more than {DistanceLimit}km");
                }
                else if (!isTimeSmallerThan40 && !isDistanceSmallerThan3)
                {
                    Console.WriteLine($"Your road is longer than {TimeLimit}mins and it will take more than {DistanceLimit}km");
                }
            }
        }

    }
}
