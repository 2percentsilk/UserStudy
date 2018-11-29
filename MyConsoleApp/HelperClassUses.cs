using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class HelperClassUses
    {
        public int DoStuff(int number)
        {
            var custom = new MyHelperClass();
            custom.MyCustomMethod("hello", 5);
            custom.MyCustomMethod("goodbye", 10);
            if (custom.MyHelperMethod("hello","goodbye") == "hellogoodbye")
            {
                return custom.MyUniqueMethod(5);
            }
            else
            {
                return 1;
            }
        }

        public int TryStuff(int number)
        {
            var custom = new UniqueUtils();
            custom.MyCustomUtil("hello", 5);
            custom.MyCustomUtil("goodbye", 10);
            if (custom.MyUtilMethod("hello", "goodbye") == "hellogoodbye")
            {
                return custom.MyRandomUtil(5);
            }
            else
            {
                return 1;
            }

            if (custom.MyUtilMethod("hello", "goodbye") == "hellogoodbye")
            {
                return custom.MyRandomUtil(5);
            }
            else
            {
                return 1;
            }
        }
        public int TryMoreStuff(int number)
        {
            var custom = new UniqueUtils();
            custom.MyCustomUtil("hello", 5);
            custom.MyCustomUtil("goodbye", 10);

            if (custom.MyUtilMethod("hello", "goodbye") == "hellogoodbye")
            {
                return custom.MyRandomUtil(5);
            }
            else
            {
                return 1;
            }
        }
    }
}
