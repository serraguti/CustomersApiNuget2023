using CustomersApiNuget2023.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApiNuget2023
{
    public class CustomerContext
    {
        //VAMOS A LEER TODOS LOS CUSTOMER DE UN API DE INTERNET
        //NECESITAMOS QUE EL METODO SEA ASINCRONO
        public async Task<CustomerList> GetCustomerListAsync()
        {
            WebClient client = new WebClient();
            //INDICAMOS QUE TIPO DE DATO VAMOS A LEER
            client.Headers["content-type"] = "application/json";
            string urlApi = "https://services.odata.org/V4/Northwind/Northwind.svc/Customers";
            //LEEMOS EL API Y DESCARGAMOS TODO EL CONTENIDO (string) JSON
            string json = await client.DownloadStringTaskAsync(urlApi);
            //COMO LOS DATOS VIENEN DIRECTOS COMO COLECCION/ARRAY
            CustomerList customers =
               JsonConvert.DeserializeObject<CustomerList>(json);




            //LA LIBRERIA NewtonSoft.json CON LOS MAPEOS QUE HEMOS REALIZADO
            //AUTOMATICAMENTE ENLAZA CADA PROPIEDAD CON CADA DATO DEL JSON
            CustomerList customers =
                JsonConvert.DeserializeObject<CustomerList>(json);
            return customers;
        }
    }
}
