using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using ControlApplication.Models;
using System.Text;
using Microsoft.AspNetCore.Identity;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;
using Microsoft.Extensions.Caching.Memory;


namespace ControlApplication.Controllers
{
    public class LoginController1 : Controller
    {

        // POST: LoginController1/Create
        [HttpPost]
        public async Task<SignInResult> LoginAsync(string Username, string Password)
        {
            try
            {
                LoginResponse DataLogin = new LoginResponse();
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
                                
                //HttpContext.Session.SetString("Token", DataLogin.Data.ToString());
                return SignInResult.Success;

            }
            catch
            {
                return SignInResult.Failed;
            }
        }
    }
}
