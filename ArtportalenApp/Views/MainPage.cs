﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtportalenApp.DependencyInjection;
using ArtportalenApp.Interfaces;
using ArtportalenApp.ViewModels;
using Autofac;
using Xamarin.Forms;

namespace ArtportalenApp.Views
{
    public class MainPage : MasterDetailPage, IViewModelAware<MainViewModel>, IMasterDetailNavigation
    {
        private IPageFactory _pageFactory;

        public MainPage()
        {
            _pageFactory = AutofacContainer.Container.Resolve<IPageFactory>();

            Master = _pageFactory.CreatePage<MenuPage, MenuViewModel>(setAction: vm => { vm.MasterNavigation = this; });
            Detail = new NavigationPage(_pageFactory.CreatePage<SightingsPage, SightingsViewModel>(
                setAction: vm => { vm.Title = "Obsar"; }));
        }


        public MainViewModel ViewModel { get; set; }

        public void SetDetail<TPage, TViewModel>(Action<TViewModel> setAction = null) 
            where TPage : Page, IViewModelAware<TViewModel>, new() 
            where TViewModel : class, IViewModel
        {
            Detail = new NavigationPage(_pageFactory.CreatePage<TPage, TViewModel>(setAction));
            IsPresented = false;
        }
    }
}
