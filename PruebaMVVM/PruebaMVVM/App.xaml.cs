using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PruebaMVVM
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //Same as App.xaml resource dictionary (need using...)
            //Resources.Add("ConverterQueToca", new StringToColorConverter());

			MainPage = new Views.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
