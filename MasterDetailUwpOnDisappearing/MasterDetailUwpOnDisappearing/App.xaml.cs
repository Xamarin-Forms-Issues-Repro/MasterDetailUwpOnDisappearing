using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MasterDetailUwpOnDisappearing.Services;
using MasterDetailUwpOnDisappearing.Views;

namespace MasterDetailUwpOnDisappearing
{
	public partial class App : Application
	{

		public MainPage MasterDetailPage { get; set; }

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new NavigationPage(new StartPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
