namespace FactoryPattern;
<<<<<<< Updated upstream
    public class BeefBurger : Burger
    {
        public override void Prepare() 
        {
            Console.WriteLine("Prepare beef burger");
=======
public class BeefBurger : Burger
{
    bool Angus { get; set; }


    public BeefBurger()
    {
        Angus = false;
    }

    public override void Prepare()
    {
        if (Angus)
        {
            Console.WriteLine("Prepare normal burger");
        }
        else
        {
            Console.WriteLine("Prepare angus burger");
>>>>>>> Stashed changes
        }
    }
}
