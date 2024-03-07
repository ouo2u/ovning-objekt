namespace ovning_objekt
{
    public abstract class Fordon 
    {
        //inkapsling
        protected string märke;

         //nu tar vi den men vi kan inte ändra den.
         //inkapsling
        public string Märke{
            get{ return märke;}
            set{märke=value;}

        }

        //konstrokuter har två uppgifter, första sätta värde och andra är skapa objektet.
       public Fordon(string märke)
       {
        this.märke=märke;
       }
       //polofylism
       //public abstract void Kör();
       
    }
}