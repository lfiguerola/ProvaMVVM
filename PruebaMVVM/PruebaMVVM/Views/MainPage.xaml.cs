using PruebaMVVM.ViewModels;
using Xamarin.Forms;

namespace PruebaMVVM.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new ViewModel();
		}
	}
}
