using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Clases
{
    public class Cliente
    {
        public string Nombre { get; set; }  
        public int Telefono { get; set; }   
        public string Correo { get; set; }  

        public void Leer () 
        {
            Console.WriteLine("Bienvenido a la tienda Hillmans");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ingrese su nombre");
            Nombre= Console.ReadLine();
            Console.WriteLine("Ingrese su numero telefonico");
            Telefono = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su correo electronico");
            Correo= Console.ReadLine();
            
            Imprimir();

        }
        public void Imprimir ()
        {
            Console.WriteLine("Datos del cliente \n");
            Console.WriteLine(this.Nombre);
            Console.WriteLine(this.Telefono);
            Console.WriteLine(this.Correo, "\n");
            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
