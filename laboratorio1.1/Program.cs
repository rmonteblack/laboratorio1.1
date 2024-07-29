using System;


class Pogram
{
    static void Main(string[] args)
    {
        mostrar();

    }
    static void mostrar()
    {
        Console.WriteLine("Bienvenido a la tienda Chorrito de agua");
        Console.WriteLine("Actualmente contamos con 10 productos");
        Console.WriteLine("Desea ver los productos y su precio ? (s/n)"); 
        string respuesta = Console.ReadLine();
        if (respuesta == "s")
        {
            productosPrecios();
        }
        static void productosPrecios ()
        {
            Console.WriteLine("Fresa Q10.00");
            Console.WriteLine("Banano Q4.00");
            Console.WriteLine("Melon Q8.00");
            Console.WriteLine("Piña Q10.00");
            Console.WriteLine("Sandía Q7.00");
        }
    }
}   


