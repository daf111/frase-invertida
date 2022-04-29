using System;

namespace _05_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseOriginal = "Hola como estás?";
            string[] palabrasOriginales = fraseOriginal.Split(' ');

            for (int indiceFrase = 0; indiceFrase < palabrasOriginales.Length; indiceFrase++)
            {
                char[] fraseAuxiliar = palabrasOriginales[indiceFrase].ToCharArray();
                Array.Reverse(fraseAuxiliar);
                Console.WriteLine(fraseAuxiliar);
            }

        }
    }
}
