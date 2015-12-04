﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using ArtportalenApp.Interfaces;
using ArtportalenApp.ViewModels;
using Xamarin.Forms;

namespace ArtportalenApp.Views
{
    public partial class ChooseSingleSitePage : ContentPageBase<ChooseSingleSiteViewModel>, IViewModelAware<ChooseSingleSiteViewModel>
    {
        public ChooseSingleSitePage()
        {
            InitializeComponent();
        }

        public ChooseSingleSiteViewModel ViewModel { get; set; }
    }
}
