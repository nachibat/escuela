using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno al = new Alumno(1, "Jose", "Dominguez", "10/10/2000", true);
            Conserje con = new Conserje(2, "Lucas", "Ladislao", "21/12/2002", "Cafeteria");
            Profesor pro = new Profesor(3, "Maria", "Juarez", "10/10/1999", "Fisica");

            Escuela esc = new Escuela("UTN");
            esc.AgregarProfesor(pro);
            esc.AgregarConserje(con);
            esc.AgregarAlumno(al);
            esc.ListarPersona();

            Console.ReadLine();
        }
    }
}
