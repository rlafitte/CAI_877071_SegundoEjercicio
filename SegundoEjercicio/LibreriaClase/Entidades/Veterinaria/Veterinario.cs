using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Veterinario
    {
        private string s_nombre;
        private string s_apellido;
        private int i_documento;
        private string s_tipoDoc;
        private string s_sexo;
        private string s_telefono;
        private string s_domicilio;
        private string s_fechaIngresoRelacion; //para registrar cuando comenzó a trabajar en la veterinaria
        private string s_fechaFinRelacion; //en caso que renuncie

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
        //s_apellido
        public string s_Apellido
        {
            get
            {
                return this.s_apellido;
            }
            set
            {
                this.s_apellido = value;
            }
        }
        //i_documento
        public int i_Documento
        {
            get
            {
                return this.i_documento;
            }
            set
            {
                this.i_documento = value;
            }
        }
        //s_tipodoc
        public string s_Tipodoc
        {
            get
            {
                return this.s_tipoDoc;
            }
            set
            {
                this.s_tipoDoc = value;
            }
        }
        //s_sexo
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
        //s_telefono
        public string s_Tel
        {
            get
            {
                return this.s_telefono;
            }
            set
            {
                this.s_telefono = value;
            }
        }
        //s_domicilio
        public string s_Domicilio
        {
            get
            {
                return this.s_domicilio;
            }
            set
            {
                this.s_domicilio = value;
            }
        }

        //private string s_fechaIngresoRelacion; //para registrar cuando comenzó a trabajar en la veterinaria
        public string s_FechaIng
        {
            get
            {
                return this.s_fechaIngresoRelacion;
            }
            set
            {
                this.s_fechaIngresoRelacion = DateTime.Parse(value).ToString(); ;
            }
        }

        //private string s_fechaFinRelacion; //en caso que renuncie
        public string s_FechaFin
        {
            get
            {
                return this.s_fechaFinRelacion;
            }
            set
            {
                this.s_fechaFinRelacion = DateTime.Parse(value).ToString(); ;
            }
        }
    }
}
