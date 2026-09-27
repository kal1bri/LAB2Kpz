using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoutesLibrary.Base;

namespace RoutesLibrary.Hiking
{
    public class HikingRoute : Route
    {
        public HikingRoute()
        {
            Duration = "3 дні (Піший)";
            Stops = new List<string> { "Стартовий табір", "Водоспад", "Вершина гори" };
            Equipment = new List<string> { "Рюкзак", "Трекінгові палиці", "Намет", "Спальник" };
        }

        public override string GetRouteDetails()
        {
            return $"Тривалість: {Duration}\r\nЗупинки: {string.Join(", ", Stops)}.\r\nСпорядження: {string.Join(", ", Equipment)}.";
        }
    }
}
