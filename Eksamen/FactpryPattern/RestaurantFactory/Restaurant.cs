

namespace FactoryPattern;
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
    }

