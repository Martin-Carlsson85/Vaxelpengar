using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
          // Deklarera variabler
            double total; //Totaltsumman INNAN öresavrundningen
            uint sum; //Det kunden beatalar inkl.växel
            uint toPay; //Totaltsumman EFTER öresavrundningen
            double round; //Öresavrundningen
            uint back; //Växel att få tillbaka
            uint amount500notes;
            uint amount100notes;
            uint amount50notes;
            uint amount20notes;
            uint amount10coins;
            uint amount5coins;
            uint amount1coins;


            Console.Write("Ange totalsumman:");
            total = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp:");
            sum = uint.Parse(Console.ReadLine());

            toPay = (uint)Math.Round(total);

            round = toPay - total;

            back = sum - toPay;


           
        }   
    }
}
