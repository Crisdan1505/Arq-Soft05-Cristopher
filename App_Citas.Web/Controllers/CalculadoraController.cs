using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;

namespace App_Citas.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(double a, double b, string operacion)
        {
            using HttpClient client = new HttpClient();

            string url = $"http://localhost:5172/api/calculadora/{operacion}?a={a}&b={b}";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                using var doc = JsonDocument.Parse(json);

                ViewBag.Operacion = doc.RootElement.GetProperty("operacion").GetString();
                ViewBag.NumeroA = doc.RootElement.GetProperty("a").GetDouble();
                ViewBag.NumeroB = doc.RootElement.GetProperty("b").GetDouble();
                ViewBag.Resultado = doc.RootElement.GetProperty("resultado").GetDouble();
                ViewBag.Error = null;
            }
            else
            {
                ViewBag.Error = await response.Content.ReadAsStringAsync();
                ViewBag.Resultado = null;
            }

            return View();
        }
    }
}