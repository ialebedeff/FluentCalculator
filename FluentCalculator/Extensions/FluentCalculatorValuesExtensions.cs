namespace FluentCalc.Calculator;

public static class FluentCalculatorValuesExtensions
{
    public static FluentCalculator One(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 1);
    public static FluentCalculator Two(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 2);
    public static FluentCalculator Three(this FluentCalculator fluentCalculator)
      => InsertValue(fluentCalculator, 3);
    public static FluentCalculator Four(this FluentCalculator fluentCalculator)
       => InsertValue(fluentCalculator, 4);
    public static FluentCalculator Five(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 5);
    public static FluentCalculator Six(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 6);
    public static FluentCalculator Seven(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 7);
    public static FluentCalculator Eight(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 8);
    public static FluentCalculator Nine(this FluentCalculator fluentCalculator)
       => InsertValue(fluentCalculator, 9);
    public static FluentCalculator Ten(this FluentCalculator fluentCalculator)
        => InsertValue(fluentCalculator, 10);
    public static FluentCalculator Zero(this FluentCalculator fluentCalculator)
       => InsertValue(fluentCalculator, 0);
    private static FluentCalculator InsertValue(FluentCalculator fluentCalculator, int value)
    {
        if (fluentCalculator.Operations.Any(operation => operation.Value is null))
            throw new InvalidOperationException("Невозможно вставить несколько значений подряд, не применяя операцию");

        fluentCalculator.Operations.Add(new KeyValuePair<int, IOperation?>(value, null));

        return fluentCalculator;
    }
}
