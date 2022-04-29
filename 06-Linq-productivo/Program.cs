using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Linq_productivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseOriginal = "Hola como estás?";
            List<string> palabrasOriginales = new List<string>(fraseOriginal.Split(' '));
            palabrasOriginales.ForEach(
                palabraOriginal => Console.WriteLine(String.Join("", palabraOriginal.Reverse()))
            );
        }
    }
}
