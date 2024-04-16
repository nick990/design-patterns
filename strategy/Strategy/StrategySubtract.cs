using StrategyPattern;

public class StrategySubtract : IStrategy
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}