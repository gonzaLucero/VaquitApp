using System.Windows.Input;
using VaquitApp.Commons;
using VaquitApp.Model;
using Xamarin.Forms;

namespace VaquitApp.IViewModel
{
    public interface IAgregarIntegranteViewModel
    {
        ICommand AgregarIntegranteCommand { get; set; }
        ObservableRangeCollection<Integrante> Integrantes { get; set; }

        INavigation Navigation { get; set; }
    }
}
