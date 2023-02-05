namespace FluentCalc.Extensions;

public static class FluentCalculatorOperationsExtension
{
    /// <summary>
    /// Операция сложения
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Plus(this FluentCalculator fluentCalculator)
        => InsertOperation<PlusOperation>(fluentCalculator, new PlusOperation());
    /// <summary>
    /// Операция вычитания
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Minus(this FluentCalculator fluentCalculator)
        => InsertOperation<MinusOperation>(fluentCalculator, new MinusOperation());
    /// <summary>
    /// Оперция деления
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Devide(this FluentCalculator fluentCalculator)
        => InsertOperation<DevideOperation>(fluentCalculator, new DevideOperation());
    /// <summary>
    /// Оперция умножения
    /// </summary>
    /// <param name="fluentCalculator"></param>
    /// <returns></returns>
    public static FluentCalculator Multiply(this FluentCalculator fluentCalculator)
        => InsertOperation<MultiplyOperation>(fluentCalculator, new MultiplyOperation());

    /// <summary>
    /// Добавить операцию в коллекцию 
    /// </summary>
    /// <typeparam name="TOperation">Тип операции</typeparam>
    /// <param name="fluentCalculator">Калькулятор</param>
    /// <param name="operation">Операция</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">Указано несколько операций подряд или операция перед первым значением</exception>
    private static FluentCalculator InsertOperation<TOperation>(FluentCalculator fluentCalculator, TOperation operation) where TOperation : IOperation
    {
        if (fluentCalculator.Operations.Count is 0)
        {
            throw new InvalidOperationException("Невозможно применить операцию перед значением.");
        }

        if (fluentCalculator.Operations.All(operation => operation.Value is not null))
        {
            throw new InvalidOperationException("Невозможно применить несколько операций к одному значению.");
        }

        fluentCalculator.Operations[fluentCalculator.Operations.Count - 1]
            = new KeyValuePair<int, IOperation?>(
                fluentCalculator.Operations.Last().Key, operation);

        return fluentCalculator;
    }
}

