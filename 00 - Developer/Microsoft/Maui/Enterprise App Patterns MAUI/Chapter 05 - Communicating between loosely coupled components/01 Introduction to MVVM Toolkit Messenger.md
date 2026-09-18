The `MVVM Toolkit IMessenger` interface describes the publish-subscribe pattern, allowing message-based communication between components that are inconvenient to link by object and type references. This mechanism allows publishers and subscribers to communicate without having a direct reference to each other, helping to reduce dependencies between components, while also allowing components to be independently developed and tested.

**Warning**:  .NET MAUI contains a built-in `MessagingCenter` class that’s no longer recommended for use. Use the `MVVM Toolkit Messenger` instead.

The `IMessenger` interface allows for multicast publish-subscribe functionality. This means that there can be multiple publishers that publish a single message, and there can be multiple subscribers listening to the same message. The image below illustrates this relationship:
![[Publisher-Subscriber.png]]
There are two implementations of the `IMessenger` interface that come with the `CommunityToolkit.Mvvm` package.  The `WeakReferenceMessenger` uses weak references which can result in easier cleanup for message subscribers. This is a good option if your subscribers do not have a clearly defined lifecycle. The `StrongReferenceMessenger` uses strong references which can result in better performance and a more clearly controlled lifetime of the subscription.  If you have a workflow with a very controlled lifetime (for example, a subscription that is bound to a page’s OnAppearing and OnDisappearing methods), the StrongReferenceManager may be a better option, if performance is a concern. Both of these implementations are available with default implementations ready to use by referencing either WeakReferenceMessenger.Default or StrongReferenceMessenger.Default.

**Note** While the IMessenger interface permits communication between loosely-coupled classes, it does not offer the only architectural solution to this issue. For example, communication between a view model and a view can also be achieved by the binding engine and through property change notifications. In addition, communication between two view models can also be achieved by passing data during navigation.

The eShop multi-platform app uses the WeakReferenceMessenger class to communicate between loosely coupled components. The app defines a single message named `AddProductMessage`. The `AddProductMessage` is published by the `CatalogViewModel` class when an item is added to the shopping basket. In return, the `CatalogView` class subscribes to the message and uses this to highlight the product adds with animation in response.

In the eShop multi-platform app, WeakReferenceMessenger is used to update the UI in response to an action occurring in another class. Therefore, messages are published from the thread that the class is executing on, with subscribers receiving the message on the same thread.

**Tip** Marshal to the UI or main thread when performing UI updates. If updates to user interfaces are not made on this thread, it can cause the application to crash or become unstable.

If a message that’s sent from a background thread is required to update the UI, process the message on the UI thread in the subscriber by invoking the `MainThread.BeginInvokeOnMainThread` method.

For more information about Messenger, see Messenger on the Microsoft Developer Center.