using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    internal class LøstAnsat : Ansat
    {
       
        //public LøstAnsat(string name, string lastname, string id)         //Man kunne også kode den således som constructor
        //{
        //    FirstName= name;
        //    LastName= lastname;
        //    MedarbejderID = id;
        //}
        public override void MedarbejderLogin()      //Metoden overrides så den kan bruges af subklasserne      
        {
            
            Console.WriteLine($"Navn: {FirstName} {LastName} - ID: {MedarbejderID} - Type: Løstansat");
        }
    }
}
