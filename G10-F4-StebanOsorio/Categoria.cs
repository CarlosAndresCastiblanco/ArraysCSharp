using System;
using System.Collections.Generic;
using System.Text;

namespace G10_F4_StebanOsorio
{
    class Categoria
    {
        public string nombreCategoria;
        public double valorPremio;
        
        public void setNombreCategoria(string nombreCategoria)
        {
            this.nombreCategoria = nombreCategoria;
        }
        public string getNombreCategoria()
        {
            return this.nombreCategoria;
        }
        public void setValorPremio(double valorPremio)
        {
            this.valorPremio = valorPremio;
        }
        public double getValorPremio()
        {
            return this.valorPremio;
        }
    }
}
