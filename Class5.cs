using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{

    class Class5
    {
        public int a;
        Class5(int a)
        {
            this.a = a;
        }
        public static void Main()
        {
            Class5 class5 = new Class5(1);
            Console.WriteLine(class5.a);
            Console.ReadLine();
        }
    }
}
