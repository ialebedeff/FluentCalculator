# FluentCalculator
SourceWork - Может ли переменная быть одновременно True и False?
Определите someBool так, чтобы следующее выражение возвращало true:
someBool == true && someBool == false

FluentCalculator - Implement a simple calculator with fluent syntax

```
var FluentCalculator = /* Some magic */;
```

FluentCalculator should be separated in two, the Values and the Operations, one can call the other, but cannot call one of his own.

A Value can call an Operation, but cannot call a value

```
FluentCalculator.one.plus
FluentCalculator.one.one // error or "undefined", it's up to you.
```

An Operation can call a Value, but cannot call a operation

```
FluentCalculator.one.plus.two // this should have a value of 3
FluentCalculator.one.plus.plus // error or "undefined", it's up to you
```

Pairs of Value and Operation should be stackable to infinity

```
FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four // Should be -1
```

A Value should resolve to a primitive integer

```
FluentCalculator.one.plus.ten - 10 // Should be 1
```

Rules:

* Values in FluentCalculator should go from zero to ten.
* Supported Operations are plus, minus, times, dividedBy
* Rules mentioned above
* FluentCalculator should be stackable to infinity
* A Value can only call an Operation
* An Operation can only call a Value
* A Value should be resolvable to a primitive integer, if needed as such



Реализовать простой калькулятор с плавным синтаксисом

```
var FluentCalculator = /* Какая-то магия */;
```

FluentCalculator должен быть разделен на две части: значения и операции, один может вызывать другой, но не может вызывать один из своих собственных.

Значение может вызывать операцию, но не может вызывать значение

```
FluentCalculator.one.plus
FluentCalculator.one.one // ошибка или "не определено", решать вам.
```

Операция может вызывать значение, но не может вызывать операцию

```
FluentCalculator.one.plus.two // это должно иметь значение 3
Беглый калькулятор.один.плюс.плюс // ошибка или "не определено", это зависит от вас
```

Пары значения и операции должны быть штабелируемыми до бесконечности

```
Беглый калькулятор.один.плюс.два.плюс.три.минус.один.минус.два.минус.четыре // Должно быть равно -1
```

Значение должно преобразовываться в примитивное целое число

```
FluentCalculator.one.plus.ten - 10 // Должно быть 1
```

Правила:

* Значения в FluentCalculator должны быть от нуля до десяти.
* Поддерживаемые операции - плюс, минус, умножение, деление на
* Правила, упомянутые выше
