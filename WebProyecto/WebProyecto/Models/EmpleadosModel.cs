using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using WebProyecto.Entidades;

namespace WebProyecto.Models
{
    public class EmpleadosModel
    {
        public int InsertarEmpleado(EmpleadoENT e) 
        {
            //Llama al API
            using (var http = new HttpClient()) 
            {
                string url = "https://localhost:44376/InsertarEmpleado";
                JsonContent contenido = JsonContent.Create(e);

                var resp = http.PostAsJsonAsync(url, contenido).Result;

                if (resp.IsSuccessStatusCode)
                    return resp.Content.ReadFromJsonAsync<int>().Result;
                else
                    return 0;

            }
        }
    }
}