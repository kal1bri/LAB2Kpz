using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoutesLibrary.Base;

namespace RoutesLibrary.Bicycle
{
    public class BicycleRoute : Route
    {
        public BicycleRoute()
        {
            Duration = "1 день (Велосипедний)";
            Stops = new List<string> { "Міський парк", "Лісове озеро", "Заміська траса" };
            Equipment = new List<string> { "Велосипед", "Шолом", "Ремкомплект", "Вода" };
        }

        public override string GetRouteDetails()
        {
            return $"Тривалість: {Duration}\r\nЗупинки: {string.Join(", ", Stops)}.\r\nСпорядження: {string.Join(", ", Equipment)}.";
        }
    }
}
