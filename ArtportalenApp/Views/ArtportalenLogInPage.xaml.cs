﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtportalenApp.Interfaces;
using ArtportalenApp.ViewModels;
using Xamarin.Forms;

namespace ArtportalenApp.Views
{
    public partial class ArtportalenLogInPage : ContentPage, IPage<ArtportalenLogInViewModel>
    {
        public ArtportalenLogInPage()
        {
            InitializeComponent();
        }

        public ArtportalenLogInViewModel ViewModel { get; set; }
    }
}
