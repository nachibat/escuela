using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Escuela
    {
        private string nombreInstitucional;
        private List<Conserje> conserjes;
        private List<Alumno> alumnos;
        private List<Profesor> docentes;
        private List<Persona> personas;

        public Escuela(string nombre)
        {
            this.NombreInstitucional = nombre;
            this.conserjes = new List<Conserje>();
            this.alumnos = new List<Alumno>();
            this.docentes = new List<Profesor>();
            this.personas = new List<Persona>();
        }

        public string NombreInstitucional { get { return this.nombreInstitucional; } set { this.nombreInstitucional = value; } }

        public void ListarPersona()
        {
            foreach (Persona item in this.personas)
            {
                item.MostrarDatos();
            }
        }

        public void AgregarConserje(Conserje conserje)
        {
            this.personas.Add(conserje);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            this.personas.Add(profesor);
        } 

        public void AgregarAlumno (Alumno alumno)
        {
            this.personas.Add (alumno);
        }
    }
}
