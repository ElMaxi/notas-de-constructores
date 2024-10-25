using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Empleado
    {
        private int ID { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public static int TotalEmpleados { get; set; }
        //constructor base
        public Empleado() 
        { ID = TotalEmpleados;
            Nombre = null;
            Departamento = null;
            TotalEmpleados++;
            Console.WriteLine($"Employee created from template\n");
        }
        //constructor ejemplo
        public Empleado( string nombre, string departamento)
        {
            ID = TotalEmpleados;
            Nombre = nombre;
            Departamento = departamento;
            TotalEmpleados++;
            Console.WriteLine($"Empleado {Nombre} creado.\n");
        }
        //constructor copia
        public Empleado(Empleado empleado)
        {
            ID = empleado.ID++;
            Nombre = empleado.Nombre;
            Departamento = empleado.Departamento;
            TotalEmpleados++;
            Console.WriteLine($"Empleado nuevo creado a partir de {empleado.Nombre}.\n");
        }


        //constructor estático
        static Empleado()
        {
            TotalEmpleados = 0;
            Console.WriteLine($"Sistema de empleados inicializado\n");
        }
        //constructor privado?
        private Empleado(string nombre)
        {
            ID = -1;
            Nombre = nombre;
            Departamento = "ADMIN";
            TotalEmpleados++;
            Console.WriteLine($"Administrador {Nombre} creado.\n");
        }

        //método estático para crear un administrador

        public static Empleado CrearAdministrador(string nombre)
        {
            return new Empleado(nombre);
            
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($" ID: {ID}, Nombre: {Nombre}, Departamento: {Departamento}\n");
        }

        public static void MostrarEmpleados()
        {
            Console.WriteLine($"\fCantidad de empleados creados: {TotalEmpleados}");
        }

    }
    internal class Program
    {

        static void Main()
        {

            Empleado employee1 = new Empleado();

            employee1.MostrarDetalles();

            Empleado employee2 = new Empleado("juan perez", "ventas");

            employee2.MostrarDetalles();

            Empleado employee3 = new Empleado(employee2);

            employee3.MostrarDetalles();

            Empleado employee4 = Empleado.CrearAdministrador("juan");

            employee4.MostrarDetalles();

            Empleado.MostrarEmpleados();

        }
    }
}
