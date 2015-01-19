using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb402
{
    class Program
    {

        //Marco villegas

        static void Main(string[] args)// visar meny 
        {

            /*
            string s = "abcd,cdef,efg,ijk,lmn";

          string[] words = s.Split(',');

    foreach (string word in words)
    {
        Console.WriteLine(word);
    }

    string b = "Marco";
    b = "[" + b + "]";
    Console.WriteLine(b);

            //string result = s.Substring(0, s.IndexOf(","));
      

            //Console.WriteLine(result);
         */

            


            int val = 0;
            Boolean M = false;

            while (true)
            {

                Console.WriteLine("\nMeny\n-----------------------");
                Console.WriteLine("1. sök datum");
                Console.WriteLine("2. sök namn");
                Console.WriteLine("3. Spara event, deltagare och poäng ");
                Console.WriteLine("4. Exit");
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
                        datum B1 = new datum();
                        B1.userdatum();
                    }

                    else if (val == 2)
                    {
                        namn B2 = new namn();
                        B2.usernamn();
                    }
                    else if (val == 3)
                    {
                        saving B8 = new saving();
                        B8.savingevent();
                    }
                    else if (val == 4)
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
    }
}
