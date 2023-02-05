namespace FluentCalc.Calculator;

public static class FluentCalculatorOperationsExtension
{
    public static FluentCalculator Plus(this FluentCalculator fluentCalculator)
        => InsertOperation<PlusOperation>(fluentCalculator, new PlusOperation());
    public static FluentCalculator Minus(this FluentCalculator fluentCalculator)
        => InsertOperation<MinusOperation>(fluentCalculator, new MinusOperation());
    public static FluentCalculator Devide(this FluentCalculator fluentCalculator)
        => InsertOperation<DevideOperation>(fluentCalculator, new DevideOperation());
    public static FluentCalculator Multiply(this FluentCalculator fluentCalculator)
        => InsertOperation<MultiplyOperation>(fluentCalculator, new MultiplyOperation());

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
