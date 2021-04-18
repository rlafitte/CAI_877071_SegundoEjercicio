using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Alimento
    {
        private string _marca;
        private string _nombre;
        private decimal _peso;
        private double _precioVenta;
        private double _precioCompra;
        private int _stock;

        public string S_marca { get => _marca; set => _marca = value; }
        public string S_nombre { get => _nombre; set => _nombre = value; }
        public decimal D_peso { get => _peso; set => _peso = value; }
        public double D_precioVenta { get => _precioVenta; set => _precioVenta = value; }
        public double D_precioCompra { get => _precioCompra; set => _precioCompra = value; }
        public int I_stock { get => _stock; set => _stock = value; }
    }
}
