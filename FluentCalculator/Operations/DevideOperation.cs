namespace FluentCalc.Calculator;

public class DevideOperation : IOperation
{
    public int Calculate(int lastValue, int currentValue)
        => lastValue / currentValue;
}
