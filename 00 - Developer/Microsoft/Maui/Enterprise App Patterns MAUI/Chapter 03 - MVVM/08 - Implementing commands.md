## Core Purpose

- Exposes  actions from the *ViewModel* to the View without code-behind
- Encapsulates the actions logic, ensuring platform portability and decoupling from the UI

## Public exposure Best Practice

- Exposes commands publicly as the *ICommand* interface
- Allows the underlying concrete implementation to be easily changed later without breaking the View

## The ICommand Interface Components

- `Execute()`: Encapsulates the operation/action itself
- `CanExecute()`: Determines if the command is currently allowed to run (optional, defaults to true)
- `CanExecuteChanged()`: An event triggered when conditions change that effect  whether the command should execute

## Command Implementations

- **Standard .Net Maui**: `Command` and `Command<T>` (basic, minimal functionality)
- **eShop Reference App**: Uses `RelayCommand` and `AsyncRelayCommand` from the *.NET Community MVVM Toolkit*
	- **Advantage**: `AsyncRelayCommand` offers superior functionality for modern asynchronous operations using `async / await` keywords.
## Handling Parameters & State Changes

- **Passing Parameters**: Handled via generic classes like `AsyncRelayCommand<T>`
	```
	public ICommand NavigateCommand { get; } 
	
	... 
	
	NavigateCommand = new AsyncRelayCommand<string>(NavigateAsync);
	```
- **Updating UI Availability**: Call `ChangeCanExecute()` on the command object to fire the `CanExecuteChanged` event , which automatically updates the enable / disabled status of bound UI controls