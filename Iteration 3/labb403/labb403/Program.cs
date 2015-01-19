using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb403
{
    class Program
    {
        //Marco villegas


        static void Main(string[] args)// visar meny 
        {


            int val = 0;
            Boolean M = false;

            bool on = false;

            while (true)
            {

                Console.WriteLine("\nMeny\n-----------------------");
                Console.WriteLine("1. login");
                Console.WriteLine("2. Datum på event som varit");
                Console.WriteLine("3. sök datum");
                Console.WriteLine("4. sök namn");
                Console.WriteLine("5. Exit");
                Console.WriteLine("-----------------------");



                try
                {
                    val = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valet fins inte i menyn");
                    M = true;
                }

                if (M == false)
                {

                    if (val == 1)
                    {
                        login B23 = new login();
                        on = B23.userlogin();
                        
                        if(on == true)
                        {
                            online();
                        }
                    }

                    else if (val == 2)
                    {
                        eventfil B78 = new eventfil();
                        B78.LoadEventDatum();
                    }

                    else if (val == 3)
                    {
                        datum B1 = new datum();
                        B1.userdatum();
                    }

                    else if (val == 4)
                    {
                        namn B2 = new namn();
                        B2.usernamn();
                    }
                    else if (val == 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valet fins inte i menyn");
                    }
                }

                M = false;
            }

        }

        public static void online()// visar meny när du är inlogad
        {

             int val = 0;
            Boolean M = false;

            while (true)
            {

                Console.WriteLine("\nMeny\n-----------------------");
                Console.WriteLine("1. log out");
                Console.WriteLine("2. Datum på event som varit");
                Console.WriteLine("3. sök datum");
                Console.WriteLine("4. sök namn");
                Console.WriteLine("5. Spara event, deltagare och poäng ");
                Console.WriteLine("6. Exit");
                Console.WriteLine("-----------------------");



                try
                {
                    val = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valet fins inte i menyn");
                    M = true;
                }

                if (M == false)
                {

                    if (val == 1)
                    {
                            break;
                    }

                    else if (val == 2)
                    {
                        eventfil B78 = new eventfil();
                        B78.LoadEventDatum();
                    }
                    else if (val == 3)
                    {
                        datum B1 = new datum();
                        B1.userdatum();
                    }

                    else if (val == 4)
                    {
                        namn B2 = new namn();
                        B2.usernamn();
                    }
                    else if (val == 5)
                    {
                        saving B8 = new saving();
                        B8.savingevent();
                    }
                    else if (val == 6)
                    {
                        Console.WriteLine("\nDu måste logga ut för att avsluta!");
                    }
                    else
                    {
                        Console.WriteLine("Valet fins inte i menyn");
                    }
                }

                M = false;
            }
        
        }
    }
}
