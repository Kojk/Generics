using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonníSeznam telefonníSeznam = new TelefonníSeznam();
            telefonníSeznam.AddStudenta(new Student { TelCislo = "216516512", Jmeno = "Karol", RC = "65186136" });
            telefonníSeznam.AddStudenta(new Student { TelCislo = "518546516", Jmeno = "Laco", RC = "16815616" });
            telefonníSeznam.AddStudenta(new Student { TelCislo = "216516512", Jmeno = "Jozef", RC = "65186136" });

            Student student = new Student();
            if (telefonníSeznam.Find("216516512", out student))
            {
                Console.WriteLine(student.Jmeno);
                Console.WriteLine(student.TelCislo);

            }
            else
            {
                Console.WriteLine("cislo nenalezene");
            }

            Console.ReadLine();
        }
    }
}

