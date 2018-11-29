using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class MyHelperClass
    {
        public string MyHelperMethod (string str1, string str2)
        {
            return str1 + str2;
        }

        public int MyCustomMethod (string name, int nameLength)
        {
            if (MyHelperMethod(name,name).Length == nameLength)
            {
                return nameLength;
            }
            else
            {
                return MyHelperMethod(name, name).Length;
            }
        }

        public int MyUniqueMethod (int num1)
        {
            var str = "Hello";
            var result = MyCustomMethod(str, num1);
            return num1 + result;
        }
    }
}
