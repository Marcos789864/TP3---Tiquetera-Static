public static class Tiquetera
{
    private static Dictionary <int,Cliente> DicCliente = new Dictionary<int, Cliente>();
    private static int UltimoIDEntrada = 0;






   
    public static int DevolverUltimoID()
    {  
        return UltimoIDEntrada;
    }
















    public static int AgregarCliente(Cliente p)
    {    
        UltimoIDEntrada++;
        DicCliente.Add(UltimoIDEntrada,p);
        return UltimoIDEntrada;
    }
















    public static Cliente BuscarCliente(int idEntrada)
    {
        if(DicCliente.ContainsKey(idEntrada) == true)
        {
            Cliente p =  DicCliente[idEntrada];
            Console.WriteLine(p.DNI);
           return p;
        }
        else
        {
            return null;
        }
                       
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


    public static List<string> EstadisticasTiquetera( )
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
            TipoEntrada[p.TipoEntrada-1]++;
            Recaudacion[p.TipoEntrada-1] += p.TotalAbonado;
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

