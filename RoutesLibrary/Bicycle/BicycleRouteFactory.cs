using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoutesLibrary.Base;

namespace RoutesLibrary.Bicycle
{
    public class BicycleRouteFactory : RouteFactory
    {
        public override Route CreateRoute()
        {
            return new BicycleRoute();
        }
    }
}
