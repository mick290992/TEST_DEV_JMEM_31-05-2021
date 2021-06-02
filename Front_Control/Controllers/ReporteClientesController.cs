using Front_Control.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Front_Control.Controllers
{
    [Authorize]
    public class ReporteClientesController : Controller
    {
        public string token = "";

        // GET: ReporteClientes
        public async Task<ActionResult> Index(int? pageNumber)
        {

            ApiResponse resp = new ApiResponse();
            try
            {
                string token = HttpContext.Session.GetString("token");
                if (token != null)
                {
                    using (var httpClient = new HttpClient())
                    {
                        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                        using (var response = await httpClient.GetAsync("https://api.toka.com.mx/candidato/api/customers"))
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            resp = JsonConvert.DeserializeObject<ApiResponse>(apiResponse);
                        }
                    }
                }
                else
                {
                    return Forbid();
                }
            }
            catch (Exception)
            {
                return NotFound();
            }

            var clientes = resp.Data;

            return View(clientes);

        }
    }

  
}
