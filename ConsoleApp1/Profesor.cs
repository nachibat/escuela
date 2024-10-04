using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Profesor : Persona
    {
        private string materiaACargo;

        public Profesor(int leg, string nom, string ape, string fec, string mat) :base(leg, nom, ape, fec)
        {
            this.MateriaACargo = mat;
        }

        public string MateriaACargo { get { return this.materiaACargo; } set { this.materiaACargo = value; } }

        public override void MostrarDatos()
        {
            Console.WriteLine("Legajo: {0} - Nombre completo: {1} {2} - Edad: {3} - Materia a cargo: {4}", this.Legajo, this.Nombre, this.Apellido, this.Edad, this.MateriaACargo);
        }
    }
}
