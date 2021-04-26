using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Class2
    {
        int a;
        int b;
        Class2(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        public static Class2 operator +(Class2 _obj1, Class2 _obj2)
        {
            Class2 _obj3 = new Class2(0, 0);
            _obj3.a = _obj1.a + _obj2.a;
            _obj3.b = _obj1.b + _obj2.b;
            return _obj3;
        }
        public static void Showvalues(Class2 _obj)
        {
            Console.WriteLine("a =" + _obj.a);
            Console.WriteLine("b =" + _obj.b);
        }
        public static void Main()
        {
            Class2 obj1 = new Class2(1, 2);
            Class2 obj2 = new Class2(1, 2);
            Class2 obj3 = new Class2(0, 0);
            obj3 = obj1 + obj2;
            Class2.Showvalues(obj3);
            Console.ReadLine();
        }
    }
}