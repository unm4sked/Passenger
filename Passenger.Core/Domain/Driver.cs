using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class Driver
    {
        public Guid UserId { get; protected set; }
        public Vehicle vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }

        protected Driver()
        {}

        public Driver(Guid userid)
        {
            UserId = userid;
        }
    }
}