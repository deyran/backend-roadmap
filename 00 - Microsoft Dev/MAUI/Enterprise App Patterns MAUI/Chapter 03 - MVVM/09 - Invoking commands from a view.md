The following code shows `LoginView` binds to the `RegisterCommand` in the `LoginViewModel` class
```
<Grid Grid.Column="1" HorizontalOptions="Center"> 
	<Label Text="REGISTER" TextColor="Gray"/> 
	
	<Grid.GestureRecognizers> 
		<TapGestureRecognizer 
			Command="{Binding RegisterCommand}" 
			NumberOfTapsRequired="1" /> 
	</Grid.GestureRecognizers> 
	
</Grid>
```