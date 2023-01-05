
using StrategyPattern_TemplateMethodPattern.StrategyPattern;

var words = new List<string> { "a", "b", "c", "d", "e" };


Console.WriteLine("Creating a Context with the StrategySort strategy");
var context = new Context(new StrategySort());


Console.WriteLine("Executing the strategy");
context.ExecuteStrategy(words);


Console.WriteLine("Strategy is now set to StrategyReverseSort");
context.SetStrategy(new StrategyReverseSort());

Console.WriteLine("Executing the strategy");
context.ExecuteStrategy(words);