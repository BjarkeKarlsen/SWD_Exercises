namespace FactoryPattern;
    public class BeefBurger : Burger
    {
        public override void Prepare() 
        {
            Console.WriteLine("Prepare beef burger");
        }
    }
