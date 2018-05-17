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

        public void agregarObjeto(ClaseBase nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                if(nuevo.Codigo > inicio.Codigo || nuevo.Codigo > inicio.Siguiente.Codigo)
                {
                    ClaseBase temp = inicio;

                    while (temp.Siguiente != null)
                    {
                        temp = temp.Siguiente;
                    }
                    temp.Siguiente = nuevo;
                }

                else if(nuevo.Codigo < inicio.Siguiente.Codigo)
                {
                    ClaseBase temp = inicio;
                    temp.Siguiente.Anterior = nuevo;
                }

            }
        }

        public string reporte()
        {
            string cdn = "";

            return cdn;
        }

    }
}
