using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace lista_recuperacion.Clases
{
    public class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();


        public Lista()
        {
            Primero = null;
            Ultimo = null;

        }


        public bool EsVacio()
        {
            if (Primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar()
        {
            Nodo nuevo = new Nodo();

            Console.WriteLine("Ingrese el producto y el precio");
            nuevo.NombreProducto = Convert.ToString(Console.ReadLine());
            nuevo.PrecioProducto = Convert.ToInt32(Console.ReadLine());

            if (EsVacio())
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                Ultimo = nuevo;
            }
        }



        public void Mostrar()
        {
            Nodo actual = new Nodo();
            actual = Primero;

            if (Primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine(actual.NombreProducto);
                    Console.WriteLine(actual.PrecioProducto);

                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Lista esta vacia");
            }
        }


        public void OrdenarBurbuja()
        {
            while (!OrdenarProducto())
            {
                Nodo actual = new Nodo();

                while (actual != null && actual.Siguiente != null)
                {
                    if (string.Compare(actual.NombreProducto, actual.Siguiente.NombreProducto) > 0)
                    {
                        string temporalProducto = actual.NombreProducto;
                        actual.NombreProducto = actual.Siguiente.NombreProducto;
                        actual.Siguiente.NombreProducto = temporalProducto;

                        int temporalPrecio = actual.PrecioProducto;
                        actual.PrecioProducto = actual.Siguiente.PrecioProducto;
                        actual.Siguiente.PrecioProducto = temporalPrecio;
                    }
                    actual = actual.Siguiente;
                }
            }
        }


        public bool OrdenarProducto()
        {
            Nodo actual = Primero;

            while (actual != null && actual.Siguiente != null)
            {
                if (string.Compare(actual.NombreProducto, actual.Siguiente.NombreProducto) > 0)
                {
                    return false;
                }
                actual = actual.Siguiente;
            }
            return false;
        }


        public void MostrarOrdenado()
        {
            //Console.WriteLine("Ordenando la lista por la marca");
            OrdenarBurbuja();
            Console.WriteLine("Los elementos por la Marca son");
            Mostrar();
        }


        public void BuscarPorPrecio(int precioABuscar)
        {
            Nodo actual = Primero;
            bool encontrado = false;

            while (actual != null)
            {
                if (actual.PrecioProducto == precioABuscar)
                {
                    Console.WriteLine($"Producto: {actual.NombreProducto}.");
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }

            if (!encontrado)
            {
                Console.WriteLine($"No se encontró ningún producto con el precio '{precioABuscar}'.");
            }
        }
    }
}

