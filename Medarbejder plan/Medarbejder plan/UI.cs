using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    public class UI
    {

        public Ansat LæsMedarbejder()
        {
            Console.WriteLine("Indtast fornavn: ");
            var name = Console.ReadLine();
            Console.WriteLine("Indtast efternavn: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Indtast medarbejderID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Indtast ansættelsestype: D: Deltid, F: Fultid, L: Løstansat");
            var type = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Ansat ans = new Ansat();
            switch (type)                                                                                                    
            {
                case "D": ans = new DeltidsAnsat() { FirstName = name, LastName = lastName, MedarbejderID = id }; break;    
                case "F": ans = new FuldtidsAnsat() { FirstName = name, LastName = lastName, MedarbejderID = id }; break;
                case "L": ans = new LøstAnsat() { FirstName = name, LastName = lastName, MedarbejderID = id }; break;
                default:
                    break;
            }
            return ans;
        }
        public void Menu()
        {
            Repository repo = new Repository();
            do
            {

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Velkommen til Medarbejder oversigten!");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Vælg venligst en af følgende valgmuligheder\n");
                Console.WriteLine("1. Vis oversigt af medarbejdere");
                Console.WriteLine("2. Opret ny medarbejder");
                Console.WriteLine("3. Rediger medarbejders oplysninger");
                Console.WriteLine("4. Find medarbejder");
                Console.WriteLine("5. Opsig medarbejder");
                Console.WriteLine("6. Log ud af programmet\n");
                Console.Write("Indtast valg: ");                

                bool parse = int.TryParse(Console.ReadLine(), out int option);   
                //Try catch implementeret, så programmet ikke crasher ved exception                

                if (parse)
                {
                    Console.WriteLine(option);

                    switch (option)
                    {
                        case 1:                         
                            Console.WriteLine("|Medarbejder oversigt|\n");
                            foreach (Ansat ansat in repo.Employees)
                            {
                                ansat.MedarbejderLogin();                                
                            }Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("|Opret medarbejder|\n");
                            var ans = LæsMedarbejder();
                            repo.OpretMedarbejder(ans);
                            Console.WriteLine("Medarbejder blev oprettet\n");
                            break;
                        case 3:
                            var ans1 = LæsMedarbejder();
                            var x = repo.RedigerMedarbejder(ans1);
                            if(x == -1)
                                Console.WriteLine("Medarbejderen kunne ikke findes\n");
                            else
                                Console.WriteLine("Medarbejder oplsyninger blev opdateret\n");
                            break;
                        case 4:
                            //repo./*FindMedarbejder();*/
                            break;
                        case 5:
                            Console.WriteLine("|Opsig medarbejder|\n");
                            var fjern = LæsMedarbejder();
                            repo.OpsigMedarbejder(fjern);
                            Console.WriteLine("Medarbejder blev opsagt\n");
                            break;
                        default:
                            break;

                    }
                    Console.WriteLine("Tast <Enter> hvis du vil tilbage til oversigten");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Du indtastede et ugyldigt valg");
                }               
  

            } while (true);
            
        }



    }
}
