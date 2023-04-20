public static class Tiquetera
{
    private static Dictionary <int,Cliente> DicCliente = new Dictionary<int, Cliente>();
    private static int UltimoIDEntrada;


   
    public static int DevolverUltimoID()
    {  
        int ultimoID = 0;
        foreach(int clave in DicCliente.Keys)
        {
            ultimoID = clave;
        }
        return ultimoID;
    }




    public static int AgregarCliente(Cliente p)
    {    
        DicCliente.Add(p.DNI,p);
        int id = p.DNI;
        return p.DNI;
    }




    public static Cliente BuscarCliente(int idEntrada)
    {
            Cliente p =  DicCliente[idEntrada];
           return p;              
    }




    public static bool CambiarEntrada (int id,int typeE,int total)
    {
        if(DicCliente.ContainsKey(id) == true)
        {
            Cliente p = DicCliente[id];
            int TotalAnterior = p.TotalAbonado;
            if(TotalAnterior < total)
            {
                p.TotalAbonado = total;
                p.TipoEntrada = typeE;
                p.FechaInscripcion = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
           
        }
        else
        {
            Console.WriteLine("El numero de cliente ingresado no existe");
            Console.ReadLine();
            return false;
        }
   
    }


    public static List<string> EstadisticasTiquetera()
    {
            List<string> Lista = new List <string>();
            int[] TipoEntrada = {0,0,0,0};
            int[] Recaudacion = {0,0,0,0};
            int[] Porcentaje = {0,0,0,0};
            string cambio = "";
            string cambio2 = "";
            string cambio3 = "";
            string cambio4 = "";
            int recaudacionTotal = 0;
            int cantidadInscriptos = DicCliente.Count;


            foreach(Cliente p in DicCliente.Values)
            {
                if(p.TipoEntrada == 1)
                {
                    TipoEntrada[0]++;
                    Recaudacion[0] += 15000;
                }
                else if(p.TipoEntrada == 2)
                {
                    TipoEntrada[1]++;
                    Recaudacion[1] += 30000;
                }
                if(p.TipoEntrada == 3)
                {
                    TipoEntrada[2]++;
                    Recaudacion[2] += 10000;
                }
                if(p.TipoEntrada == 4)
                {
                    TipoEntrada[3]++;
                    Recaudacion[3] += 40000;
                }
            }
       
            for(int i = 0; i < TipoEntrada.Length;i++)
            {
                recaudacionTotal += Recaudacion[i];
                Porcentaje[i] = (TipoEntrada[i] * 100)/DicCliente.Count;
                cambio = Recaudacion[i].ToString();
                cambio2 = Porcentaje[i].ToString();
                Lista.Add(cambio);
                Lista.Add(cambio2);  
            }
                cambio3 = recaudacionTotal.ToString();
                Lista.Add(cambio3);
                cambio4 = DicCliente.Count.ToString();
                Lista.Add(cambio4);
        return Lista;


    }
}
