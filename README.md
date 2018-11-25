# InterfaceBuilder

InterfaceBuilder is a handy wrapper around Xamrin.Forms to simplify writing UI definitins in directly in C#.

It's heavly relying on the builder pattern. So you can write:

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
