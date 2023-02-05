namespace FluentCalc.Calculator;

/// <summary>
/// Умножение
/// </summary>
public class MultiplyOperation : IOperation
{
    /// <summary>
    /// Умножить последний результат на текущее значение
    /// </summary>
    /// <param name="lastValue"></param>
    /// <param name="currentValue"></param>
    /// <returns></returns>
    public int Calculate(int lastValue, int currentValue)
        => lastValue * currentValue;
}
