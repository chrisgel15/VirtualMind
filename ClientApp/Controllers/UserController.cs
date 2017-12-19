using ClientApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ClientApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                ConfigureClient(client);
                var response = await client.GetAsync("users");

                if (response.IsSuccessStatusCode)
                {
                    return View(await response.Content.ReadAsAsync<IEnumerable<UserViewModel>>());
                }
                return View();
            }
        }

        public ActionResult New()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserViewModel UserViewModel)
        {
            using (var client = new HttpClient())
            {
                ConfigureClient(client);
                var stringContent = new StringContent(JsonConvert.SerializeObject(UserViewModel), Encoding.UTF8, "application/json");


                HttpResponseMessage response = null;
                if (UserViewModel.Id == 0)
                    response = await client.PostAsync("users", stringContent);
                else
                    response = await client.PutAsync("users", stringContent);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
                
            }

        }

        public async Task<ActionResult> Edit(int id)
        {
            UserViewModel UserViewModel = null;
            using (var client = new HttpClient())
            {
                ConfigureClient(client);
                var stringContent = new StringContent(JsonConvert.SerializeObject(id), Encoding.UTF8, "application/json");
                var response = await client.GetAsync("users/" + id);

                if (response.IsSuccessStatusCode)
                {
                    UserViewModel = await response.Content.ReadAsAsync<UserViewModel>();
                }

                return View(UserViewModel);
            }

        }

        public async Task<ActionResult> Delete(int id)
        {
            UserViewModel UserViewModel = null;
            using (var client = new HttpClient())
            {
                ConfigureClient(client);
                var stringContent = new StringContent(JsonConvert.SerializeObject(id), Encoding.UTF8, "application/json");
                var response = await client.GetAsync("users/" + id);

                if (response.IsSuccessStatusCode)
                {
                    UserViewModel = await response.Content.ReadAsAsync<UserViewModel>();
                }

                return View(UserViewModel);
            }

        }

        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            UserViewModel UserViewModel = null;
            using (var client = new HttpClient())
            {
                ConfigureClient(client);
                var stringContent = new StringContent(JsonConvert.SerializeObject(id), Encoding.UTF8, "application/json");
                var response = await client.DeleteAsync("users/" + id);

                if (response.IsSuccessStatusCode)
                {
                    UserViewModel = await response.Content.ReadAsAsync<UserViewModel>();
                }
                else
                {
                    return View(UserViewModel);
                }

                return RedirectToAction("Index");
            }

        }

        private static void ConfigureClient(HttpClient client)
        {
            string uri = ConfigurationManager.AppSettings["servicesUrl"].ToString();
            client.BaseAddress = new Uri("http://localhost:55886/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
    
}