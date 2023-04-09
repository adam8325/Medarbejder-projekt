using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    internal class FuldtidsAnsat : Ansat        //Alle subklasser arver fra base klassen Ansat
    {
        
        public override void MedarbejderLogin()
        {
            Console.WriteLine($"Navn: {FirstName} {LastName} - ID: {MedarbejderID} - Type: Fuldtidsansat");
        }
    }
}
