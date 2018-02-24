using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaMVVM.ViewModels;
using Xamarin.Forms;

namespace PruebaMVVM
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
