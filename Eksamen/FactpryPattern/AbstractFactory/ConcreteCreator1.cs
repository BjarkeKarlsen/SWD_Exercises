using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;
public class ConcreteCreator1 : Creator
{
    // Note that the signature of the method still uses the abstract product
    // type, even though the concrete product is actually returned from the
    // method. This way the Creator can stay independent of concrete product
    // classes.
    public override IProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public override IProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}
