// See https://aka.ms/new-console-template for more information
using System;

//Juego de intentos con variable global 
// Crea un programa que use una variable global para almacenar el 
//número de intentos de adivinar un número secreto. Cada intento se 
//registra y se muestra.

public class Program
{
    public static int intentos = 0; // declaro la variable global que el ejercicio pide
    public static void Main(string[] args)
    {
        Random Numerorandom = new Random(); // El metodo Random() es originario de c#, si se importa System ya viene incluido
        int numeroSecreto = Numerorandom.Next(1, 11); //Delimito que el numero secreto sea entre 1 y 10, porque si no muy largo. Lo pongo en 11 para que tome el 10
        int numeroUsuario = 0; //Declaro que el numero del usuario empieza en 0

        while (numeroUsuario != numeroSecreto) //Aqui digo: oye siguele pidiendo numeros al usuario hasta que el que incerte sea igual al secreto que creastes
        {
            Console.WriteLine("Adivina el número secreto (entre 1 y 10):");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());
            intentos++; //Cada vez que el ciclo se ejecute y nada que el usuario acierta, los intentos se aumentan

            if (numeroUsuario < numeroSecreto) // Una pequeña adición para divertirnos!, un consicional que le permite al usuario saber si debe de
            //intentear con un numero mayor o menor
            {
                Console.WriteLine(" Intenta de nuevo con un numero mayor.");
            }
            else if (numeroUsuario > numeroSecreto)
            {
                Console.WriteLine(" Intenta de nuevo con un numero menor.");
            }
        }

        Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
    } //Luego ya porfin le decimos, Kudos, por fin acertastes con {intentos} 
}
