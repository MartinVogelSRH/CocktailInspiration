using CocktailInspiration.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CocktailInspiration
{
	public partial class App : Application
	{
		public static DatabaseContext _db;
		public App()
		{
            _db = new DatabaseContext();
            _db.Database.EnsureCreated();
            if (_db.Recipes.ToList().Count == 0)
            {
                Testing.DataTests.GenerateData();
            }
            InitializeComponent();
			//MainPage = new NavigationPage(new MainPageMasterDetail());
			MainPage = new MainPageMasterDetail();
			//MainPage = new MainPage();

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
