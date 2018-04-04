using System;
using System.Threading.Tasks;
using System.Windows.Input;
using VaquitApp.Commons;
using VaquitApp.IViewModel;
using VaquitApp.Model;
using Xamarin.Forms;
using System.Linq;

namespace VaquitApp.ViewModel
{
    public class CalcularViewModel : BaseViewModel, ICalcularViewModel
    {
        public double Total
        {
            get { return Get<double>(); }
            set { Set<double>(value); }
        }

        public double Cuota
        {
            get { return Get<double>(); }
            set { Set<double>(value); }
        }

        public string Color { get { return Cuota >= 0 ? "#27ae60" : "#e74c3c"; } }

        public ObservableRangeCollection<Integrante> Integrantes { get; set; }

        public ICommand AgregarIntegranteCommand { get; set; }

        public ICommand LimpiarIntegrantesCommand { get; set; }

        public ICommand CalcularCommand { get; set; }

        public CalcularViewModel(ObservableRangeCollection<Integrante> Integrantes)
        {
            this.Integrantes = new ObservableRangeCollection<Integrante>();
            Calcular(Integrantes);
        }
        
        private void Calcular(ObservableRangeCollection<Integrante> Integrantes)
        {
            try
            {
                Total = Integrantes.Sum(integrante => integrante.Aporte);
                Cuota = Total / Integrantes.Count;

                foreach (var integrante in Integrantes)
                {
                    integrante.Couta = integrante.Aporte - Cuota;
                    this.Integrantes.Add(integrante);
                }
            }
            catch (Exception)
            {
                Toast.ShowMessage("Problema al calcular. Por favor, vuelva a intentarlo");
            }
        }
        
    }
}
