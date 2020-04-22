using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailUwpOnDisappearing
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{
		public StartPage()
		{
			InitializeComponent();
		
		}

		private void Button_OnClicked(object sender, EventArgs e)
		{
			var masterDetail = new Views.MainPage();
			if (Application.Current is App app)
				app.MasterDetailPage = masterDetail;
			
			Navigation.PushAsync(masterDetail);
		}
	}
}