using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovadisLeaseCar.Domain.Entities
{
    public class Ride
    {
        public int Id { get; set; }
        public int IdLeaseCar {  get; set; }
        public int IdEmployee { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int BeginMileageKM { get; set; }
        public int EndMileageKM { get; set; }
        public Enum Status { get; set; }
        public string BeginAdres { get; set; }
        public string EndAdres { get; set; }

        // Navigation properties
        public Employee Employee { get; set; }

        public LeaseCar LeaseCar { get; set; }

    } 
}
