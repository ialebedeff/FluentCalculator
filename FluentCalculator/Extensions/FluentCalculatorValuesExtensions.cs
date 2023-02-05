namespace FluentCalc.Extensions;

public static class FluentCalculatorValuesExtensions
{
    /// <summary>
    /// Один. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator One(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 1);
    /// <summary>
    /// Два. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Two(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 2);
    /// <summary>
    /// Три. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Three(this FluentCalculator fluentCalculator)
      => InsertValue(fluentCalculator, 3);
    /// <summary>
    /// Четыре. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Four(this FluentCalculator fluentCalculator)
       => InsertValue(fluentCalculator, 4);
    /// <summary>
    /// Пять. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Five(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 5);
    /// <summary>
    /// Шесть. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Six(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 6);
    /// <summary>
    /// Семь. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Seven(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 7);
    /// <summary>
    /// Восемь. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Eight(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 8);
    /// <summary>
    /// Девять. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Nine(this FluentCalculator fluentCalculator)
       => InsertValue(fluentCalculator, 9);
    /// <summary>
    /// Десять. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Ten(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 10);
    /// <summary>
    /// Ноль. Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Zero(this FluentCalculator fluentCalculator)
       => InsertValue(fluentCalculator, 0);

    /// <summary>
    /// Добавляет значение в коллекцию для дальнейшего рассчёта
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">Если несколько значений подряд</exception>
    private static FluentCalculator InsertValue(FluentCalculator fluentCalculator, int value)
    {
        if (fluentCalculator.Operations.Any(operation => operation.Value is null))
            throw new InvalidOperationException("Невозможно вставить несколько значений подряд, не применяя операцию");

        fluentCalculator.Operations.Add(new KeyValuePair<int, IOperation?>(value, null));

        return fluentCalculator;
    }
}
