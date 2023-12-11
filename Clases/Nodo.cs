using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lista_recuperacion.Clases
{
    public class Nodo
    {
        private string _nombreProducto;
        private int _precioProducto;
        private Nodo _siguiente;


        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        public int PrecioProducto
        {
            get { return _precioProducto; }
            set { _precioProducto = value; }
        }

        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
