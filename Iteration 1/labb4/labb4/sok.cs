using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labb4
{
    class sok
    {
        //Marco villegas

        private List<string> namen = new List<string>();

        private List<string> data = new List<string>();

        public sok()// konstruktor
        {
            
        }

        public void Loadsoknamn(string d, string n) // Läser från text och hittar Namn och presenterar poäng 
        {

            using (StreamReader reader = new StreamReader("TextFile1.txt"))
            {

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    if (line == d)
                    {

                        while ((line = reader.ReadLine()) != null)
                        {



                            if (line == n)
                            {

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
            }

        }

        public void Loadsokdat(string d) // Läser från text och hittar datum och visar alla tävlande, datumet du sökt på  
        {

            using (StreamReader reader = new StreamReader("TextFile1.txt"))
            {

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    if (line == d)
                    {
                        
                        Console.WriteLine("\nDu sökte på datum " + d );

                           
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
            }

        }


    }
}
