using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TelefonníSeznam
    {
        Dictionary<string, Student> seznam = new Dictionary<string, Student>();

        public void AddStudenta(Student student)
        {
            try
            {
                seznam.Add(student.TelCislo, student);
            }
            // odchytenie vynimky v pripade ze sa nepovede pridat klic do dictionary
            // napr. duplicitny kluc
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
        }

        public bool Find(string TelCislo, out Student student)
        {
           return seznam.TryGetValue(TelCislo, out student);
            
        }




    }
}
