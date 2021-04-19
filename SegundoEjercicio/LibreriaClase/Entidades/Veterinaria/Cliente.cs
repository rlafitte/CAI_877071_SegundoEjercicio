using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClase.Entidades.Veterinaria;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Cliente : Persona
    {
        private int id;

        protected int Id { get => id; set => id = value; }
    }
}
