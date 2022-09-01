using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoStuff;



class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Wich interface do you wanna use?");
        string interfaceID = Console.ReadLine();
        interfaceID.ToLower();


        if (interfaceID == "dickey")
        {
            IDoThings myStuff = new DoDickey();
            myStuff.DoNothing();
            myStuff.DoSomething(12);
            myStuff.DoSomething("RIP");
        }
        else if (interfaceID == "hickey")
        {
            IDoThings myStuff = new DoHickey();
            myStuff.DoNothing();
            myStuff.DoSomething(12);
            myStuff.DoSomething("RIP");
        }
        else
        {
            Console.WriteLine("No correct interfacet. Program exits");
            Environment.Exit(0);
        }


    }
}

