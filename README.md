# InterfaceBuilder

InterfaceBuilder is a handy wrapper around Xamrin.Forms to simplify the writing of user interface code directly in C# (no XAML).

It's heavily relying on the builder pattern. So you can write:

```csharp
var ui = new UI();

MainPage = ui.Page("MainPage", ui.Stack().Vertical().With(
  ui.Label("A"),
  ui.Label("B"),
  ui.Label("C"))
);
```

This package is used in several projects at Perpetual Mobile, licensed under APACHE LICENSE and is hopefully
usefull to you.

We have no proper documentation jet but provide some examples in the Demo project. Have a look at [FundamentalsModule.cs](https://github.com/perpetual-mobile/InterfaceBuilder/blob/master/Demo/FundamentalsModule.cs) to see how we implemented this screen:

<img align="center" src="https://github.com/perpetual-mobile/InterfaceBuilder/raw/master/screenshot-fundamentals.png" width=350 />
