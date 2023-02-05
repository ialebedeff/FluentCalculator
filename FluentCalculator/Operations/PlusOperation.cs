namespace FluentCalc.Calculator;

/// <summary>
/// Сложение
/// </summary>
public class PlusOperation : IOperation
{
    /// <summary>
    /// Сложить предыдущий результат с текущим значением
    /// </summary>
    /// <param name="lastValue"></param>
    /// <param name="currentValue"></param>
    /// <returns></returns>
    public int Calculate(int lastValue, int currentValue)
        => lastValue + currentValue;
}
