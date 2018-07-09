using System;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;
using System.Linq;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        public readonly IDriverRepository _driverRepository;

        public DriverDto Get(Guid userId)
        {
            var driver = _driverRepository.Get(userId);
            return new DriverDto
            {
                Id=driver.UserId
                
            };
        }
    }
}