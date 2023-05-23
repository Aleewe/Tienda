using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Clases
{
    public class Funciones
    {
        public double Suma() 
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese los 5 articulos \n");
            Console.WriteLine("Articulo 1:");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Articulo 2:");
            double valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Articulo 3:");
            double valor3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Articulo 4");
            double valor4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Articulo 5");
            double valor5 = double.Parse(Console.ReadLine());   
            double total = valor1 + valor2 + valor3 + valor4 + valor5;

            if (total > 5000)
            {
                
                Console.WriteLine("Su valor total con el 10% de descuento es:");

                Console.ReadKey();
                Console.Clear();
                return total;
            }
    }
}
