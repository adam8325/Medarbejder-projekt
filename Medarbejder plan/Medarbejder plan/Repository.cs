using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejder_plan
{
    public class Repository
    {
        public List<Ansat> Employees = new List<Ansat>();
        public Repository()
        {

            Employees.Add(new FuldtidsAnsat() { FirstName = "Mini", LastName = "Jens", MedarbejderID = "001" });
            Employees.Add(new DeltidsAnsat() { FirstName = "Adam", LastName = "Eriksen", MedarbejderID = "002" });
            Employees.Add(new LøstAnsat() { FirstName = "Mogens", LastName = "Mortensen", MedarbejderID = "003" });
        }


        public void OpretMedarbejder(Ansat ans)
        {
          
            Employees.Add(ans); 

        }

        public int RedigerMedarbejder(Ansat updatedEmp)
        {
            var x = Employees.FirstOrDefault(x => x.MedarbejderID == updatedEmp.MedarbejderID);

            if(x != null)
            {
                //Employees.Remove(x);
                x.FirstName = updatedEmp.FirstName;             //Hvad gør den her kode???
                return 1;
            }
            else
            
                return -1;
                
            //Console.WriteLine("Rediger medarbejder oplsyninger\n");

        }

        public Ansat? FindMedarbejder(string employeeId)
        {
            var x = Employees.FirstOrDefault(x => x.MedarbejderID == employeeId);
           
            return x;

        }
        public int OpsigMedarbejder(Ansat fjernMed)
        {
            var y = Employees.FirstOrDefault(y => y.MedarbejderID == fjernMed.MedarbejderID);

            if (y != null)
            {
                Employees.Remove(y);
                y.FirstName = fjernMed.FirstName;             //Hvad gør den her kode???
                return 1;
            }
            else

                return -1;           
           
        }

        

    }
}
