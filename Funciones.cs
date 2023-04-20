public static class Funciones
{
    public static string IngresarTexto(string msj)
    {
        string texto = "";
        while (texto == "")
        {
            Console.Write(msj);
            texto = Console.ReadLine();
        }
        return texto;
    }
    public static int IngresarEntero(string msj)
    {
        int entero=-1;
        while (entero == -1)
        {  
            Console.Write(msj);
            int.TryParse(Console.ReadLine(), out entero);
        }
        return entero;
    }








    public static int IngresarEnteroEnRango(string msj, int minimo, int maximo)
    {
        int entero;
        entero = IngresarEntero(msj);
        while (entero < minimo || entero > maximo)
        {
            entero = IngresarEntero("ERROR! " + msj);
        }
        return entero;
    }








    public static DateTime IngresarFecha(string msj)
    {
        DateTime fechaDate;
        string fechaCadena = IngresarTexto(msj);
        while (!DateTime.TryParse(fechaCadena, out fechaDate))
        {
            fechaCadena = IngresarTexto("ERROR! " + msj);
        }
        return fechaDate;
    }








    public  static int numRandom()
    {
        int num;
        Random r = new Random();
        num = r.Next(1,101);
        return num;
    }




    public static Cliente CrearCliente()
    {
        int dni = 0;
       if(Tiquetera.DevolverUltimoID() == 0)
       {
        dni = 0;
       }
       else
       {
         dni = Tiquetera.DevolverUltimoID();
       }
       
        string nombre = IngresarTexto("Ingrese su nombre ");
        string apellido = IngresarTexto("Ingrese su apellido ");
        DateTime FechaInscripcion = IngresarFecha("Ingrese la fecha en la que desea ir ");
        int TipoEntrada = IngresarEnteroEnRango("Ingrese el tipo de entrada: (1) Dia 1 15000, (2) Dia 2 30000, (3) Dia 3 10000, (4) Todos los días 40000 ",1,4);
        int totalAbonado = 0;
        if(TipoEntrada == 1)
        {
            totalAbonado = 15000;
        }
        else if(TipoEntrada == 2)
        {
            totalAbonado = 30000;
        }
        else if(TipoEntrada == 3)
        {
            totalAbonado = 10000;
        }
        else
        {
            totalAbonado = 40000;
        }
       
        dni++;
       
        return new Cliente(dni,nombre,apellido,FechaInscripcion,TipoEntrada,totalAbonado);
    }


}
