using System;
using System.Threading.Tasks;
using System.Windows.Input;
using VaquitApp.Commons;
using VaquitApp.IViewModel;
using VaquitApp.Model;
using Xamarin.Forms;
using System.Linq;
using VaquitApp.View;

namespace VaquitApp.ViewModel
{
    public class AgregarIntegranteViewModel : BaseViewModel, IAgregarIntegranteViewModel
    {
        public string Nombre
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        public double Aporte
        {
            get { return Get<double>(); }
            set { Set<double>(value); }
        }

        public ObservableRangeCollection<Integrante> Integrantes { get; set; }

        public ICommand AgregarIntegranteCommand { get; set; }

        public ICommand LimpiarIntegrantesCommand { get; set; }

        public ICommand CalcularCommand { get; set; }

        public INavigation Navigation { get; set; }

        public AgregarIntegranteViewModel()
        {
            Integrantes = new ObservableRangeCollection<Integrante>();
            AgregarIntegranteCommand = new Command(async () => await AgregarIntegrante());
            LimpiarIntegrantesCommand = new Command(async () => await LimpiarIntegrantes());
            CalcularCommand = new Command(async () => await Calcular()); 
        }

        private async Task AgregarIntegrante()
        {
            try
            {
                Integrantes.Add(new Integrante() { Nombre = Nombre, Aporte = Aporte });
                Nombre = string.Empty;
                Aporte = 0;

                Toast.ShowMessage(string.Format("{0} Agregado", Nombre));
            }
            catch (Exception)
            {
                Toast.ShowMessage("Problema al agregar el integrante. Por favor, vuelva a intentarlo");
            }
        }

        private async Task LimpiarIntegrantes()
        {
            try
            {
                Integrantes.Clear();

                Toast.ShowMessage(string.Format("Lista limpiada con éxito"));
            }
            catch (Exception)
            {
                Toast.ShowMessage("Problema al limpiar la lista de integrantes. Por favor, vuelva a intentarlo");
            }
        }

        private async Task Calcular()
        {
            try
            {
                await Navigation.PushAsync(new CalcularView(Integrantes));
            }
            catch (Exception)
            {
                Toast.ShowMessage("Problema al limpiar la lista de integrantes. Por favor, vuelva a intentarlo");
            }
        }
    }
}
