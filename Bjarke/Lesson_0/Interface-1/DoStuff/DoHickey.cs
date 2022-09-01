using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff
{
    public class DoHickey : IDoThings
    {
        public void DoNothing()
        {
            Console.WriteLine("Classname: DoHickey, Methodename: DoNothing, ");
        }

        public int DoSomething(int number)
        {
            Console.WriteLine("Classname: DoHickey, Methodename: DoSomething," + number);
            return number;
        }

        public string DoSomething(string input)
        {
            Console.WriteLine("Classname: DoHickey, Methodename: DoSomething," + input);
            return input;
        }
    }
}
