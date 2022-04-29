using System;

namespace _03_ExtractToMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseOriginal = "Hola como estás?";
            string palabraOriginal = "";

            for (int indiceFrase = 0; indiceFrase < fraseOriginal.Length; indiceFrase++)
            {
                if (fraseOriginal[indiceFrase] == ' ')
                {
                    Console.WriteLine(InvertirPalabra(palabraOriginal));
                    palabraOriginal = "";
                }
                else
                {
                    palabraOriginal += fraseOriginal[indiceFrase];
                }
            }

            if (palabraOriginal != "")
            {
                Console.WriteLine(InvertirPalabra(palabraOriginal));
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
