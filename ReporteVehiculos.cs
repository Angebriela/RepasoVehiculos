using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoVehiculos
{
    internal class ReporteVehiculos
    {
        public string NombreCliente { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public decimal PrecioKilometro { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public decimal TotalPago { get; set; }

        

    }
}
