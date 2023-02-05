namespace FluentCalc.Calculator;

public class MinusOperation : IOperation
{
    public int Calculate(int lastValue, int currentValue)
        => lastValue - currentValue;
}
