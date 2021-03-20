using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Alimento
    {
        private string s_marca;
        private string s_nombre;
        private decimal d_peso;
        private double d_precioVenta;
        private double d_precioCompra;
        private int i_stock;
        
        public int i_Stock
        {
            get
            {
                return this.i_stock;
            }
            set
            {
                this.i_stock = value;
            }
        }
        public string s_Marca
        {
            get
            {
                return this.s_marca;
            }

            set
            {
                this.s_marca = value;
            }
        }
        public string s_Nombre
        {
            get
            {
                return this.s_nombre;
            }
            set
            {
                this.s_nombre = value;
            }
        }

        public decimal d_Peso
        {
            get
            {
                return this.d_peso;
            }
            set
            {
                if (d_peso > 0) 
                { 
                this.d_peso = value;
                }
            }
        }
        public string s_PrecioVenta
        {
            get
            {
                return "$ " + this.d_precioVenta.ToString();
            }

            set
            {
                this.d_precioVenta = Convert.ToDouble(value);
            }
        }
        public string s_PrecioCompra
        {
            get
            {
                return "$ " + this.d_precioCompra.ToString();
            }

            set
            {
                this.d_precioCompra = Convert.ToDouble(value);
            }
        }
    }
}
