namespace MauiApp1.MVVM.Views;
using MauiApp1.MVVM.ViewModel;

public partial class MonitorView : ContentPage
{
	public MonitorView()
	{
		InitializeComponent();
		BindingContext = new MonitorViewModel();
	}
}