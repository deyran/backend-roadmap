# Maui - Enterprise App - CH03 MVVM
## The MVVM Partten -> ViewModel

The ViewModel implements properties and commands to which the View can data bind to, and notifies the View of any state changes through change notification events. The properties and commands that the ViewModel provides define the functionality to be offered by the UI, but the View determines how that functionality is to be displayed.

*Tip: Keep the UI responsive with asynchronous operations.*

Multi-platform apps should keep the UI thread unblocked to improve the user’s perception of performance. Therefore, in the ViewModel, use asynchronous methods for I/O operations and raise events to asynchronously notify views of property changes.

The ViewModel is also responsible for coordinating the View’s interactions with any Model classes that are required. There’s typically a one-to-many relationship between the ViewModel and the Model classes. The ViewModel might choose to expose Model classes directly to the View so that controls in the View can data bind directly to them. In this case, the Model classes will need to be designed to support data binding and change notification events.

Each ViewModel provides data from a Model in a form that the View can easily consume. To accomplish this, the ViewModel sometimes performs data conversion. Placing this data conversion in the ViewModel is a good idea because it provides properties that the View can bind to. For example, the ViewModel might combine the values of two properties to make it easier to display by the view.

*Tip: Centralize data conversions in a conversion layer.*

It’s also possible to use converters as a separate data conversion layer that sits between the ViewModel and the View. This can be necessary, for example, when data requires special formatting that the ViewModel doesn’t provide.

In order for the ViewModel to participate in two-way data binding with the View, its properties must raise the PropertyChanged event. ViewModels satisfy this requirement by implementing the INotifyPropertyChanged interface, and raising the PropertyChanged event when a property is changed.

For collections, the view-friendly ObservableCollection<T> is provided. This collection implements collection changed notification, relieving the developer from having to implement the INotifyCollectionChanged interface on collections.