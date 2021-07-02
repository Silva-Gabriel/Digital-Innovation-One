using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace TESTE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            string item = "";

            Console.WriteLine("Número de itens: ");
            int N = Int32.Parse(Console.ReadLine());

            for(int i = 0; i <= N;i++)
            {
                Console.WriteLine($"Item {i}: ");
                item = Console.ReadLine().ToLower();
                lista.Add(item);
            }
            resul.Sort();
            foreach(var itemlista in lista)
            {
                Console.WriteLine(itemlista);
            }

        }
    }
}
