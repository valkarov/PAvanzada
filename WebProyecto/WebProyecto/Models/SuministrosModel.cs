using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using WebProyecto.Entidades;

namespace WebProyecto.Models
{
    public class SuministrosModel
    {
        public List<SuministroENT> ObtenerSuministros()
        {
            using (var http = new HttpClient())
            {
                string url = "https://localhost:44376/api/suministros/obtener";
                var resp = http.GetAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                    return resp.Content.ReadFromJsonAsync<List<SuministroENT>>().Result;
                else
                    return new List<SuministroENT>();
            }
        }
    }
}
