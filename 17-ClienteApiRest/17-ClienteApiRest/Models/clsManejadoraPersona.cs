using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Web.Http;

namespace _17_ClienteApiRest.Models
{
    public class clsManejadoraPersona
    {
        private string url = "http://albertapirest.azurewebsites.net/api/persona/"; 

        public async void EliminarPersona(int id)
        {
            HttpClient cliente = new HttpClient();

            try
            {
                Uri miUri = new Uri(url + id);
                await cliente.DeleteAsync(miUri);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async void ActualizarPersona(clsPersona p)
        {
            HttpClient cliente = new HttpClient();
            HttpResponseMessage res;
            try
            {
                Uri miUri = new Uri(url + p.id);

                //Crear Json
                string jsonPersona = JsonConvert.SerializeObject(p);

                // Create the IHttpContent
                IHttpContent contenidoPersona = new HttpStringContent(jsonPersona, Windows.Storage.Streams.UnicodeEncoding.Utf8, "application/json");

                res = await cliente.PutAsync(miUri, contenidoPersona);
                
                
            }
            catch (Exception)
            {
                throw;
            }

            
        }

    }
}
