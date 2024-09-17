using ExamenII.ViewModels;
using ExamenII.Views;

namespace ExamenII.Views;

public partial class DescuentosView : ContentPage
{
	private DescuentosViewModel ViewModel;
	public DescuentosView()
	{
		InitializeComponent();
		ViewModel = new DescuentosViewModel();
		BindingContext = ViewModel;
	}
}