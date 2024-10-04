using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conserje : Persona
    {
        private string sectorACargo;

        public Conserje(int leg, string nom, string ape, string fec ,string sec) : base(leg, nom, ape, fec)
        {
            this.SectorACargo = sec;
        }

        public string SectorACargo { get { return this.sectorACargo; } set { this.sectorACargo = value; } }

        public override void MostrarDatos()
        {
            Console.WriteLine("Legajo: {0} - Nombre completo: {1} {2} - Edad: {3} - Sector a cargo: {4}", this.Legajo, this.Nombre, this.Apellido, this.Edad, this.SectorACargo);
        }
    }
}
