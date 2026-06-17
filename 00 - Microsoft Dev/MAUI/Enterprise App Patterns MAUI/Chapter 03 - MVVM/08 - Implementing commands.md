View models typically expose public properties, for binding from the view, which implement the `ICommand` interface. Many .NET MAUI controls and gestures provide a Command property, which can be data bound to an ICommand object provided by the view model. The button control is one of the most commonly used controls, providing a command property that executes when the button is clicked.

The ICommand interface defines an Execute method, which encapsulates the operation itself, a CanExecute method, which indicates whether the command can be invoked, and a CanExecuteChanged event that occurs when changes occur that affect whether the command should execute. In most cases, we will only supply the Execute method for our commands. For a more detailed overview of ICommand, refer to the Commanding documentation for .NET MAUI.

Provided with .NET MAUI are the Command and `Command<T>` classes that implement the ICommand interface, where T is the type of the arguments to Execute and CanExecute. Command and `Command<T>` are basic implementations that provide the minimal set of functionality needed for the ICommand interface.

The Command or `Command<T>` constructor requires an Action callback object that’s called when the ICommand.Execute method is invoked. The CanExecute method is an optional constructor parameter, and is a Func that returns a bool.

The eShop multi-platform app uses the *RelayCommand* and *AsyncRelayCommand*. The primary benefit for modern applications is that the *AsyncRelayCommand* provides better functionality for asynchronous operations.

The following code shows how a Command instance, which represents a register command, is constructed by specifying a delegate to the Register view model method:
```
public ICommand RegisterCommand { get; }
```
The command is exposed to the view through a property that returns a reference to an ICommand. When the Execute method is called on the Command object, it simply forwards the call to the method in the view model via the delegate that was specified in the Command constructor. An asynchronous method can be invoked by a command by using the async and await keywords when specifying the command’s Execute delegate. This indicates that the callback is a Task and should be awaited. For example, the following code shows how an ICommand instance, which represents a sign-in command, is constructed by specifying a delegate to the SignInAsync view model method:
```
public ICommand SignInCommand { get; } ... SignInCommand = new AsyncRelayCommand(async () => await SignInAsync());
```


