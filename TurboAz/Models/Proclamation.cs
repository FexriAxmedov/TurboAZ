using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Models
{
   public class Proclamation
    {
        static int id = 2;
        public Proclamation()
        {
            this.Id = id;
            id++;
           
        }
       



        public int Id { get; set; }

        public int ProclamationNumber { get; set; }
        public int ProclamationViews { get; set; }
        public DateTime LastEditedTime { get; set; }
        public string ProclamationType { get; set; }
        public string SellerNumber { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return "Proclamation: " + Id + " " + ProclamationNumber + ProclamationViews + " " + LastEditedTime + " " + ProclamationType + SellerNumber + " " + Description;
        }

    }
}
