using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaquitApp.Commons;
using VaquitApp.Model;

namespace VaquitApp.IViewModel
{
    public interface ICalcularViewModel
    {
        ObservableRangeCollection<Integrante> Integrantes { get; set; }
    }
}
