using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class UniqueUtils
    {
        public string MyUtilMethod(string str1, string str2)
        {
            return str1 + str2;
        }

        public int MyCustomUtil(string name, int nameLength)
        {
            if (MyUtilMethod(name, name).Length == nameLength)
            {
                return nameLength;
            }
            else
            {
                return MyUtilMethod(name, name).Length;
            }
        }

        public int MyRandomUtil(int num1)
        {
            var str = "Hello";
            var result = MyCustomUtil(str, num1);
            return num1 + result;
        }
    }
}
