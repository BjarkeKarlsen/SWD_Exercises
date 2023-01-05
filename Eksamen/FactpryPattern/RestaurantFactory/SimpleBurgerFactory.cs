

namespace FactoryPattern;
    public abstract class SimpleBurgerFactory
    {

        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract Burger FactoryMethod();

        public Burger CreateBurger() {
            // Call the factory method to create a Product object.
            var product = new Burger();
            // Now, use the product.

            return product;
        }


    }

