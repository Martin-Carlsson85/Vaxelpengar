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
            uint amount500notes = 0;
            uint amount100notes = 0;
            uint amount50notes = 0;
            uint amount20notes = 0;
            uint amount10coins = 0;
            uint amount5coins = 0;
            uint amount1coins = 0;


            // while-loop
            while (true)
            {
                try
                {   //Försöker översätta inmatat värde till en double-variabel.
                    Console.Write("Ange totalsumman:");
                    total = double.Parse(Console.ReadLine());
                    

                    //Gör så att programmet avslutas vid totaltsumma mindre än 1 krona. 
                    if (total < 1)
                    {

                        throw new Exception();

                    }
                    break;

                }
                catch
                {   //Ifall det inte fungerade så kommer detta att köras istället.
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTotalsumman är felaktig.");
                    Console.ResetColor();
                }
            }

            //Öresavrundningsmetod
            toPay = (uint)Math.Round(total);

       

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


            //Om kunden betalar för lite pengar säger programmet ifrån (det blir fel). Denna funktion "Kastar" felet.

            if (sum < toPay)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nErhållet belopp är för litet.");
                Console.ResetColor();
                return;
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
            Console.WriteLine("----------------------");
            Console.WriteLine("Totalt: {0}", total);
            Console.WriteLine("Öresavrudning: {0}", round);
            Console.WriteLine("Att betala: {0}", toPay);
            Console.WriteLine("Kontant: {0}", sum);
            Console.WriteLine("Tillbaka: {0}", backFixed);
            Console.WriteLine("----------------------");

            //Här presnteras antalet sedlar som kunden får tillbaka.
            if (amount500notes != 0)
            {
                Console.WriteLine("500-lappar: {0}", amount500notes);
            }

            if (amount100notes != 0)
            {
                Console.WriteLine("100-lappar: {0}", amount100notes);
            }

            if (amount50notes != 0)
            {
                Console.WriteLine("50-lappar: {0}", amount50notes);
            }

            if (amount20notes !=0)
            {
                Console.WriteLine("20-lappar: {0}", amount20notes);
            }
            
            if (amount10coins !=0)
            {  
                Console.WriteLine("5-kronor: {0}", amount10coins);
            }
            
            if (amount5coins !=0)
            {
                Console.WriteLine("5-kronor: {0}", amount5coins);
            }
            
            if (amount1coins !=0)
            {
                Console.WriteLine("1-kronor: {0}", amount1coins);
            }


        }
    }
}
