namespace FluentCalc.Calculator;

public class MultiplyOperation : IOperation
{
    public int Calculate(int lastValue, int currentValue)
        => lastValue * currentValue;
}
