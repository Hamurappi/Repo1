using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_code_1
{
    class Test
    {
        public int a, b;
        public Test(int i, int j)
        {
            a = i; b = j;
        }
        // Передать объект. Теперь переменные ob.a и ob.b из объекта, используемого в вызове метода, будут изменены.

        public void Change(Test ob)
        {
            ob.a = ob.a + ob.b;
            ob.b = - ob.b;
        }
    }
    class CallByRef
    {
        static void Main(string[] args)
        {
            Test ob = new Test(15,20);
            Console.WriteLine("ob.a и ob.b до вызова: "+ob.a+" "+ob.b);
            ob.Change(ob);
            Console.WriteLine("a и b после вызова: " + ob.a + " " + ob.b);
        }
    }
}
