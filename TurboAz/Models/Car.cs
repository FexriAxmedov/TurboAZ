using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MarkaID { get; set; }
        public int ModelID { get; set; }
        public string FuelType { get; set; }
        public double Mileage { get; set; }
        public int HorsePower { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Color { get; set; }
        public string Transmitter { get; set; }
        public string Engine { get; set; }
        public bool NewOrNotnew { get; set; }
        public string Price { get; set; }


    }
}
