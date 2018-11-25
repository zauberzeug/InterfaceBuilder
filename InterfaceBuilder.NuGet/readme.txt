InterfaceBuilder is an hepful API to write Xamarin.Forms user interfaces directly in sourcecode. 
It's heavly relying on the builder pattern. So you can write:

var ui = new UI();

MainPage = ui.Page("MainPage", ui.Stack().With(
  ui.Label("A"), 
  ui.Label("B"), 
  ui.Label("C"))
);

This package is used in several projects at Perpetual Mobile, licensed under APACHE LICENSE and is hopefully
usefull to you.

