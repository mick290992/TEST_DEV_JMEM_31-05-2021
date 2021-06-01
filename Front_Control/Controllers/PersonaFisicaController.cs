using Front_Control.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Front_Control.Controllers
{
    [Authorize]
    public class PersonaFisicaController : Controller
    {

        public async Task<ActionResult> PersonaFisica()
        {
            List<PersonaFisica> PersonaList = new List<PersonaFisica>();
            using (var httpClient = new HttpClient())
            {

                using (var response = await httpClient.GetAsync("http://localhost:1436/api/Personas"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    PersonaList = JsonConvert.DeserializeObject<List<PersonaFisica>>(apiResponse);
                }
            }
            return View(PersonaList);
        }

        public async Task<PersonaFisica> Details(int? id)
        {
            PersonaFisica PersonaList = new PersonaFisica();
            using (var httpClient = new HttpClient())
            {

                using (var response = await httpClient.GetAsync("http://localhost:1436/api/Personas/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    PersonaList = JsonConvert.DeserializeObject<PersonaFisica>(apiResponse);
                }
            }
            return PersonaList;
        }

        public StringContent serializar (PersonaFisica p)
        {
            var myContent = JsonConvert.SerializeObject(p);
            var stringContent = new StringContent(myContent, UnicodeEncoding.UTF8, "application/json");
            return stringContent;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaFisica persona)
        {
            string apiResponse;
            if (ModelState.IsValid)
            {
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        var stringContent = serializar(persona);
                        using (var response = await httpClient.PostAsync("http://localhost:1436/api/Personas", stringContent))
                        {
                            apiResponse = await response.Content.ReadAsStringAsync();

                        }
                    }

                    TempData["mensaje"] = "Se guardo correctamente";
                    return RedirectToAction("PersonaFisica");
                }
                catch
                {
                    return View();
                }
            }
            return View();
          
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var persona = await Details(id);
            return View(persona);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaFisica persona)
        {
            string apiResponse;
            try
            {

                using (var httpClient = new HttpClient())
                {
                    var stringContent = serializar(persona);
                    using (var response = await httpClient.PutAsync("http://localhost:1436/api/Personas", stringContent))
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();

                    }
                }
                TempData["mensaje"] = "Se edito el registro";
                return RedirectToAction("PersonaFisica");
            }
            catch
            {
               
                return View();
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var persona = await Details(id);
            return View(persona);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(PersonaFisica persona)
        {

            using (var httpClient = new HttpClient())
            {
                try
                {
                    using (var response = await httpClient.DeleteAsync("http://localhost:1436/api/Personas/" + persona.idPersonaFisica))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                    TempData["mensaje"] = "Se elimino el registro";
                    return RedirectToAction("PersonaFisica");
                }
                catch (Exception)
                {
                    TempData["mensaje"] = "No se elimino el registro";
                    return View();
                }

            }
            return View();
        }
    }
}
