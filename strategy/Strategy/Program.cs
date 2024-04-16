using StrategyPattern;

int a = 5;
int b = 2;
Console.WriteLine($"a = {a}, b = {b}");

var context = new Context(new StrategySum());
var result = context.ExecuteStrategy(a, b);
Console.Write($"Sum: {result}");

context.SetStrategy(new StrategyMultiply());
result = context.ExecuteStrategy(a, b);
Console.Write($"\nMultiply: {result}");

context.SetStrategy(new StrategySubtract());
result = context.ExecuteStrategy(a, b);
Console.Write($"\nSubtract: {result}");