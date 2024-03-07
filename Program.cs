using ovning_objekt;

//Nu skapar vi objektet, new betyder att man skapar ett nytt objekt. Om man vill skapa en class som har bara GET men inte set så kan man inte ändra
//om man skriver SET utan GET så kan man inte skriva det I console WriteLine
//Fordon fordon= new Fordon("Nintendo");

/*Nu blir det polofyism.
List<Fordon> fordonsLista= new();
/*

/*
List<körbar> körbarlista
Bil f1=new Bil("Nintendo", "PlaystationX");
Fordon f2= new Cykel("speedtree");
körbarLista.Add(f1);
KörbarLista.Add(f2);
spel doom= new doom();
KörbarLista.Add(doom);
 */  
List<IKörbar> körbarLista=new();

IKörbar f1=new Bil("Nintendo", "PlaystationX");
Cykel f2= new Cykel("speedtree");
Spel doom=new Doom();
körbarLista.Add(doom);
körbarLista.Add(f1);
körbarLista.Add(f2);

foreach( var körbar in körbarLista){
    körbar.Kör();
}
 

   
