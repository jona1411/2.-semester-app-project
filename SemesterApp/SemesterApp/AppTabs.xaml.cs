﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace SemesterApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppTabs : TabbedPage
    {
        public AppTabs ()
        {
            InitializeComponent();
            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            //var NavigationPage = new NavigationPage(new Oversigt());
            //NavigationPage.Icon = "guide.png";
            this.Children.Add(new Oversigt());
            this.Children.Add(new Træning());
            this.Children.Add(new Vejledning());

        }
    }
}