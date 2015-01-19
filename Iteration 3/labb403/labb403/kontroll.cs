using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labb403
{
    class kontroll
    {


        List<string> namen = new List<string>();

        List<string> password = new List<string>();

        public kontroll()// konstruktor
        {

        }

        public bool kontrolllogin(string nam, string pasw) // Läser från text och hittar Namn och presenterar poäng 
        {

            bool Q = false;

            using (StreamReader reader = new StreamReader("password.txt"))
            {

                int E = 0;

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    if (line == nam)
                    {

                        E = 1;

                        while ((line = reader.ReadLine()) != null)
                        {



                            if (line == pasw)
                            {
                                E = 2;
                               
                                break;
                            }
                            else 
                            {
                                E = 3;
                            }

                        }

                    }
                }

                if (E == 0)
                {
                    Console.WriteLine("\nFel användare namn!!!");
                }
                else if (E == 3)
                {
                    Console.WriteLine("\nRätt användarnamn fel lösenord!!!");
                }
                else if (E == 2)
                {
                    Console.WriteLine("\nDu är nu inloggad");
                    Q = true;
                }
            }

            return Q;


        }



    }
}
