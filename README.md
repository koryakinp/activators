# activators
Artificial Neural Networks Activation Functions

1. Rectified Linear Unit (ReLU)
2. Logistic Sigmoid
3. Hyperbolic Tangent

## Installing

```
PM> Install-Package activators.koryakinp
```

## Example
```
var activator = ActivatorFactory.Produce(ActivatorType.Relu);
var x = activator.CalculateValue(3.5);
var dx = activator.CalculateDeriviative(3.5);
```
## Authors

Pavel koryakin <koryakinp@koryakinp.com>

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/koryakinp/activators/blob/master/LICENSE) for details.
