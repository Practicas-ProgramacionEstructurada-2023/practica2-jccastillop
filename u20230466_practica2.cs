using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable de texto capturando desde la terminal
            string? nombre;
            string? apellido;

            //Declaracion de variables de texto desde codigo
            string? codigo_estudiantil = "u20230466";
            string? becado = "Si";

            //Declaracion de variables de tipo entero capturando desde la terminal

            int edad;

            //Declaracion de variables de tipo enteras desde codigo

            int AñoIngreso = 2023;
            int AñoEgreso = 2024;

            //Declaracion de variables decimales capturando desde la terminal

            double mensualidad;

            //Declaracion de variables decimales desde codigo

            double transporte = 1.15;
            double alimentacion = 3.75;

            //Declaracion de variables de tiempo o time

            DateTime fechaActual = DateTime.Now;
            DateTime fechaEspecifica = new DateTime(23, 8, 19, 16, 20, 00);

            //Obtencion de datos desde la terminal

            Console.WriteLine("Ingrese su nombre:");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su apellido:");
            apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su mensualidad:");
            mensualidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            //Impresion de datos
            Console.WriteLine("***************Inicio de impresion***************");
            Console.WriteLine("Su nombre: " + nombre);
            Console.WriteLine("Su apellido: " + apellido);
            Console.WriteLine("Su codigo estudiantil es: " + codigo_estudiantil);
            Console.WriteLine("Es becado? " + becado);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su año de ingreso fue: " + AñoIngreso);
            Console.WriteLine("Su año de egreso sera: " + AñoEgreso);
            Console.WriteLine("Su mensualidad universitaria es: " + "$" + mensualidad);
            Console.WriteLine("Su gasto diario de transporte es: " + "$" + transporte);
            Console.WriteLine("Su gasto diario de alimentacion es: " + "$" + alimentacion);
            Console.WriteLine("La fecha y tiempo de impresion de datos es: " + fechaActual);
            Console.WriteLine("La fecha que termina la practica es: " + fechaEspecifica);
            Console.WriteLine("***************Fin de impresion***************");

            //APLICACION DE FUNCIONES DE CADENA

            //Funcion de comparacion cadenas de texto

            bool cadenaComparativa = nombre == apellido;

            //Funcion de Minuscula

            string? funcionMinuscula1 = nombre.ToLower();
            string? funcionMinuscula2 = apellido.ToLower();

            //Funcion de Mayuscula

            string? funcionMayuscula1 = nombre.ToUpper();
            string? funcionMayuscula2 = apellido.ToUpper();

            //Funcion de concatenado

            string? cadenaConcatenada = nombre + "" + apellido;

            //Funcion de tamaño de cadena

            int llongitudCadena1 = nombre.Length;
            int llongitudCadena2 = apellido.Length;

            Console.WriteLine("***************Inicio de impresion*************** ");
            Console.WriteLine("Comparacion: " + cadenaComparativa);
            Console.WriteLine("Mayuscula Nombre y Apellido: " + funcionMayuscula1 + "" + funcionMayuscula2);
            Console.WriteLine("Minuscula Nombre y Apellido: " + funcionMayuscula1 + "" + funcionMayuscula2);
            Console.WriteLine("Concatenacion: " + cadenaConcatenada);
            Console.WriteLine("La longitud de datos de nombre es: " + llongitudCadena1);
            Console.WriteLine("La longitud de datos de apellido es: " + llongitudCadena2);
            Console.WriteLine("***************Fin de impresion*************** ");

        }
    }
}