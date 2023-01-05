namespace FactoryPattern;
    public class ConcreteCreator2 : SimpleBurgerFactory
    {
        public override IBruger FactoryMethod() 
        {
            return new VeggieBurger();
        }
    }
