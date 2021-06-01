using Front_Control.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;


namespace Front_Control.Controllers
{
    public class LoginController : Controller
    {

        // POST: LoginController1/Create
        [HttpPost]
        public async Task<String> LoginAsync(string Username, string Password)
        {
            LoginResponse DataLogin = new LoginResponse();
            try
            {

                using (var httpClient = new HttpClient())
                {
                    Uri u = new Uri("http://localhost:31404/Api/Customers");
                    var payload = "{\"Username\": \"" + Username + "\",\"Password\": \"" + Password + "\"}";

                    HttpContent Cont = new StringContent(payload, Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("https://api.toka.com.mx/candidato/api/login/authenticate", Cont))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        DataLogin = JsonConvert.DeserializeObject<LoginResponse>(apiResponse);

                        } 
                    }
                return DataLogin.Data;

            }
            catch
            {
                return null;
            }
        }
    }
}
