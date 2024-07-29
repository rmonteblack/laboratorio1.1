using System;

class Program
{
    static void Main(string[] args)
    {
        Bienvenida();
        
        if (VerProductos())
        {
            MostrarProductos();
        }

        decimal totalCompra = 0;
        bool continuarAgregando = true;

        while (continuarAgregando)
        {
            totalCompra += AgregarProducto();
            continuarAgregando = OtroProducto();
        }

        Descuento(ref totalCompra);
        Total(totalCompra);
    }

    static void Bienvenida()
    {
        Console.WriteLine("Bienvenido a la tienda Chorrito de agua");
        Console.WriteLine("Actualmente contamos con 10 productos");
        Console.WriteLine("Desea ver los productos y su precio ? (s/n)");
    }

    static bool VerProductos()
    {
        string respuesta = Console.ReadLine();
        return respuesta.ToLower() == "s";
    }

    static void MostrarProductos()
    {
        Console.WriteLine("Fresa Q10.00");
        Console.WriteLine("Banano Q4.00");
        Console.WriteLine("Melon Q8.00");
        Console.WriteLine("Piña Q10.00");
        Console.WriteLine("Sandía Q7.00");
    }

    static decimal AgregarProducto()
    {
        try
        {
            Console.WriteLine("Ingrese el nombre del producto que desea agregar: ");
            string nombreProducto = Console.ReadLine().ToLower();
            decimal precioProducto = ObtenerPrecioProducto(nombreProducto);
            return precioProducto;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return 0;
        }
    }

    static decimal ObtenerPrecioProducto(string nombreProducto)
    {
        switch (nombreProducto)
        {
            case "fresa":
                return 10.00m;
            case "banano":
                return 4.00m;
            case "melon":
                return 8.00m;
            case "piña":
                return 10.00m;
            case "sandía":
                return 7.00m;
            default:
                throw new Exception("Producto no encontrado.");
        }
    }

    static bool OtroProducto()
    {
        Console.WriteLine("Desea agregar otro producto? (s/n)");
        string respuesta = Console.ReadLine().ToLower();
        return respuesta == "s";
    }

    static void Descuento(ref decimal totalCompra)
    {

    }

    static void Total(decimal totalCompra)
    {
        Console.WriteLine("El total de su compra es: Q" + totalCompra);
    }
}
