using System.Collections.Generic;


    int eleccion = 0;
    eleccion = Funciones.IngresarEnteroEnRango("Ingrese la opcion que desea ejecutar; (1) Nueva inscripcion, (2) Obtner Estadisticas del evento, (3) Buscar cliente, (4) Cambiar entrada cliente, (5) Salir",1,5);
    while(eleccion != 5)
    {switch(eleccion)
        {
        case 1:
            Cliente p = Funciones.CrearCliente();
            Tiquetera.AgregarCliente(p);  
        break;
        case 2:
            List<string> list = Tiquetera.EstadisticasTiquetera();
            Console.WriteLine("Cantidad de clientes inscriptos " + list[9]);
            Console.WriteLine("Porcentaje de ventas: A: " + list[1]+ "% , B: " + list[3] + "% , C: " + list[5] + "% , D: " + list[7] + "%");
            Console.WriteLine("Recaudacion de ventas: A: " + list[0] + ", B: " + list[2] + ", C: " + list[4] + ", D: " + list[6]  );
            Console.WriteLine("Recaudacion total: $" + list[8]);
        break;
        case 3:
            int ingresarID = Funciones.IngresarEntero("Ingrese el id de una persona y le mostraremos su informacion");
            Cliente G = Tiquetera.BuscarCliente(ingresarID);
            Console.WriteLine("Cliente: Nombre: " + G.Nombre + " Apellido: " + G.Apellido + " DNI: " + G.DNI + " FechaInscripcion" + G.FechaInscripcion + " TipoEntrada: " + G.TipoEntrada + " TotalAbonado: " + G.TotalAbonado);
        break;
        case 4:
            ingresarID = Funciones.IngresarEntero("Ingrese el id de una persona y podra modificar la entrada del cliente");
            int tipoEntrada = Funciones.IngresarEnteroEnRango("Ingrese el tipo de entrada: (1) Dia 1 15000, (2) Dia 2 30000, (3) Dia 3 10000, (4) Todos los días 40000",1,4);
            int totalAbonado;
            if(tipoEntrada == 1)
            {
                totalAbonado = 15000;
            }
            else if(tipoEntrada == 2)
            {
                totalAbonado = 30000;
            }
            else if(tipoEntrada == 3)
            {
                totalAbonado = 10000;
            }
            else
            {
                totalAbonado = 40000;
            }    
            if (Tiquetera.CambiarEntrada(ingresarID,tipoEntrada,totalAbonado) == true)
            {
                Console.WriteLine("Se ha cambiado su entrada");
            }
            else
            {
                Console.WriteLine(" No se ha podido cambiado su entrada");
            }
            break;
        }
        eleccion = Funciones.IngresarEnteroEnRango("Ingrese la opcion que desea ejecutar; (1) Nueva inscripcion, (2) Obtner Estadisticas del evento, (3) Buscar cliente, (4) Cambiar entrada cliente, (5) Salir",1,5);
    }

