using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ControlApplication.Models
{
    public class PersonaFisicaController : Controller
    {
        // GET: PersonaFisicaController
        public async Task<ActionResult> Index()
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

        // GET: PersonaFisicaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View();
        }

        // GET: PersonaFisicaController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: PersonaFisicaController/Create
        [HttpPost]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaFisicaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        // POST: PersonaFisicaController/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaFisicaController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View();
        }


    }
}
