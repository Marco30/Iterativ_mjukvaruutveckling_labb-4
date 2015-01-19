using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labb402
{
    class sok
    {


        List<string> namen = new List<string>();

        List<string> password = new List<string>();

        public sok()// konstruktor
        {

        }

        public void Loadsoknamn(string d, string n) // Läser från text och hittar Namn och presenterar poäng 
        {

            using (StreamReader reader = new StreamReader("TextFile1.txt"))
            {

                int E = 0;

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    if (line == d)
                    {

                        E = 1;

                        while ((line = reader.ReadLine()) != null)
                        {



                            if (line == n)
                            {
                                E = 2;
                                while ((line = reader.ReadLine()) != null)
                                {

                                    Console.WriteLine("\nDu sökte på datum " + d + " och " + n);

                                    Console.WriteLine("\n" + n + " fick följande poäng");

                                    String s = line;

                                    string[] words = s.Split(',');

                                    int p = 0;

                                    foreach (string word in words)
                                    {
                                        p++;
                                        Console.WriteLine("Poäng " + p + ": " + word);
                                    }


                                    break;
                                }
                                break;
                            }


                        }

                    }
                }

                if (E == 0)
                {
                    Console.WriteLine("\ndatumet finns inte");
                }
                else if (E == 1)
                {
                    Console.WriteLine("\ndatumet finns men inte namnet");
                }
            }

        }

        public void Loadsokdat(string d) // Läser från text och hittar datum och visar alla tävlande, datumet du sökt på  
        {

            using (StreamReader reader = new StreamReader("TextFile1.txt"))
            {

                string line;

                int E = 0;

                while ((line = reader.ReadLine()) != null)
                {

                    if (line == d)
                    {
                        E++;

                        Console.WriteLine("\nDu sökte på datum " + d);


                        while ((line = reader.ReadLine()) != null)
                        {

                            if (line == "-slut-")
                            {
                                break;
                            }

                            String s = line;

                            bool text = s.Contains(",");

                            if (text == false)
                            {
                                Console.WriteLine("\n " + line);
                            }

                            else if (text == true)
                            {
                                string[] words = s.Split(',');

                                int p = 0;


                                foreach (string word in words)
                                {
                                    p++;
                                    Console.WriteLine("Poäng " + p + ": " + word);
                                }
                            }

                        }

                        
                    }

                }

                if (E == 0)
                {
                    Console.WriteLine("\nNamnet eller datumet finns inte");
                }

            }

        }




    }
}
