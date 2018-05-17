using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeEnlazadas
{
    class ClaseBase
    {

        private string _producto;
        private string _alumno;
        private string _vehiculo;
        private int _contacto;
        private int _codigo;
        private ClaseBase _siguiente;
        private ClaseBase _anterior;




        public ClaseBase(string p, string al, string vei, int cont, int cod)
        {
            _producto = p;
            _alumno = al;
            _vehiculo = vei;
            _contacto = cont;
            _codigo = cod;
        }

        public override string ToString()
        {
            return "Producto: " + _producto + " | " + " Alumno: " + _alumno + " | " + " Vehiculo: " + _vehiculo + " | " + " Contacto: " + _contacto;
        }
        public ClaseBase Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public ClaseBase Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public string Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }

        public string Vehiculo
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }

        public int Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
      }

    }
