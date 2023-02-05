namespace FluentCalc.Interfaces;

/// <summary>
/// Интерфейс операций
/// </summary>
public interface IOperation
{
    /// <summary>
    /// Рассчитать значение на основе предыдущего результата и текущего значения
    /// </summary>
    /// <param name="lastValue"></param>
    /// <param name="currentValue"></param>
    /// <returns></returns>
    public int Calculate(int lastValue, int currentValue);
}
