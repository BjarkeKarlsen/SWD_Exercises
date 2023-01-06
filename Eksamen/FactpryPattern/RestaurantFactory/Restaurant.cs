

namespace FactoryPattern;
<<<<<<< Updated upstream
    public class Restaurant
    {
        public Burger orderBurger(string request) {
        Burger burger = null;
        if ("BEEF".Equals(request)) {
            burger = new BeefBurger();
        }
        else if ("VEGGIE".Equals(request)) {
            burger = new VeggieBurger();
        }
        burger.Prepare();
        return burger;
    }
=======
public class Restaurant
{
    public Burger OrderBruger(string request)
    {
        Burger burger = null;
        request.ToUpper();

        switch (request)
        {
            case "BEEF":
                burger = new BeefBurger();
                break;
            case "VEGGIE":
                burger = new VeggieBurger();
                break;
        }


        burger.Prepare();

        return burger;
>>>>>>> Stashed changes
    }
}

