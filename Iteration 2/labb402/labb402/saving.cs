using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb402
{
    class saving
    {
        public saving()
        {

        }
        public void savingevent()
        {

            string dat = "";
            string name = "";

            String poeng = "";

            bool loop = true;

            Console.WriteLine("\nSpara\n-----------------------");

            List<string> info = new List<string>();

            while (loop)
            {

                Console.WriteLine("\nDatum:");

                dat = Console.ReadLine();

                loop = datkontrol(dat);

            }

            loop = true;

           

            bool m = true;

            int l = 0;

            int n = 0;

            while (m)
            {


                try
                {
                    Console.WriteLine("\nAntal personer som ska sparas:");

                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nFel!!! Du har inte matat in en siffra ");
                    m = true;
                    l++;
                }

                if (l == 0)
                {
                    m = false;
                }

                l = 0;
            }



            for (int i = 0; i < n; i++)
            {

                while (loop)
                {

                    Console.WriteLine("\nNamn:");

                    name = Console.ReadLine();

                    loop = namnkontrol(name);

                }

                loop = true;

                for (int t = 0; t < 3; t++)
                {
                    string text = "";

                    Console.WriteLine("Poäng:");
                    text = numer();

                    if(t == 1)
                    {
                    poeng += ","+text+",";
                    }
                    else
                    {
                    poeng += text;
                    }
                }

                name = "[" + name + "]";

                info.Add(name);
                info.Add(poeng);

                poeng = "";
            }

             dat = "[" + dat + "]";

            savetofil B9 = new savetofil();
            B9.Save(dat,info);
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

        public bool datkontrol(string d)//kontrollerar mellanslag/blanktecken i datum kontrollerar också att datum har två /
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


        public string numer()//kontrollerar att in matat värde är siffra  
        {

            bool m = true;

            int v = 0;

            int l = 0;

            while (m)
            {


                try
                {
                    v = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nFel!!! Du har inte matat in en siffra ");
                    Console.WriteLine("Poäng:");
                    m = true;
                    l++;
                }

                if (l == 0)
                {
                    m = false;
                }

                l = 0;
            }

            string G = v.ToString();

            return G;
        }


    }

}
