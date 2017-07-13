using CocktailInspiration.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CocktailInspiration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TechnicalPage : ContentPage
	{
		public TechnicalPage ()
		{
			InitializeComponent ();
		}

        private void btn_AddData_Clicked(object sender, EventArgs e)
        {
            DataTests.GenerateData();
        }

        private void btn_DropDatabase_Clicked(object sender, EventArgs e)
        {
            DataTests.DropDB();
        }
    }
}