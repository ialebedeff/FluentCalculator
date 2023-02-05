namespace FluentCalc.Calculator;

/// <summary>
/// Калькулятор
/// </summary>
public class FluentCalculator
{
    /// <summary>
    /// Список операций и значений
    /// </summary>
    public List<KeyValuePair<int, IOperation?>> Operations { get; set; } = new();

    /// <summary>
    /// Получить результат вычислений
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public int? Result()
    {
        if (Operations.Count is 0)
        {
            throw new InvalidOperationException("Не правильное количество операций");
        }

        int? result = Operations.First().Key;

        for (int i = 0; i < Operations.Count; i += 1)
        {
            if (i + 1 < Operations.Count)
            {
                result = Operations[i].Value?.Calculate(result ?? 0, Operations[i + 1].Key);
            }
        }

        return result % 10;
    }
}