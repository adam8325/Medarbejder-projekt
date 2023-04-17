using System;

namespace Medarbejder_plan
{
    public class Program
    {                
        
        static void Main(string[] args)
        {
            UI oversigt = new UI();       //Den nye Controller klasse bliver instantieret, så Main nu refererer til dens objekter

            oversigt.Menu();




































            //List<Ansat> mineAnsatte = new List<Ansat>();

            //controller.MedarbejderOversigt(mineAnsatte);

            //while (true)
            //{
            //    var option = controller.Menu();

            //    if (option == 6)
            //        break;
            //    switch (option)
            //    {
            //        case 2:
            //            mineAnsatte.Add(controller.OpretMedarbejder());
            //            break;
            //        case 1:
            //            foreach (Ansat a in mineAnsatte)
            //            {
            //                a.MedarbejderLogin();
            //            }

            //            break;
            //        default:
            //            break;
            //    }
            //    Console.WriteLine("\n");
            //    Console.WriteLine("Tast <Enter> hvis du vil tilbage til oversigten");

            //    /*string answer = */Console.ReadLine();

            //    //if (answer != "ja")
            //    //{
            //    //    break; // exit the loop
            //    //}
            //    Console.Clear();

            //} /*while (true);*/
            



        }
    }
}