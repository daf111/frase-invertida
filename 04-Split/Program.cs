using System;

namespace _04_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseOriginal = "Hola como estás?";
            string[] palabrasOriginales = fraseOriginal.Split(' ');

            for (int indiceFrase = 0; indiceFrase < palabrasOriginales.Length; indiceFrase++)
            {
                Console.WriteLine(InvertirPalabra(palabrasOriginales[indiceFrase]));
            }

        }

        private static string InvertirPalabra(string palabraOriginal)
        {
            string palabraInvertida = "";
            for (int indicePalabra = 0; indicePalabra < palabraOriginal.Length; indicePalabra++)
            {
                palabraInvertida += palabraOriginal[palabraOriginal.Length - (indicePalabra + 1)];
            }
            return palabraInvertida;
        }
    }
}
