using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
