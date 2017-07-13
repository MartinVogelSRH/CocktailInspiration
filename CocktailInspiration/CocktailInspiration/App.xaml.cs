﻿using CocktailInspiration.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace CocktailInspiration
{
	public partial class App : Application
	{
		public static DatabaseContext _db;
		public App()
		{
			InitializeComponent();
			//MainPage = new NavigationPage(new MainPageMasterDetail());
			MainPage = new MainPageMasterDetail();
			//MainPage = new MainPage();
			_db = new DatabaseContext();
			_db.Database.EnsureCreated();
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