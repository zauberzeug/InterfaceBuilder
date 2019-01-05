InterfaceBuilder is a handy wrapper around Xamrin.Forms to improve the writing 
of user interface code directly in C# (no XAML).

It's a combination of factory pattern and the builder pattern. So you can write:


var ui = new UI();

MainPage = ui.Page("MainPage", ui.Stack().Vertical().With(
  ui.Label("A"),
  ui.Label("B"),
  ui.Label("C"))
);


This package is used in several projects at Perpetual Mobile, licensed under APACHE LICENSE and is hopefully
useful to you.

We have no proper documentation jet but provide some examples in the Demo project. Have a look at our GitHub site.