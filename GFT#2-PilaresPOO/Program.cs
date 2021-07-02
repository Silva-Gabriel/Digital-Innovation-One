using System;
using GFT_2_PilaresPOO.myCode.Models;

namespace GFT_2_PilaresPOO
{
    class Program
    {
        static void Main(string[] args)
        {
           Hero Arus = new Hero("Arus",23,"Knight");
           Wizard Jennica = new Wizard("Jennica", 23, "Black Wizard");
           
           Console.WriteLine(Arus.Attack());
           Console.WriteLine(Jennica.Attack(8));
        }
    }
}
