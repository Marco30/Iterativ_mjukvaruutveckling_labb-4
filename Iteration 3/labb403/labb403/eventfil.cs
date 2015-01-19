using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labb403
{
    class eventfil
    {


        List<string> info = new List<string>();


        public eventfil()// konstruktor
        {

        }


        public void SaveEventDatum(string d)// Sparar data till text fil
        {

            using (StreamWriter writer = new StreamWriter("datum.txt", true))
            {

                writer.WriteLine(d);

            }

        }

        public void LoadEventDatum()// Sparar data till text fil
        {

            using (StreamReader reader = new StreamReader("datum.txt"))
            {

                string line;


                Console.WriteLine("\nDatum på event som varit");

                while ((line = reader.ReadLine()) != null)
                {

                  
                        Console.WriteLine(line);


                }

             }

             
          }

      }

}
