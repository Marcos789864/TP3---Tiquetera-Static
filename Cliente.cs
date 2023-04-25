public class Cliente
{
   public int DNI {get;private set;}
   public string Apellido {get;private set;}
   public string Nombre {get;private set;}
   public DateTime FechaInscripcion{get;set;}        
   public int TipoEntrada{get;set;}
   public int TotalAbonado{get;set;}
















   public  Cliente()
   {
















   }



//hola












   public  Cliente( int dni,string ape, string nom, DateTime fi,int typeE, int typeA)
   {
    DNI = dni;
    Apellido = ape;
    Nombre = nom;
    FechaInscripcion = fi;
    TipoEntrada = typeE;
    TotalAbonado = typeA;
   }
}

