using System;

namespace Semana_2_clase_1_ejemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            Estudiante estudiante2 = new Estudiante("123456789");

            estudiante1.MostrarCedula();
            estudiante1.Descripcion();
            estudiante2.MotrarCedula(estudiante2.Cedula);
            estudiante2.Descripcion();

            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado("1.500.00");

            empleado1.MostrarSalario();
            empleado1.Descripcion();
            empleado2.MotrarSalario(empleado2.Salario);
            empleado2.Descripcion();

            Docente docente1 = new Docente();
            Docente docente2 = new Docente("Matematicas");

            docente1.MostrarMateria();
            docente1.Descripcion();
            docente2.MostrarMateria(docente2.Materia);
            docente2.Descripcion();

        }
    }
}
