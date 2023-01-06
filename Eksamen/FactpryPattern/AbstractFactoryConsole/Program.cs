using FactoryPattern;

var client = new Client();
Console.WriteLine("App: Launched with the ConcreteCreator1.");
client.ClientCode(new ConcreteCreator1());

Console.WriteLine("");

Console.WriteLine("App: Launched with the ConcreteCreator2.");
client.ClientCode(new ConcreteCreator2());