using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer__8
{
    //Control de sesión con variable global
    //Declara una variable global booleana sesionIniciada.Simula un inicio
    //de sesión que la cambie a true cuando el usuario ingrese la
//contraseña correcta.
    internal class Program
    {
        //declarar variable global 
        public static bool inicioSesion = false;
        private const string Contraseñacorrecta = "C# 2025";
        public static void IniciarSesion(string contraseñaIngresada)
        {
            //ingreso de contrase;a
            if (contraseñaIngresada == Contraseñacorrecta)
            {
                inicioSesion = true;
                Console.WriteLine(" incio de sesion iniciada.");


            }
              else
            {
                Console.WriteLine("Contraseña incorrecta. Inténtalo de nuevo.");
            }
        }
        
       

    public class program
    {

            public static void Main()
        {
            Console.WriteLine("Iniciar sesion");

         //inentos de inicio de sesion 
            
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"\nIntento {i} - Ingrese la contraseña: ");
                string intento = Console.ReadLine();

                    IniciarSesion(intento);
         

                if (inicioSesion)
                    break; // si ya inició sesión, sale del bucle
            }

            if (!inicioSesion)//respuestas de inicio o no de sesion 
            {
                Console.WriteLine("\nSe alcanzó el número máximo de intentos. Acceso denegado.");
            }
            else
            {
                Console.WriteLine("Bienvenido, sesión iniciada con éxito.");
            }

            Console.WriteLine("Programa terminado.");
        }
    }
}
           

}
