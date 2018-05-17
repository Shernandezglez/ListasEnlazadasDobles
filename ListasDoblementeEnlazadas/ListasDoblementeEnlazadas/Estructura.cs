using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeEnlazadas
{
    class Estructura
    {
        ClaseBase inicio = null;
        ClaseBase ultimo = null;

        public void agregarObjeto(ClaseBase nuevo)
        {
            ClaseBase temp = inicio;
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
            }
                
            else if(nuevo.Codigo > ultimo.Codigo)
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
            else if(nuevo.Codigo < inicio.Codigo)
            {
                nuevo.Siguiente = inicio;
                inicio.Anterior = nuevo;
                inicio = nuevo;
            }
            else
            {
                while (nuevo.Codigo > temp.Codigo)
                {
                    temp = temp.Siguiente;
                }
                nuevo.Anterior = temp.Anterior;
                nuevo.Siguiente = temp;
                temp.Anterior.Siguiente = nuevo;
                temp.Anterior = nuevo;
            }
        }

        public string reporte()
        {
            string cdn = "";
            ClaseBase temp = inicio;
            while(temp != null)
            {
                cdn += temp.ToString() + "\r\n";
                temp = temp.Siguiente;
            }
            return cdn;
        }

        public string reporteInverso()
        {
            string cdn = "";
            ClaseBase temp = ultimo;
            while (temp != null)
            {
                cdn += temp.ToString() + "\r\n";
                temp = temp.Anterior;
            }

            return cdn;
        }

        public ClaseBase buscarPorCodigo(int cod)
        {
            ClaseBase temp = inicio;
            while(temp != null)
            {
                if(temp.Codigo == cod)
                {
                    return temp;
                }
                temp = temp.Siguiente;
            }
            return null;

        }

        public void eliminarDatoPorCodigo(int cod)
        {
            ClaseBase temp = inicio, t = null;

            if(inicio.Codigo == cod)
            {
                inicio = inicio.Siguiente;
                inicio.Anterior = null;
            }
            else if(ultimo.Codigo == cod)
            {
                t = ultimo.Anterior;
                t.Siguiente = null;
                ultimo.Anterior = null;
                ultimo = t;
            }
            else
            {
                while (temp != null)
                {
                    if(temp.Codigo == cod)
                    {
                        temp.Anterior.Siguiente = temp.Siguiente;
                        temp.Siguiente.Anterior = temp.Anterior;
                    }
                    temp = temp.Siguiente;
                }
            }
        }

        public void eliminarPrimero()
        {
            inicio = inicio.Siguiente;
            inicio.Anterior = null;
        }

        public void eliminarUltimo()
        {
            ClaseBase  t = null;

            t = ultimo.Anterior;
            t.Siguiente = null;
            ultimo.Anterior = null;
            ultimo = t;
        }

    }
}
