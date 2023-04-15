using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    public class Controller
    {
        public void MedarbejderOversigt(List<Ansat> ansats)
        {   

            ansats.Add(new FuldtidsAnsat() { FirstName = "Mini", LastName = "Jens", MedarbejderID = "001" });
            ansats.Add(new DeltidsAnsat() { FirstName = "Adam", LastName = "Eriksen", MedarbejderID = "002" });
            ansats.Add(new LøstAnsat() { FirstName = "Mogens", LastName = "Mortensen", MedarbejderID = "003" });
            //ansats.Add(new LøstAnsat("Basem", "Abu", "004"));   //Brug af constructoren også                  

        }        

        public Ansat OpretMedarbejder()
        {
            Console.WriteLine("Indtast fornavn: ");
            var name = Console.ReadLine();
            Console.WriteLine("Indtast efternavn: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Indtast medarbejderID: ");
            var id = Console.ReadLine();

            Console.WriteLine("Indtast ansættelsestype: D: Deltid, F: Fultid, L: Løstansat ");
            var type = Console.ReadLine().ToUpper();
            switch (type)

            {
                case "D": return new DeltidsAnsat() { FirstName = name, LastName = lastName, MedarbejderID = id };
                case "F": return new FuldtidsAnsat() { FirstName = name, LastName = lastName, MedarbejderID = id };
                case "L": return new LøstAnsat() { FirstName = name, LastName = lastName, MedarbejderID = id };
                default:
                    break;
                   
            }
            return null;            
        }

        //public Ansat RedigerMedarbejder()
        //{

        //}

        //public Ansat FindMedarbejder()
        //{

        //}
        //public Ansat OpsigMedarbejder()
        //{

        //}

        public int Menu()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Velkommen til Medarbejder oversigten!");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Vælg venligst en af følgende valgmuligheder\n");
            Console.WriteLine("1. Vis oversigt af medarbejdere");
            Console.WriteLine("2. Opret ny medarbejder");
            Console.WriteLine("3. Rediger medarbejders oplysninger");
            Console.WriteLine("4. Find medarbejder");
            Console.WriteLine("5. Opsig medarbejder");
            Console.WriteLine("6. Log ud af programmet\n");
            Console.Write("Indtast valg: ");

            bool parse = int.TryParse(Console.ReadLine(), out int option);          //Try catch implementeret, så programmet ikke crasher ved exception

            if (parse)
            {
                Console.WriteLine(option);
            }
            else
            {
                Console.WriteLine("Du indtastede et ugyldigt valg");
            }

            return option;

            
        }
    }
}
