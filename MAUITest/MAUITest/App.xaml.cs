﻿namespace MAUITest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //var navPage = new NavigationPage(new ContentPageDemo());
        //navPage.BarBackgroundColor = Colors.Chocolate;
        //navPage.BarTextColor = Colors.White;
        //navPage.Title = "DEMO MAUI";
        //MainPage = navPage;

        MainPage = new NavigationPage(new FlyoutPageDemo());

    }
}
