using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace RepasoVehiculos
{
    internal class ClientesArchivo
    {
        public void Guardar(string archivo, List<Clientes>clientes)
        {
            string Json = JsonConvert.SerializeObject(clientes);
            System.IO.File.WriteAllText(archivo, Json);
        }

        public List<Clientes> Leer(string archivo)
        {
            List <Clientes> lista = new List<Clientes>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Clientes>>(json);
            return lista;
        }

        

    }
}
