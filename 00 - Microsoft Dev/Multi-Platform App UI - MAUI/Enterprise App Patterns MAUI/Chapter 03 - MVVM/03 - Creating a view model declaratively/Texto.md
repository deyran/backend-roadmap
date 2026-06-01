# Creating a view model declaratively

The simplest approach is for the view to declaratively instantiate its corresponding view model in XAML. When the view is constructed, the corresponding view model object will also be constructed. This approach is demonstrated in the following code example:
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