namespace ovning_objekt
{

    //interfaceses
    public class Cykel:Fordon,IKörbar
    {
         public Cykel(string märke):base(märke)
       {
        
       }

         public void Kör()
        {
            Console.WriteLine
            ($"Fordon {märke} trampar");
        }
    }
}