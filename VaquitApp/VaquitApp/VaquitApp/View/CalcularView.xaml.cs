using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaquitApp.Commons;
using VaquitApp.IViewModel;
using VaquitApp.Model;
using VaquitApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VaquitApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcularView : ContentPage
    {
        private ICalcularViewModel vm;
        public CalcularView(ObservableRangeCollection<Integrante> Integrantes)
        {
            InitializeComponent();
            BindingContext = vm = new CalcularViewModel(Integrantes);

            ListaIntegrantes.ItemsSource = vm.Integrantes;
        }
    }
}