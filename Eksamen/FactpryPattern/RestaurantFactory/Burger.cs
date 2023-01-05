
namespace FactoryPattern;
    // The Product interface declares the operations that all concrete products
    // must implement.
    public abstract class Burger
    {
        protected int productId;
        protected string? addOns;
        public virtual void  Prepare() {
            Console.WriteLine("Prepare normal burger");
        }
    }
