using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoutesLibrary.Base;

namespace RoutesLibrary.Water
{
    public class WaterRoute : Route
    {
        public WaterRoute()
        {
            Duration = "2 дні (Водний)";
            Stops = new List<string> { "Головний причал", "Дикий острів", "Рибацьке село" };
            Equipment = new List<string> { "Байдарка", "Рятувальний жилет", "Весла", "Гермомішок" };
        }

        public override string GetRouteDetails()
        {
            return $"Тривалість: {Duration}\r\nЗупинки: {string.Join(", ", Stops)}.\r\nСпорядження: {string.Join(", ", Equipment)}.";
        }
    }
}
