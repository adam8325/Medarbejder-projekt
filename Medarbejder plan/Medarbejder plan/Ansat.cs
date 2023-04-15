using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    public class Ansat
    {
        public string FirstName;
        public string LastName;

       
        public string MedarbejderID;

        public virtual void MedarbejderLogin()   //Virtual keyword bruges så derived classes kan override denne metode
        {
            Console.WriteLine($"Navn: {FirstName} {LastName} - ID: {MedarbejderID}");
        }

    }
}
