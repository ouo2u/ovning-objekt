namespace ovning_objekt
{
    public class Bil : Fordon, IKörbar
    {
        private string modell;

        public string Modell{
            get{ return modell; }
            set{ modell=value;}
        }
        public Bil(string märke, string modell): base(märke)
        {
            this.modell=modell;
            this.märke=märke;
        }

        //polofylism och man arver märke från fordon 
        public void Kör()
        {
            Console.WriteLine
            ($"Fordon {märke} kör som en {modell}");
        }
    }
}