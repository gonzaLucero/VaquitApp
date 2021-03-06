﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaquitApp.IViewModel;
using VaquitApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VaquitApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarIntegranteView : ContentPage
    {
        private IAgregarIntegranteViewModel vm;
        
        public AgregarIntegranteView()
        {
            InitializeComponent();
            BindingContext = vm = new AgregarIntegranteViewModel();
            vm.Navigation = Navigation;

            ListaIntegrantes.ItemsSource = vm.Integrantes;
            ListaIntegrantes.ItemTapped += ListaIntegrantes_ItemTapped;
        }

        private void ListaIntegrantes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            ((ListView)sender).SelectedItem = null;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            aporteEntry.Text = string.Empty;
            aporteEntry.Focus();
        }

        private void aporteEntry_Completed(object sender, EventArgs e)
        {
            vm.AgregarIntegranteCommand.Execute(null);
        }
    }
}