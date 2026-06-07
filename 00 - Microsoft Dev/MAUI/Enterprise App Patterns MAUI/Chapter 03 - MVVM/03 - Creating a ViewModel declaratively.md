
The simplest approach is for the View to declaratively instantiate its corresponding ViewModel in XAML. When the View is constructed, the corresponding ViewModel object will also be constructed. This approach is demonstrated in the following code example:
	[[BindingContext]]
```
<ContentPage xmlns:local="clr-namespace:eShop">
    <ContentPage.BindingContext>
	    <local:LoginViewModel />
    </ContentPage.BindingContext>
    
    <!-- Omitted for brevity... -->
</ContentPage>
```
When the `ContentPage` is created, an instance of the `LoginViewModel` is automatically  constructed and set as the view's `BindingContext`.

This declarative construction and assignment of the view model by the view has the advantage that it's simple, but has the disadvantage that it requires a default (parameter-less) constructor in the view model.