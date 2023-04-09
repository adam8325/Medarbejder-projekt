using System;

namespace Medarbejder_plan
{
    public class Program
    {
               
        static void ListMetoden(List<Ansat> ansats)
        {

            ansats.Add(new FuldtidsAnsat() { FirstName = "Mini", LastName = "Jens", MedarbejderID = "001" });
            ansats.Add(new DeltidsAnsat() { FirstName = "Adam", LastName = "Eriksen", MedarbejderID = "002" });
            ansats.Add(new LøstAnsat() { FirstName = "Mogens", LastName = "Mortensen", MedarbejderID = "003" });
            //ansats.Add(new LøstAnsat("Basem", "Abu", "004"));                     

        }
        
        static Ansat TilføjMedarbejder()
        {
            Console.WriteLine("Indtast fornavn: ");
            var name = Console.ReadLine();
            Console.WriteLine("Indtast efternavn: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Indtast medarbejderID: ");
            var id = Console.ReadLine();

            Console.WriteLine("Indtast ansættelsestype: D: Deltid, F: Fultid, L: Løst ");
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

        static string Menu()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Velkommen til Medarbejder menuen:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Vælg venligst en af følgende valgmuligheder:");
            Console.WriteLine("A: Tilføj ny medarbejder");
            Console.WriteLine("D: Slet medarbejder");
            Console.WriteLine("V: Vis listen af medarbejdere");
            Console.WriteLine("Q: Log ud af programmet");
            var option =  Console.ReadLine();
            
            return option;
        }
        static void Main(string[] args)
        {
            
            List<Ansat> mineAnsatte = new List<Ansat>();

            ListMetoden(mineAnsatte);
            do
            {
                var option = Menu().ToUpper();
 
                if (option == "Q")
                    break;
                switch (option)
                {
                    case "A":
                        mineAnsatte.Add(TilføjMedarbejder());
                        break;
                    case "V":
                        foreach (Ansat a in mineAnsatte)
                        {
                            a.MedarbejderLogin();
                        }

                        break;
                    default:
                        break;
                }
            } while (true);



        }
    }
}