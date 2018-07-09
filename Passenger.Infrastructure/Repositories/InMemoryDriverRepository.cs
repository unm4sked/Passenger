using System;
using System.Collections.Generic;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using System.Linq;

namespace Passenger.Infrastructure.Repositories
{
    public class InMemoryDriverRepository : IDriverRepository
    {
        public static ISet<Driver> _drivers = new HashSet<Driver>();
        public Driver Get(Guid userId)
        {
            return _drivers.SingleOrDefault(x => x.UserId == userId);
        }
        public IEnumerable<Driver> GetAll()
        {
            return _drivers;
        }
        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }
        public void Update(Driver driver)
        {

        }
    }
}