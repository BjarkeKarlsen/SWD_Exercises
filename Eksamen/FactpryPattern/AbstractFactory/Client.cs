

namespace FactoryPattern;
public class Client
{

    public void ClientCode(Creator creator)
    {
        Console.WriteLine("Client: I'm not aware of the creator's class," +
            "but it still works.\n" + creator.Operation());
    }
}

