// using -> import de java 
using MiBibliogonza;
using System;

// nombre del package como en java 
namespace MiAplicacion
{
    //nombre de la clase 
    class Program
    {
        //metodo principal Aplicacion de consola 
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello World!");
            //string asignatura = "Programación";
            //Console.Write("Ingrese nombre del estudiante:");
            //string estudiante = Console.ReadLine();
            //Console.Write("Ingrese su edad:");
            //// metodo Parse que al ingresar un valor por teclado por defecto es String lo transforma a entero 
            //int edad = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese la carrera:");
            //string carrera = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine(" *** Información de estudiante *** ");
            ////Trabajar con Mascaras para mostrar informacion en consola 
            ////variable estudiante que se remplaza en mascara{0}, variable carrera que se remplaza en mascara{1}
            //Console.WriteLine("Nombre del estudiante:{0} Carrera:{1}", estudiante, carrera);
            //Console.WriteLine("Edad es:{0}", edad);
            //Console.WriteLine("Asignatura es:{0}", asignatura);

            //Crear objeto persona 
            Persona objeto = new Persona();
            Console.Write("Ingrese su nombre:");
            // El nombre se guarda en el set de la propiedad 
            objeto.Nombre = Console.ReadLine();
            Console.Write("Ingrese su edad:");
            objeto.Edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese asignatura:");
            objeto.Asignatura = Console.ReadLine();
            Console.WriteLine("\n -- Informacion de persona --");
            Console.WriteLine("Su nombre es:{0}  Su edad es:{1}",objeto.Nombre,objeto.Edad);
            Console.WriteLine("Asignatura:{0}", objeto.Asignatura);



        }
    }
}
