using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.Web.Http.Filters;
using Newtonsoft.Json;

namespace _17_ClienteApiRest.Models
{
    public class clsListado
    {
        private ObservableCollection<clsPersona> _lista;
        private Uri miUrl;

        public clsListado()
        {
            miUrl = new Uri("http://albertapirest.azurewebsites.net/api/persona");
        }


     


        public async Task<ObservableCollection<clsPersona>> getPersonas()
        {

            HttpBaseProtocolFilter filtro = new HttpBaseProtocolFilter();
            filtro.CacheControl.ReadBehavior = HttpCacheReadBehavior.MostRecent;
            filtro.CacheControl.WriteBehavior = HttpCacheWriteBehavior.NoCache;

            HttpClient mihttpClient = new HttpClient(filtro);

            ObservableCollection<clsPersona> listadoPersona = new ObservableCollection<clsPersona>();

            try
            {
                string respuesta = await mihttpClient.GetStringAsync(miUrl);
                mihttpClient.Dispose();

                listadoPersona = JsonConvert.DeserializeObject<ObservableCollection<clsPersona>>(respuesta);
            }
            catch (Exception)
            {
                throw;
            }

            return listadoPersona;
        }

    }
}
