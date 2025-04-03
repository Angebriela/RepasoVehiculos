using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVehiculos
{
    internal class AlquilerVehiculos
    {
        public string Nit { get; set; }
        public string Placa { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public decimal KilometrosRecorridos { get; set; }
    }
}
