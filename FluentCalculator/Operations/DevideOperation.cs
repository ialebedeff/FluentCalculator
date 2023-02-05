namespace FluentCalc.Operations;

/// <summary>
/// Деление
/// </summary>
public class DevideOperation : IOperation
{
    /// <summary>
    /// Поделить последний результат на текущее значение
    /// </summary>
    /// <param name="lastValue"></param>
    /// <param name="currentValue"></param>
    /// <returns></returns>
    public int Calculate(int lastValue, int currentValue)
        => lastValue / currentValue;
}
