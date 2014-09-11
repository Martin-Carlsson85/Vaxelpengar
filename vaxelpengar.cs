using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler
            double total = 0; //Totaltkostnad för köpet (nr.1)
            uint sum = 0; //Det kunden betalar kontant (nr.4)
            uint toPay = 0; //Att betala (nr.3)
            double round = 0; //Öresavrundningen (nr.2)
            uint back = 0; //Växel att få tillbaka (nr.5)
            uint amount500notes;
            uint amount100notes;
            uint amount50notes;
            uint amount20notes;
            uint amount10coins;
            uint amount5coins;
            uint amount1coins;


            // while-loop
            while (true)
            {
                try
                {   //Försöker översätta inmatat värde till en double-variabel.
                    Console.Write("Ange totalsumman:");
                    total = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {   //Ifall det inte fungerade så kommer detta att köras istället.
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTotalsumman är felaktig.");
                    Console.ResetColor();
                }
            }

            while (true)
            {
                try
                {   //Försöker översätta inmatat värde till en double-variabel.
                    Console.Write("Ange erhållet belopp:");
                    sum = uint.Parse(Console.ReadLine());
                    break;
                }
                catch
                {   //Ifall det inte fungerade så kommer detta att köras istället.
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nErhållet belopp är felaktigt.");
                    Console.ResetColor();
                }

            }

            //Öresavrundningsmetod
            toPay = (uint)Math.Round(total);


            //while-loop
            while (true)
            {
                try
                {
                    //Om kunden betalar för lite pengar säger programmet ifrån (det blir fel). Denna funktion "Kastar" felet.

                    if (sum <= toPay)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {   
                    //Här fångas felet upp och felmeddelande visas.
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nErhållet belopp är för litet.");
                    Console.ResetColor();
                    Console.Write("Ange erhållet belopp:");
                    sum = uint.Parse(Console.ReadLine());
                    
                }

            }
            //Här räknas öresavrudningen fram.
            round = toPay - total;

            //Här räknas kundens växel fram.
            back = sum - toPay;

            //En variabel som kopierar "back" till "backFixed". Detta för att kunna ange växel som kunden ska ha tillbaka.
            uint backFixed = back;

            //if-satser som konstrollerar det kunden ska ha tillbaka. Växeln (back) delas med valören, 
            //blir svaret högre än 1 så går programmet vidare.
            
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

            }
            if (back / 1 >= 1)
            {
                amount1coins = back / 1;
                back %= 1;

            }


            //Kvitto
            Console.WriteLine("\nKVITTO");
            Console.WriteLine("Totalt: {0}", total);
            Console.WriteLine("Öresavrudning: {0}", round);
            Console.WriteLine("Att betala: {0}", toPay);
            Console.WriteLine("Kontant: {0}", sum);
            Console.WriteLine("Tillbaka: {0}", backFixed);

        }
    }
}
