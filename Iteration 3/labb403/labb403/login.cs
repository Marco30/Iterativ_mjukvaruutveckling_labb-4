using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labb403
{
    class login
    {

        public login()
        {
        
        }


        public bool userlogin()
        {

            Console.WriteLine("\nSign In\n-----------------------");

            Console.WriteLine("\nAnvändarnamn :");
            string name = Console.ReadLine();

            Console.WriteLine("\nPassword");
            string password = Console.ReadLine();

            kontroll B1 = new kontroll();

            return B1.kontrolllogin(name, password);

        }

    }
}
