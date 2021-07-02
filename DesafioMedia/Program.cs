using System;

namespace Desafios_Aritméticos
{
        class media1
    {
        static void Main(string[] args)
        {
            double a,b;
            double media;
            
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            media = ((a*3.5)+(b*7.5))/(3.5+7.5);
            
            Console.WriteLine($"MEDIA = {media:f5}");
        }
    }
}

