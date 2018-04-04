using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaquitApp.Model
{
    public class Integrante
    {
        public string  Nombre { get; set; }

        public double Aporte { get; set; }

        public double Cuota { get; set; }

        public string Color { get { return Cuota >= 0 ? "#27ae60" : "#e74c3c"; } }

        public string Accion { get { return Cuota >= 0 ? "Recibe" : "Pone"; } }
    }
}
