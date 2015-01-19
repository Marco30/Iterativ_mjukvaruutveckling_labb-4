using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb403
{
    class namn
    {
        public namn()
        {

        }
        public void usernamn()
        {

            string dat = "";
            string name = "";
            bool loop = true;

            Console.WriteLine("\nsök\n-----------------------");

            while (loop)
            {

                Console.WriteLine("\nDatum:");

                dat = Console.ReadLine();

                loop = datkontrol(dat);

            }

            loop = true;

            while (loop)
            {

                Console.WriteLine("\nNamn:");

                name = Console.ReadLine();

                loop = namnkontrol(name);

            }

            dat = "[" + dat + "]";

            name = "[" + name + "]";

            sok g = new sok();

            g.Loadsoknamn(dat, name);

        }



        public bool namnkontrol(string n)//kontrollerar mellanslag/blanktecken i namn 
        {
            bool m = true;

            bool text = n.Contains(" ");

            if (n == null || n.Length == 0)
            {
                Console.WriteLine("\nskriv in ett namn\n");
            }
            else if (text == true)
            {
                Console.WriteLine("\nDu får inte ha mellanslag i namnet\n");
            }
            else
            {

                m = false;

            }

            return m;
        }

        public bool datkontrol(string d)//kontrollerar mellanslag/blanktecken i datum 
        {

            bool m = true;

            bool text2 = d.Contains(" ");


            int A = 0;

            foreach (char c in d)// loopar i genom string och får char värdet av varige string   
            {
                if (c == '/')//jämför om char värdet är lika med bokstaven /    
                {
                    A++;
                }
            }

            bool text3 = d.Contains("/");

            if (d == null || d.Length == 0)
            {
                Console.WriteLine("\nskriv in ett datum\n");
            }
            else if (text2 == true)
            {
                Console.WriteLine("\nfell Du får inte ha mellanslag i datum, exempel 2014/05/19\n");
            }
            else if (A < 2)
            {
                Console.WriteLine("\ndu måste minst ha två / i datumet, exempel 2014/05/19\n");
            }
            else
            {
                m = false;
            }

            return m;
        }

    }
}
