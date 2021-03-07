using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.DOMINIO
{
    class ClsOps
    {
        private double IVA;
        private String nombreDelProducto;
        private double precioDelProducto;
        private double cantidad;

        public double Iva { get => IVA; set => IVA = value; }
        public string NombreDelProducto { get => nombreDelProducto; set => nombreDelProducto = value; }
        public double PrecioDelProducto { get => precioDelProducto; set => precioDelProducto = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
    }
}
