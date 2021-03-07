using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProgramacionUno.DOMINIO;
namespace LaboratorioProgramacionUno.NEGOCIO
{
    class ClsOperaciones
    {
        public Double ca1(ClsOps operacion)
        {
            Double total1 = (operacion.PrecioDelProducto * operacion.Cantidad);

            return total1;
        }

        public Double ca2(ClsOps operacion)
        {
            Double total2 = (operacion.PrecioDelProducto * operacion.Cantidad) + (operacion.Iva * operacion.PrecioDelProducto);

            return total2;
        }

        public String ca3(ClsOps operacion)
        {
            String nombreP = operacion.NombreDelProducto;

            return nombreP;
        }

        public double ca4(ClsOps operacion)
        {
            double ivaAgregar = operacion.Iva * operacion.PrecioDelProducto;

            return ivaAgregar;
        }
    }
}

