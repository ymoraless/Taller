using System;

namespace Ejercicio45_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!! \n¡Bienvenidos al mundo de los vectores!");
            Console.WriteLine("\n");

            // Declaro variables
            Random random = new Random();
            int[] num = new int[21];

            // Defino rango, ya que no le estaba haciendo y me arrojaba numeros demasiado grandes
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(-500, 501);

                // Personalizo según numero positivo y negativo
                if (num[i] >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine($"Pos {i}: {num[i]}");
                Console.ResetColor(); // Resetear el color a su estado original
            }

            // Pedir al usuario que ingrese un número para buscar en el vector
            Console.WriteLine("\nIngrese un número para buscar en el vector: ");
            int numBuscar = Convert.ToInt32(Console.ReadLine());

            // Condiciones del número a buscar
            bool encontrado = false;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == numBuscar)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"El número {numBuscar} se encuentra en la posición {i}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El número no existe en el vector.");
            }
        }
    }
}
