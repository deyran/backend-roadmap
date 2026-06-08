A view can have code in the code-behind file, resulting in the view-model being assigned to its BindingContext property. This is often accomplished in the view's constructor, as shown in the following code example:
		[[BindingContext]]
```
public LoginView() { 
	InitializeComponent(); 
	BindingContext = new LoginViewModel(navigationService); 
}
```
The programmatic construction and assignment of the view model within the view’s code-behind has the advantage that it’s simple. However, the main disadvantage of this approach is that the view needs to provide the view model with any required dependencies. Using a dependency injection container can help to maintain loose coupling between the view and view model. For more information, see Dependency injection.
