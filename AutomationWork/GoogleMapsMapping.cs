using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWork
{
    internal static class GoogleMapsMapping
    {
        public static string directionsButton = "//button[@id=\"hArJGc\"]";
        public static string walkButton = "//img[@aria-label=\"Pieszo\"]";
        public static string startDirectionInput = "//input[@aria-controls=\"sbsg51\"]";
        public static string endDirectionInput = "//input[@aria-controls=\"sbsg52\"]";
        public static string firstRouteInfo = "(//div[@class=\"XdKEzd\"])[1]//div";
        public static string bike = "//img[@aria-label=\"Na rowerze\"]";
        public static string cookiesAccept = "//button[@aria-label=\"Zaakceptuj wszystko\"]";
    }
}
