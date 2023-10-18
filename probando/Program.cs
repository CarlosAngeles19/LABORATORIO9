using System;
using System.Linq;

class Producto
{
    public int Vendidos { get; set; }
    public int Devueltos { get; set; }
    public int Inventario { get; set; }
    public double Caja { get; set; }
}

class Program
{
    static Producto[] productos = new Producto[4];

    static void Main(string[] args)
    {
        // Inicializa los productos
        for (int i = 0; i < productos.Length; i++)
        {
            productos[i] = new Producto();
        }

        int opcion = 0;

        do
        {
            opcion = mainscreen();

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Registro();
                    break;

                case 2:
                    Console.Clear();
                    Devolucion();
                    break;

                case 3:
                    MostrarTotales();
                    Console.ReadKey();
                    break;



                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        } while (opcion != 4);
    }

    static int mainscreen()
    {
        string texto = "================================\n" +
            "Tienda de Don Lucas\n" +
            "================================\n" +
            "1: Registrar venta\n" +
            "2: Registrar devolución\n" +
            "3: Cerrar Caja\n" +
            "================================\n" +
            "Ingrese una opción:\n\r";
        Console.Write(texto);

        string opciontxt = Console.ReadLine();
        int opcion = int.Parse(opciontxt);

        Console.Clear();
        return opcion;
    }

    static void Registro()
    {
        Console.Clear();
        int opcion = 0;


        Console.WriteLine("================================");
        Console.WriteLine("Registrar Venta de:");
        Console.WriteLine("================================");
        Console.WriteLine("1: Limpieza");
        Console.WriteLine("2: Abarrotes");
        Console.WriteLine("3: Golosinas");
        Console.WriteLine("4: Electrónicos");
        Console.WriteLine("5: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        opcion = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (opcion)
        {
            case 1:
                Ejercicio4_1_1();
                break;
            case 2:
                Ejercicio4_1_2();
                break;
            case 3:
                Ejercicio4_1_3();
                break;
            case 4:
                Ejercicio4_1_4();
                break;
            case 5:
                mainscreen();
                break;
        }

    }

    static void Devolucion()
    {
        Console.Clear();
        int opcion = 0;

        Console.WriteLine("================================");
        Console.WriteLine("Registrar devolución de:");
        Console.WriteLine("================================");
        Console.WriteLine("1: Limpieza");
        Console.WriteLine("2: Abarrotes");
        Console.WriteLine("3: Golosinas");
        Console.WriteLine("4: Electrónicos");
        Console.WriteLine("5: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        opcion = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (opcion)
        {
            case 1:
                Ejercicio4_2_1();
                break;
            case 2:
                Ejercicio4_2_2();
                break;
            case 3:
                Ejercicio4_2_3();
                break;
            case 4:
                Ejercicio4_2_4();
                break;
            case 5:
                mainscreen();
                break;

        }

    }

    static void Ejercicio4_1_1()
    {
        Console.WriteLine("================================");
        Console.WriteLine("REGISTRAR VENTA DE LIMPIEZA:");
        Console.WriteLine("================================");
        Console.Write("Ingrese cantidad (unidades): ");
        int unidades = int.Parse(Console.ReadLine());
        Console.Write("Ingrese precio: S/ ");
        float precio = float.Parse(Console.ReadLine());
        float total = unidades * precio;
        Console.WriteLine("================================");

        Console.WriteLine($"Se han ingresado {unidades} unidades");
        Console.WriteLine($"Se han ingresado S/ {total.ToString("0.00")} en caja");

        // Actualizar estadísticas del producto
        productos[0].Vendidos += unidades;
        productos[0].Caja += total;

        Console.WriteLine("1: Registrar más productos de limpieza");
        Console.WriteLine("2: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio4_1_1();
                break;
            case 2:
                Registro();
                break;
        }
    }

    static void Ejercicio4_1_2()
    {
        Console.WriteLine("================================");
        Console.WriteLine("REGISTRAR VENTA DE ABARROTES:");
        Console.WriteLine("================================");
        Console.Write("Ingrese cantidad (unidades): ");
        int unidades = int.Parse(Console.ReadLine());
        Console.Write("Ingrese precio: S/ ");
        float precio = float.Parse(Console.ReadLine());
        float total = unidades * precio;
        Console.WriteLine("================================");
        Console.WriteLine($"Se han ingresado {unidades} unidades");
        Console.WriteLine($"Se han ingresado S/ {total.ToString("0.00")} en caja");
        Console.WriteLine("================================");

        // Actualizar estadísticas del producto
        productos[1].Vendidos += unidades;
        productos[1].Caja += total;

        Console.WriteLine("1: Registrar más productos de ABARROTES");
        Console.WriteLine("2: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio4_1_2();
                break;
            case 2:
                Registro();
                break;
        }
    }

    static void Ejercicio4_1_3()
    {
        Console.WriteLine("================================");
        Console.WriteLine("REGISTRAR VENTA DE GOLOSINAS:");
        Console.WriteLine("================================");
        Console.Write("Ingrese cantidad (unidades): ");
        int unidades = int.Parse(Console.ReadLine());
        Console.Write("Ingrese precio: S/ ");
        float precio = float.Parse(Console.ReadLine());
        float total = unidades * precio;
        Console.WriteLine("================================");
        Console.WriteLine($"Se han ingresado {unidades} unidades");
        Console.WriteLine($"Se han ingresado S/ {total.ToString("0.00")} en caja");
        Console.WriteLine("================================");

        // Actualizar estadísticas del producto
        productos[2].Vendidos += unidades;
        productos[2].Caja += total;

        Console.WriteLine("1: Registrar más productos de GOLOSINAS");
        Console.WriteLine("2: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (opcion)
        {
            case 1:
                Ejercicio4_1_3();
                break;
            case 2:
                Registro();
                break;
        }
    }

    static void Ejercicio4_1_4()
    {
        Console.WriteLine("================================");
        Console.WriteLine("REGISTRAR VENTA DE ELECTRÓNICOS:");
        Console.WriteLine("================================");
        Console.Write("Ingrese cantidad (unidades): ");
        int unidades = int.Parse(Console.ReadLine());
        Console.Write("Ingrese precio: S/ ");
        float precio = float.Parse(Console.ReadLine());
        float total = unidades * precio;
        Console.WriteLine("================================");
        Console.WriteLine($"Se han ingresado {unidades} unidades");
        Console.WriteLine($"Se han ingresado S/ {total.ToString("0.00")} en caja");
        Console.WriteLine("================================");

        // Actualizar estadísticas del producto
        productos[3].Vendidos += unidades;
        productos[3].Caja += total;

        Console.WriteLine("1: Registrar más productos de ELECTRÓNICOS");
        Console.WriteLine("2: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (opcion)
        {
            case 1:
                Ejercicio4_1_4();
                break;
            case 2:
                Registro();
                break;
        }
    }

    static void Ejercicio4_2_1()
    {
        Console.WriteLine("================================");
        Console.WriteLine("REGISTRAR DEVOLUCIÓN DE LIMPIEZA:");
        Console.WriteLine("================================");
        Console.Write("Ingrese cantidad (unidades): ");
        int unidades = int.Parse(Console.ReadLine());
        Console.WriteLine("================================");

        if (unidades > 0 && unidades <= productos[0].Vendidos)
        {
            double precioUnitario = productos[0].Caja / productos[0].Vendidos;
            double totalDevolucion = unidades * precioUnitario;

            Console.WriteLine($"Se han devuelto {unidades} unidades de Limpieza");
            Console.WriteLine($"Se han descontado S/ {totalDevolucion.ToString("0.00")} en caja");
            Console.WriteLine("================================");

            productos[0].Vendidos = productos[0].Vendidos + productos[0].Devueltos;
            productos[0].Devueltos += unidades;
            productos[0].Inventario = productos[0].Vendidos - productos[0].Devueltos;
            productos[0].Caja -= totalDevolucion;

            Console.WriteLine("1: Registrar más devoluciones de Limpieza");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Ejercicio4_2_1();
                    break;
                case 2:
                    Devolucion();
                    break;
            }
        }
        else
        {
            Console.WriteLine("La cantidad ingresada no es válida o excede la cantidad vendida.");
            Console.WriteLine("1: Volver a intentar");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Ejercicio4_2_1();
                    break;
                case 2:
                    Devolucion();
                    break;
            }
        }
    }

    static void Ejercicio4_2_2()
    {
        Console.WriteLine("================================");
        Console.WriteLine("REGISTRAR DEVOLUCIÓN DE ABARROTES:");
        Console.WriteLine("================================");
        Console.Write("Ingrese cantidad (unidades): ");
        int unidades = int.Parse(Console.ReadLine());
        Console.WriteLine("================================");

        if (unidades > 0 && unidades <= productos[1].Vendidos)
        {
            double precioUnitario = productos[1].Caja / productos[1].Vendidos;
            double totalDevolucion = unidades * precioUnitario;

            Console.WriteLine($"Se han devuelto {unidades} unidades de Abarrotes");
            Console.WriteLine($"Se han descontado S/ {totalDevolucion.ToString("0.00")} en caja");
            Console.WriteLine("================================");
            // Actualizar estadísticas del producto y la caja
            productos[1].Vendidos = productos[1].Vendidos + productos[1].Devueltos;
            productos[1].Devueltos += unidades;
            productos[1].Inventario = productos[1].Vendidos - productos[1].Devueltos;
            productos[1].Caja -= totalDevolucion;
        }
        else
        {
            Console.WriteLine("La cantidad ingresada no es válida o excede la cantidad vendida.");
        }

        Console.WriteLine("1: Registrar más devoluciones de Abarrotes");
        Console.WriteLine("2: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio4_2_2();
                break;
            case 2:
                Devolucion();
                break;
        }
    }

    static void Ejercicio4_2_3()
    {
        Console.WriteLine("================================");
        Console.WriteLine("REGISTRAR DEVOLUCIÓN DE GOLOSINAS:");
        Console.WriteLine("================================");
        Console.Write("Ingrese cantidad (unidades): ");
        int unidades = int.Parse(Console.ReadLine());
        Console.WriteLine("================================");

        if (unidades > 0 && unidades <= productos[2].Vendidos)
        {
            double precioUnitario = productos[2].Caja / productos[2].Vendidos;
            double totalDevolucion = unidades * precioUnitario;

            Console.WriteLine($"Se han devuelto {unidades} unidades de Golosinas");
            Console.WriteLine($"Se han descontado S/ {totalDevolucion.ToString("0.00")} en caja");
            Console.WriteLine("================================");
            // Actualizar estadísticas del producto y la caja
            productos[2].Vendidos = productos[2].Vendidos + productos[2].Devueltos;
            productos[2].Devueltos += unidades;
            productos[2].Inventario = productos[2].Vendidos - productos[2].Devueltos;
            productos[2].Caja -= totalDevolucion;
        }
        else
        {
            Console.WriteLine("La cantidad ingresada no es válida o excede la cantidad vendida.");
        }

        Console.WriteLine("1: Registrar más devoluciones de Golosinas");
        Console.WriteLine("2: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio4_2_3();
                break;
            case 2:
                Devolucion();
                break;
        }
    }

    static void Ejercicio4_2_4()
    {
        Console.WriteLine("================================");
        Console.WriteLine("REGISTRAR DEVOLUCIÓN DE ELECTRÓNICOS:");
        Console.WriteLine("================================");
        Console.Write("Ingrese cantidad (unidades): ");
        int unidades = int.Parse(Console.ReadLine());
        Console.WriteLine("================================");

        if (unidades > 0 && unidades <= productos[3].Vendidos)
        {
            double precioUnitario = productos[3].Caja / productos[3].Vendidos;
            double totalDevolucion = unidades * precioUnitario;

            Console.WriteLine($"Se han devuelto {unidades} unidades de Electrónicos");
            Console.WriteLine($"Se han descontado S/ {totalDevolucion.ToString("0.00")} en caja");
            Console.WriteLine("================================");
            // Actualizar estadísticas del producto y la caja
            productos[3].Vendidos = productos[3].Vendidos + productos[3].Devueltos;
            productos[3].Devueltos += unidades;
            productos[3].Inventario = productos[3].Vendidos - productos[3].Devueltos;
            productos[3].Caja -= totalDevolucion;
        }
        else
        {
            Console.WriteLine("La cantidad ingresada no es válida o excede la cantidad vendida.");
        }

        Console.WriteLine("1: Registrar más devoluciones de Electrónicos");
        Console.WriteLine("2: <- Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio4_2_4();
                break;
            case 2:
                Devolucion();
                break;
        }
    }

    static void MostrarTotales()
    {
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Tienda de Don Lucas");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Totales");
        Console.WriteLine("-----------------------------------------------------");

        for (int i = 0; i < productos.Length; i++)
        {
            string nombreProducto = "";
            switch (i)
            {
                case 0:
                    nombreProducto = "Limpieza";
                    break;
                case 1:
                    nombreProducto = "Abarrotes";
                    break;
                case 2:
                    nombreProducto = "Golosinas";
                    break;
                case 3:
                    nombreProducto = "Electrónicos";
                    break;
            }

            Console.WriteLine($"                        | {"Vendidos: " + productos[i].Vendidos,-20}");
            Console.WriteLine($"{nombreProducto,-20}    | {"Devueltos: " + productos[i].Devueltos,-20}");
            Console.WriteLine($"                        | {"Inventario: " + productos[i].Inventario,-20}");
            Console.WriteLine($"                        | {"S/ " + productos[i].Caja.ToString("0.00"),-20}");
            Console.WriteLine("-----------------------------------------------------");
        }

        double cajaGeneral = productos.Sum(p => p.Caja);

        Console.WriteLine($"{"| Queda en caja",-20} | {"S/ " + cajaGeneral.ToString("0.00"),-20}");
        Console.WriteLine("-----------------------------------------------------");
    }
}
