# InterfaceBuilder

InterfaceBuilder is a handy wrapper around Xamrin.Forms to improve the writing of user interface code directly in C# (no XAML).

It's a combination of factory pattern (see [UI.cs](https://github.com/perpetual-mobile/InterfaceBuilder/blob/master/InterfaceBuilder/UI.cs)) and the builder pattern (extension methods defined mainly in [ContentConfiguration.cs](https://github.com/perpetual-mobile/InterfaceBuilder/blob/master/InterfaceBuilder/ContentConfiguration.cs)). So you can write:

```csharp
var ui = new UI();

MainPage = ui.Page("MainPage", ui.Stack().Vertical().With(
  ui.Label("A"),
  ui.Label("B"),
  ui.Label("C"))
);
```

This package is used in several projects at Perpetual Mobile, licensed under APACHE LICENSE and is hopefully
useful to you.

We have no proper documentation jet but provide some examples in the Demo project. Have a look at [FundamentalsModule.cs](https://github.com/perpetual-mobile/InterfaceBuilder/blob/master/Demo/FundamentalsModule.cs) to see how we implemented this screen:

<img align="center" src="https://github.com/perpetual-mobile/InterfaceBuilder/raw/master/screenshot-fundamentals.png" width=350 />

And to see how to add images look at [ImageModule.cs](https://github.com/perpetual-mobile/InterfaceBuilder/blob/master/Demo/ImageModule.cs):

<img align="center" src="https://github.com/perpetual-mobile/InterfaceBuilder/raw/master/screenshot-supporting-images.png" width=350 />
