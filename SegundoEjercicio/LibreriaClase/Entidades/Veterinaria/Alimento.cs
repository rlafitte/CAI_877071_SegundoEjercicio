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

        public string Marca { get => _marca; set => _marca = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal Peso { get => _peso; set => _peso = value; }
        public double PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public double PrecioCompra { get => _precioCompra; set => _precioCompra = value; }
        public int Stock { get => _stock; set => _stock = value; }
    }
}
