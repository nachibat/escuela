using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Alumno : Persona
    {
        private bool tieneLibreta;
        public Alumno(int leg, string nom, string ape, string fec, bool tieneLibreta) : base(leg, nom, ape, fec)
        {
            this.tieneLibreta = tieneLibreta;
        }

        public bool TieneLibreta { get { return this.tieneLibreta; } set { this.tieneLibreta = value; } }

        public override void MostrarDatos()
        {
            Console.WriteLine("Legajo: {0} - Nombre completo: {1} {2} - Edad: {3} - Libreta: {4}", this.Legajo, this.Nombre, this.Apellido, this.Edad, this.TieneLibreta);
        }
    }
}
