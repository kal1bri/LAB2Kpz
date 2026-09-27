using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoutesLibrary.Base;

namespace RoutesLibrary.Car
{
    public class CarRoute : Route
    {
        public CarRoute()
        {
            Duration = "5 днів (Автомобільний)";
            Stops = new List<string> { "Київ", "Львів", "Карпатський перевал", "Ужгород" };
            Equipment = new List<string> { "Автомобіль", "GPS-навігатор", "Запаска", "Аптечка" };
        }

        public override string GetRouteDetails()
        {
            return $"Тривалість: {Duration}\r\nЗупинки: {string.Join(", ", Stops)}.\r\nСпорядження: {string.Join(", ", Equipment)}.";
        }
    }
}
