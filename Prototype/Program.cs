using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("Kuan");
            a.setPersonalInfo("男", "25");
            a.sexWorkExperience("2017-2018","soft-world");

            Resume b = (Resume)a.Clone();
            b.sexWorkExperience("1998-2006", "YMCA");

            Resume c= (Resume)a.Clone();
            a.setPersonalInfo("男", "23");
            a.Display();
            b.Display();
            c.Display();
            Console.ReadKey();
        }
    }
}
