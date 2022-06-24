using System;

namespace TurboAz
{
    class Program
    {
        static void Main(string[] args)
        {
            ProclamationManager proclamationManager = new ProclamationManager();
            string iscontinue="";
            do
            {
                Console.WriteLine("Zehmet olmasa emelyat nomresi secin");
                Console.Write("1- Elan elave etmek/ 2- Elanlara baxmaq/ 3-Elan editlemek / 4- Elan silmek: ");
                string menu = Console.ReadLine();
                if (menu == "1")
                {
                    proclamationManager.AddProclamation();
                }
                else if (menu == "2")
                {
                    proclamationManager.ReadProclamation();
                }
                else if (menu == "3")
                {
                    Console.WriteLine("Deyiwmek istediyiniz elanin id sini daxil edin");
                    int id = Convert.ToInt32(Console.ReadLine());
                    proclamationManager.EditProclomation(id);
                }
                else if(menu == "4")
                {
                    Console.WriteLine("Silmek istediyiniz elanin id sini daxil edin");
                    int id = Convert.ToInt32(Console.ReadLine());
                    proclamationManager.DeleteProclomation(id);
                }
                else
                {
        }
    }
}
