﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PostCommentsAssessment());
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
