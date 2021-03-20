using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Animal
    {
        private int i_identificacion;
        private string s_nombre;
        private string s_raza;
        private string s_sexo;
        private int i_edad;
        private double d_peso;
        private string s_enfermedades;
        private Cliente[] cliente;

        public int i_Identificacion
        {
            get
            {
                return this.i_identificacion;
            }
            set
            {
                this.i_identificacion = value;
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

        public string s_Raza
        {
            get
            {
                return this.s_raza;
            }
            set
            {
                this.s_raza = value;
            }
        }
        public string s_Sexo
        {
            get
            {
                return this.s_sexo;
            }
            set
            {
                this.s_sexo = value;
            }
        }
        public int i_Edad
        {
            get
            {
                return this.i_edad;
            }
            set
            {
                this.i_edad = value;
            }
        }
        public Cliente Cliente
        {
            get;
            set;
        }
        public string s_Peso
        {
            get
            {
                return this.d_peso.ToString();
            }
            set
            {
                this.d_peso = Convert.ToDouble(value);
            }
        }
        public string s_Enfermedades
        {
            get
            {
                return this.s_enfermedades;
            }
            set
            {
                this.s_enfermedades = value;
            }
        }
    }
}
