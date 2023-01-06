
namespace FactoryPattern;
<<<<<<< Updated upstream
    // The Product interface declares the operations that all concrete products
    // must implement.
    public abstract class Burger
=======
// The Product interface declares the operations that all concrete products
// must implement.
public abstract class Burger
{
    protected int productId;
    protected string? addOns;
    public virtual void Prepare()
>>>>>>> Stashed changes
    {
        Console.WriteLine("Prepare normal burger");
    }
}
