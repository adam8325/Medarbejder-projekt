using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    internal class DeltidsAnsat : Ansat
    {       
        public override void MedarbejderLogin()
        {
            Console.WriteLine($"Navn: {FirstName} {LastName} - ID: {MedarbejderID} - Type: Deltidsansat");
        }
    }
}
