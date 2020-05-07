using System;
using System.Collections.Generic;
using System.Text;

namespace G10_F4_StebanOsorio
{
    class Participantes
    {
        public int identificacion;
        public string nombre;
        public int categoria;

        public void setIdentificacion(int identificacion)
        {
            this.identificacion = identificacion;
        }
        public int getIdentificacion()
        {
            return this.identificacion;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setCategoria(int categoria)
        {
            this.categoria = categoria;
        }
        public int getCategoria()
        {
            return this.categoria;
        }
    }
}
