﻿using HackHeroesApp.ViewModels;
using HackHeroesApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HackHeroesApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
