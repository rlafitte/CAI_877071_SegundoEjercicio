using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoEjercicio.LibreriaClase.Entidades.Veterinaria;

namespace SegundoEjercicio.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Alimento Al = new Alimento();
            Animal An = new Animal();
            Cliente Cl = new Cliente();
            Medicamento Me = new Medicamento();
            Tratamiento Tr = new Tratamiento();
            Veterinario Ve = new Veterinario();
        }
    }
}
