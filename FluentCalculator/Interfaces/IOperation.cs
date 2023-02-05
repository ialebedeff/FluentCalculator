namespace FluentCalc.Calculator;

public interface IOperation
{
    public int Calculate(int lastValue, int currentValue);
}
