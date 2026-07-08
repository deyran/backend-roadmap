All `view model` and `model` classes that are accessible to a `view` should implement the [[INotifyPropertyChanged]] interface. Implementing this interface in a view model or model class allows the class to provide change notifications to any data-bound controls in the view when the underlying property value changes.

App’s should be architected for the correct use of property change notification, by meeting the following requirements:

- Always raising a PropertyChanged event if a public property’s value changes. Do not assume that raising the PropertyChanged event can be ignored because of knowledge of how XAML binding occurs.
- Always raising a PropertyChanged event for any calculated properties whose values are used by other properties in the view model or model.
- Always raising the PropertyChanged event at the end of the method that makes a property change, or when the object is known to be in a safe state. Raising the event interrupts the operation by invoking the event’s handlers synchronously. If this happens in the middle of an operation, it might expose the object to callback functions when it is in an unsafe, partially updated state. In addition, it’s possible for cascading changes to be triggered by PropertyChanged events. Cascading changes generally require updates to be complete before the cascading change is safe to execute.
- Never raising a PropertyChanged event if the property does not change. This means that you must compare the old and new values before raising the PropertyChanged event.
- Never raising the PropertyChanged event during a view model’s constructor if you are initializing a property. Data-bound controls in the view will not have subscribed to receive change notifications at this point.
- Never raising more than one PropertyChanged event with the same property name argument within a single synchronous invocation of a public method of a class. For example, given a NumberOfItems property whose backing store is the `_numberOfItems` field, if a method increments `_numberOfItems` fifty times during the execution of a loop, it should only raise property change notification on the NumberOfItems property once, after all the work is complete. For asynchronous methods, raise the PropertyChanged event for a given property name in each synchronous segment of an asynchronous continuation chain.

A simple way to provide this functionality would be to create an extension of the BindableObject class. In this example, the ExtendedBindableObject class provides change notifications, which is shown in the following code example:

```
public abstract class ExtendedBindableObject : BindableObject
{
    public void RaisePropertyChanged<T>(Expression<Func<T>> property)
    {
        var name = GetMemberInfo(property).Name;
        OnPropertyChanged(name);
    }

    private MemberInfo GetMemberInfo(Expression expression)
    {
        // Omitted for brevity ...
    }
}
```
.NET MAUI’s BindableObject class implements the INotifyPropertyChanged interface, and provides an OnPropertyChanged method. The ExtendedBindableObject class provides the RaisePropertyChanged method to invoke property change notification, and in doing so uses the functionality provided by the BindableObject class.

View model classes can then derive from the ExtendedBindableObject class. Therefore, each view model class uses the RaisePropertyChanged method in the ExtendedBindableObject class to provide property change notification. The following code example shows how the eShop multi-platform app invokes property change notification by using a lambda expression:

```
public bool IsLogin
{
    get => _isLogin;
    set
    {
        _isLogin = value;
        RaisePropertyChanged(() => IsLogin);
    }
}
```
Using a lambda expression in this way involves a small performance cost because the lambda expression has to be evaluated for each call. Although the performance cost is small and would not typically impact an app, the costs can accrue when there are many change notifications. However, the benefit of this approach is that it provides compile-time type safety and refactoring support when renaming properties.