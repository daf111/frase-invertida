using System;

namespace _01_SoloInvertirUnaPalabra
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabraOriginal = "Hola";
            string palabraInvertida = "";

            for (int indice = 0; indice < palabraOriginal.Length; indice++)
            {
                palabraInvertida += palabraOriginal[palabraOriginal.Length - (indice + 1)];
            }

            Console.WriteLine(palabraInvertida);
        }
    }
}
