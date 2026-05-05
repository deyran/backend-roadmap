# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> View

The view is responsible for defining the structure, layout, and appearance of what the user sees on screen. Ideally, each view is defined in XAML, with a limited code-behind that does not contain business logic. However, in some cases, the code-behind might contain UI logic that implements visual behavior that is difficult to express in XAML, such as animations.

In a .NET MAUI application, a view is typically a ContentPage-derived or ContentView-derived class. However, views can also be represented by a data template, which specifies the UI elements to be used to visually represent an object when it’s displayed. A data template as a view does not have any code-behind, and is designed to bind to a specific view model type.

Ensure that the view models are responsible for defining logical state changes that affect some aspects of the view’s display, such as whether a command is available, or an indication that an operation is pending. Therefore, enable and disable UI elements by binding to view model properties, rather than enabling and disabling them in code-behind.

There are several options for executing code on the view model in response to interactions on the view, such as a button click or item selection. If a control supports commands, the control’s Command property can be data-bound to an ICommand property on the view model. When the control’s command is invoked, the code in the view model will be executed. In addition to commands, behaviors can be attached to an object in the view and can listen for either a command to be invoked or the event to be raised. In response, the behavior can then invoke an ICommand on the view model or a method on the view model.