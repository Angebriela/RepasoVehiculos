using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RepasoVehiculos
{
    internal class AlquileresArchivo
    {
        public void Guardar(string archivo, List<AlquilerVehiculos> alquileres)
        {
            string Json = JsonConvert.SerializeObject(alquileres);
            System.IO.File.WriteAllText(archivo, Json);
        }

        public List<AlquilerVehiculos> Leer(string archivo)
        {
            List<AlquilerVehiculos> lista = new List<AlquilerVehiculos>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<AlquilerVehiculos>>(json);
            return lista;
        }
    }
}
