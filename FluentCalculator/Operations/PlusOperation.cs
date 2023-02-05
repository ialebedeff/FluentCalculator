namespace FluentCalc.Calculator;

public class PlusOperation : IOperation
{
    public int Calculate(int lastValue, int currentValue)
        => lastValue + currentValue;
}
