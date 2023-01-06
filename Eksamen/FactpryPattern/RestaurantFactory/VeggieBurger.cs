namespace FactoryPattern;
public class VeggieBurger : Burger
{
    bool Combo { get; set; }

    public VeggieBurger()
    {
        Combo = false;
    }

    public override void Prepare()
    {
        if (Combo)
        {
            Console.WriteLine("Prepare veggie burger");
        }
        else
        {
            Console.WriteLine("Prepare combo veggie burger");
        }

    }
}
