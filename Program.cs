using lista_recuperacion.Clases;
using System;

namespace lista_recuperacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            for (int i = 0; i < 6; i++)
            {
                lista.Insertar();   
            }

            Console.WriteLine("");
            Console.WriteLine("Los productos guardados son: ");
            lista.Mostrar();

            //Console.WriteLine("");
            //Console.WriteLine("Los productos ordenados por el precio son: ");
            //lista.OrdenarProducto();

            Console.WriteLine("");
            Console.WriteLine("Ingrese el precio a buscar:");
            int precioBuscado = Convert.ToInt32(Console.ReadLine());
            lista.BuscarPorPrecio(precioBuscado);
        }
    }
}