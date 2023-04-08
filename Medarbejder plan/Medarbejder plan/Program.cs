namespace Medarbejder_plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Ansat[] ansat = new Ansat[3];
                        
            ansat[0] = new FuldtidsAnsat();
            ansat[1] = new DeltidsAnsat();
            ansat[2] = new LøstAnsat();

            foreach (Ansat a in ansat)
            {
                a.MedarbejderLogin();
            }



        }
    }
}