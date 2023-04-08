using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    internal class DeltidsAnsat : Ansat
    {
        public string FirstName = "Mini";
        public string LastName = "Jens";
        public string MedarbejderID = "Mini7823";
        public override void MedarbejderLogin()
        {
            Console.WriteLine($"Navn: {FirstName} {LastName} - ID: {MedarbejderID} - Type: Deltidsansat");
        }
    }
}
