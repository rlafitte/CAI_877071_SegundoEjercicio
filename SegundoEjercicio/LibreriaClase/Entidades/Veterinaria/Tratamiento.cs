using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Tratamiento
    {
        private string s_tipo;
        private string s_fechaTratamiento;
        private string s_fechaAlta;
        private string s_fechaDefuncion;
        private Animal[] animal;
        private Medicamento[] medicamento;

        public string s_Tipo
        {
            get
            {
                return this.s_tipo;
            }
            set
            {
                this.s_tipo = value;
            }
        }

        //private string s_tipo;

        public string s_FechaT
        {
            get
            {
                return this.s_fechaTratamiento;
            }
            set
            {
                this.s_fechaTratamiento = DateTime.Parse(value).ToString(); ;
            }
        }

        //private string s_fechaAlta;
        public string s_FechaA
        {
            get
            {
                return this.s_fechaAlta;
            }
            set
            {
                this.s_fechaAlta = DateTime.Parse(value).ToString(); ;
            }
        }
        //private string s_fechaDefuncion;
        public string s_FechaDef
        {
            get
            {
                return this.s_fechaDefuncion;
            }
            set
            {
                this.s_fechaDefuncion = DateTime.Parse(value).ToString(); ;
            }
        }
        //private Animal[] animal;
        public Animal Animal
        {
            get;
            set;
        }
        //private Medicamento[] medicamento;
        public Medicamento Medicamento 
        {
            get;
            set;
        }
    }
}
