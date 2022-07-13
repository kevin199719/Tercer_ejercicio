using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_2_clase_1_ejemplo_2
{
    //Clase abstrapta

    public abstract class Persona
    {
        public abstract void Descripcion();

    }



    class Estudiante  : Persona 
    {
        //atributo
        public string Cedula { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(string cedula)
        {
            Cedula = cedula;
        }

        // metodo abstrapto
        public override void Descripcion()
        {
            Console.WriteLine("El estudiante esta cursando en la universidad. Es parte de la carrera de Sistemas");
        }

        //Polimorfismo
        public void MostrarCedula()
        {
            Console.WriteLine("El estudiante no cuenta con cedula activa");
        }

        public void MotrarCedula (string CedulaManual)
        {
            Console.WriteLine("La cedula del estudiante es : " + Cedula);
        }
    }





    class Empleado : Persona
    {
        //atributo
        public string Salario { get; set; }

        public Empleado()
        {

        }

        public Empleado(string salario)
        {
            Salario = salario;
        }

        // metodo abstrapto
        public override void Descripcion()
        {
            Console.WriteLine("El trabajador es parte de Dos pinos");
        }

        //Polimorfismo
        public void MostrarSalario()
        {
            Console.WriteLine("El empleado no cuenta con el monto del salario en la base de datos");
        }

        public void MotrarSalario(string SalarioManual)
        {
            Console.WriteLine("El salario del empleado es : " + Salario + " colones mensualmente");
        }
    }


    class Docente : Persona
    {
        //atributo
        public string Materia { get; set; }

        public Docente()
        {

        }

        public Docente(string materia)
        {
            Materia = materia;
        }

        // metodo abstrapto
        public override void Descripcion()
        {
            Console.WriteLine("El Docente imparte clases en la UAM");
        }

        //Polimorfismo
        public void MostrarMateria()
        {
            Console.WriteLine("El docente no cuenta con materias asignadas en la base de datos");
        }

        public void MostrarMateria(string MateriaManual)
        {
            Console.WriteLine("La materia  que el docente imparte es  : " + Materia);
        }
    }



}
