using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    internal class Composer
    {
        public string name = "Undefined";
        public int birth;
        public Composer(string n, int b) { name = n; birth = b; }


        public void PrintComposer()
        {
            Console.WriteLine($"Name: {name}\nData of Birth: {birth}");
        }
    }
}
