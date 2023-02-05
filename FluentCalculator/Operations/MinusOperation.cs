namespace FluentCalc.Operations;

/// <summary>
/// Вычитание
/// </summary>
public class MinusOperation : IOperation
{
    /// <summary>
    /// Вычесть из последнего результата текущее значение
    /// </summary>
    /// <param name="lastValue"></param>
    /// <param name="currentValue"></param>
    /// <returns></returns>
    public int Calculate(int lastValue, int currentValue)
        => lastValue - currentValue;
}
