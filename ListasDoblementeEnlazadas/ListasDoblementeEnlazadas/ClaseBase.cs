using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeEnlazadas
{
    class ClaseBase
    {
        private int _dato;
        private ClaseBase _siguiente;
        private ClaseBase _anterior;


        public ClaseBase Siguiente
        {
            get { return _siguiente;}
            set { _siguiente = value; }
        }

        public ClaseBase Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public int Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public ClaseBase(int dato)
        {
            _dato = dato;
        }

        public override string ToString()
        {
            return "Dato :" + _dato;
        }
    }
}
