namespace FactoryPattern;
public class ConcreteCreator2 : Creator
{
    public override IProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public override IProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}
