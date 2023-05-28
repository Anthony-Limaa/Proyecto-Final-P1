using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_P1
{
    internal interface IVehiculo
    {
        
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }
     
        string bocina { get; set; }
        string encender { get; set; }
        string apagar { get; set; }
        
    }
}

