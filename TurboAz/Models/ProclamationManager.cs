using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Models;

namespace TurboAz
{
   public class ProclamationManager
    {


        List<Proclamation> proclamations = new List<Proclamation>();
        

     cixdim sagol sende sagol
        public void AddProclamation()
        {
            string iscontinue = "he";

            while (iscontinue == "he")
            {
                Proclamation proclamation1 = new Proclamation();
                Console.Write("Elan nömresini elave edin: ");
                proclamation1.ProclamationNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Elan tipini elave edin: ");
                proclamation1.ProclamationType = Console.ReadLine();
                Console.Write("Satıcı nömresini elave edin: ");
                proclamation1.SellerNumber = Console.ReadLine();
                Console.Write("Tesvir elave edin: ");
                proclamation1.Description = Console.ReadLine();

                proclamations.Add(proclamation1);


                Console.Write("Davam etmek isteyirsiniz? (he/yox): ");
                iscontinue = Console.ReadLine().ToLower();
            }


            ReadProclamation();


        }



        public void ReadProclamation()
        {
            foreach (var item in proclamations)
            {
                item.ProclamationViews++;
            
                Console.WriteLine(item);
                

            }
        }


        public void EditProclomation(int id)
        {
            foreach (var item in proclamations)
            {
                if(item.Id == id)
                {
                    Console.WriteLine($"Cari elan tesviri: {item.Description}");
                    Console.Write("Yeni elan tesvirini daxil edin: ");
                    item.Description = Console.ReadLine();

                    Console.WriteLine(item);
                }
            }
        }


        public void DeleteProclomation(int id)
        {
            for (int i = 0; i < proclamations.Count; i++)
            {
                if (proclamations[i].Id == id)
                {

                    proclamations.Remove(proclamations[i]);
                }
            }
        }
    }
}
