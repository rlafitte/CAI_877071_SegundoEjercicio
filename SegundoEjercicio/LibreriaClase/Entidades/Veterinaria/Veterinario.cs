using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoEjercicio.LibreriaClase.Entidades.Veterinaria;
using LibreriaClase.Entidades.Veterinaria;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Veterinario : Persona
    {

        protected string _fechaInicioRelacion; //para registrar cuando comenzó a trabajar en la veterinaria
        protected string _fechaFinRelacion; //en caso que renuncie

        //private string s_fechaIngresoRelacion; //para registrar cuando comenzó a trabajar en la veterinaria
        public string FechaIng
        { get=>_fechaInicioRelacion; set => _fechaFinRelacion = value; }
        

        //private string s_fechaFinRelacion; //en caso que renuncie
        public string FechaFin
        { get => _fechaFinRelacion; set => _fechaFinRelacion = value;  }
    }
}
