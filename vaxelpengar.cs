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


            //Console.Write("Ange totalsumman:");
            //total = double.Parse(Console.ReadLine());

            //Console.Write("Ange erhållet belopp:");
            //sum = uint.Parse(Console.ReadLine());

            //toPay = (uint)Math.Round(total);

            //round = toPay - total;

            //back = sum - toPay;
            back = 2976;
            if (back / 500 >= 1)
            {
                amount500notes = back / 500;
                back %= 500;

            }
            if (back / 100 >= 1)
            {
                amount100notes = back / 100;
                back %= 100;

            }
            if (back / 50 >= 1)
            {
                amount50notes = back / 50;
                back %= 50;

            }
            if (back / 20 >= 1)
            {
                amount20notes = back / 20;
                back %= 20;

            }
            if (back / 10 >= 1)
            {
                amount10coins = back / 10;
                back %= 10;
            }
            if (back / 5 >= 1)
            {
                amount5coins = back / 5;
                back %= 5;

                if (back / 1 >= 1)
                {
                    amount1coins = back / 1;
                    back %= 1;
                }
                Console.WriteLine(back);

            }
        }
    }
}
