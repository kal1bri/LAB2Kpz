using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoutesLibrary.Base;

namespace RoutesLibrary.Water
{
    public class WaterRouteFactory : RouteFactory
    {
        public override Route CreateRoute()
        {
            return new WaterRoute();
        }
    }
}
