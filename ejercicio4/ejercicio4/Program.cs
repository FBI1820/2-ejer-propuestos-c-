using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static List<int> notas = new List<int>();

        static void Main(string[] args)
        {
            string nota;
            int nota1;
            while (true)
            {
                Console.WriteLine("ingrese su nota (salir para terminar)");
                nota = Console.ReadLine();
                if (nota != "salir")
                {
                    int.TryParse(nota, out nota1);
                    notas.Add(nota1);
                }
                else
                {
                    Console.WriteLine("saliendo");
                    break;
                }
            }
            double promedio= calcularpromedio();
            Console.WriteLine($"su promedio es:{promedio:f2}");

            if (promedio >= 90 && promedio <= 100)
            {
                Console.WriteLine("excelente");
            }
            else if (promedio >= 70)
            {
                Console.WriteLine("bueno");
            }
            else
            {
                Console.WriteLine("reprobado");
            }
            Mostrar();
            Console.WriteLine("toque cualquier tecla para salir");
            Console.ReadKey();
        }
        static double calcularpromedio()
        {
            double total = 0;
            double promedio;
            foreach (int i in notas)
            {
                total += i;
            }
            promedio = total / notas.Count;
            return promedio;

        }
        static void Mostrar()
        {
            if (notas.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
                return;
            }

            int notaMaxima = notas[0];
            int notaMinima = notas[0];

            foreach (int nota in notas)
            {
                if (nota > notaMaxima) notaMaxima = nota;
                if (nota < notaMinima) notaMinima = nota;
            }

            Console.WriteLine($"Nota más alta: {notaMaxima}");
            Console.WriteLine($"Nota más baja: {notaMinima}");
            
        }

    }
}
