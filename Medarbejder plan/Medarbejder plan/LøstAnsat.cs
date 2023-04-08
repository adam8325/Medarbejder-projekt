using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    internal class LøstAnsat : Ansat
    {
        public string FirstName = "Børge";
        public string LastName = "Olsen";
        public string MedarbejderID = "Børge2469";

        public override void MedarbejderLogin()      //Metoden overrides så den kan bruges af subklasserne      
        {
            Console.WriteLine($"Navn: {FirstName} {LastName} - ID: {MedarbejderID} - Type: Løstansat");
        }
    }
}
