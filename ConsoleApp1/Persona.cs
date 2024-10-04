using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Persona
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private DateTime fecnac;

        public Persona(int leg, string nom, string ape, string fec)
        {
            this.Legajo = leg;
            this.Nombre = nom;
            this.Apellido = ape;
            this.FecNac = DateTime.Parse(fec);
        }

        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set {this.apellido = value; } }
        public DateTime FecNac { get { return this.fecnac; } set { this.fecnac = value; } }
        public int Edad
        {
            get
            {
                DateTime hoy = DateTime.Now;
                return hoy.Year - this.FecNac.Year;
            }
        }

        public abstract void MostrarDatos();

    }
}
