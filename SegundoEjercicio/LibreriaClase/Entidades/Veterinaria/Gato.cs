using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoEjercicio.LibreriaClase.Entidades.Veterinaria;

namespace LibreriaClase.Entidades.Veterinaria
{
    public class Gato : Animal
    {
        protected bool _nocturno;

        public Gato(bool nocturno) : base()
        {
            this._nocturno = nocturno;
        }
        public bool Nocturno { get => _nocturno; set => _nocturno = value; }
    }
    
}

