using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labb402
{
    class savetofil
    {


        List<string> info = new List<string>();


        public savetofil()// konstruktor
        {

        }


        public void Save(string d, List<string> info)// Sparar data till text fil
        {


        

            using (StreamWriter writer = new StreamWriter("TextFile1.txt", true))
            {

                    writer.WriteLine(" ");
                    writer.WriteLine(d);
                 

                for (int i = 0; i < info.Count; i++) // Loopar igenom lista
                {

                    writer.WriteLine(info[i]);
                }

                    writer.WriteLine("-slut-");
                    
      

              

            }

        }

    }
}
