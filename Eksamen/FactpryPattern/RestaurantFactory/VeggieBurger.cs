using FactpryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;
    public class VeggieBurger : Burger
    {
    public override void Prepare() {
        Console.WriteLine("Prepare veggie burger");
    }
}
