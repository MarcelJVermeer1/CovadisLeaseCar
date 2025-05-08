using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovadisLeaseCar.Domain.Entities
{
    public class LeaseCar
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string LiecencePlate { get; set; }
        public double KmCount { get; set; }
        public Enum FeulType { get; set; }

        public List<Ride> Rides { get; set; }

    }
}
