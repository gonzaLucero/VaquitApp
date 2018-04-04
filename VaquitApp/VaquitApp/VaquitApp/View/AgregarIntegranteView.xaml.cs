using System;
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

            ListaIntegrantes.ItemsSource = vm.Integrantes;
            //ListaIntegrantes.ItemTapped += PedidosListView_ItemTapped;
        }
    }
}