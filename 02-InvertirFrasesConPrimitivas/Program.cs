using System;
using System.Collections.Generic;

namespace _02_InvertirFrasesConPrimitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseOriginal = "Hola como estás?";
            string palabraOriginal = "";
            string palabraInvertida;

            for (int indiceFrase = 0; indiceFrase < fraseOriginal.Length; indiceFrase++)
            {
                if (fraseOriginal[indiceFrase] == ' ')
                {
                    palabraInvertida = "";
                    for (int indicePalabra = 0; indicePalabra < palabraOriginal.Length; indicePalabra++)
                    {
                        palabraInvertida += palabraOriginal[palabraOriginal.Length - (indicePalabra + 1)];
                    }
                    Console.WriteLine(palabraInvertida);
                    palabraOriginal = "";
                }
                else
                {
                    palabraOriginal += fraseOriginal[indiceFrase];
                }
            }

            if (palabraOriginal != "")
            {
                palabraInvertida = "";
                for (int indicePalabra = 0; indicePalabra < palabraOriginal.Length; indicePalabra++)
                {
                    palabraInvertida += palabraOriginal[palabraOriginal.Length - (indicePalabra + 1)];
                }
                Console.WriteLine(palabraInvertida);
            }
            
        }
    }
}
