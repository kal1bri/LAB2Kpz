using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesLibrary.Base
{
    public abstract class Route
    {
        public string Duration { get; protected set; }
        public List<string> Stops { get; protected set; }
        public List<string> Equipment { get; protected set; }

        public abstract string GetRouteDetails();
    }
}
