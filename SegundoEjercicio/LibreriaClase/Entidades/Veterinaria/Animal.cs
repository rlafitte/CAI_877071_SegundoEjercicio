using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio.LibreriaClase.Entidades.Veterinaria
{
    public class Animal
    {
        private int _identificacion;
        private string _nombre;
        private string _raza;
        private string _sexo;
        private int _edad;
        private double _peso;
        private string _enfermedades;
        private Cliente[] cliente;

        public int Identificacion { get => _identificacion; set => _identificacion = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Raza { get => _raza; set => _raza = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public string Enfermedades { get => _enfermedades; set => _enfermedades = value; }
        public Cliente[] Cliente { get => cliente; set => cliente = value; }
    }
}
