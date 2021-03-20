using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Medicamento
    {
        private string s_nombre;
        private string s_marca;
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
    }
}
