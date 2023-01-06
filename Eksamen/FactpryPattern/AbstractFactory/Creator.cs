

namespace FactoryPattern;
public abstract class Creator
{

    // Note that the Creator may also provide some default implementation of
    // the factory method.
    public abstract IProductA CreateProductA();
    public abstract IProductB CreateProductB();



    // Also note that, despite its name, the Creator's primary
    // responsibility is not creating products. Usually, it contains some
    // core business logic that relies on Product objects, returned by the
    // factory method. Subclasses can indirectly change that business logic
    // by overriding the factory method and returning a different type of
    // product from it.

    public string Operation()
    {
        // Call the factory method to create a Product object.
        var productA = CreateProductA();
        var productB = CreateProductB();
        // Now, use the product.
        var result = "Creator: The same creator's code has just worked with "
            + productA.Operation() + productB.Operation();

        return result;
    }


}

