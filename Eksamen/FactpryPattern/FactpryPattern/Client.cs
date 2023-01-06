

namespace FactoryPattern;
public class Client
{

<<<<<<< Updated upstream
        public void ClientCode(Creator creator) 
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.Operation1());
        }
=======
    public void ClientCode(Creator creator)
    {
        Console.WriteLine("Client: I'm not aware of the creator's class," +
            "but it still works.\n" + creator.Operation());
>>>>>>> Stashed changes
    }
}

