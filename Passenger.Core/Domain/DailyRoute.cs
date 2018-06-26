using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class DailyRoute
    {
        public Guid Id { get; protected set; }
        public Route Route {get; protected set;}
        public IEnumerable<Route> Routes {get; protected set;}
        public IEnumerable<DailyRoute> DailyRoutes {get; protected set;}
    }
}