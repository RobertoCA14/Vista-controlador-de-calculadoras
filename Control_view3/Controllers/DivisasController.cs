using Control_view3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Control_view3.Controllers
{
    public class DivisasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    
    [HttpPost]
    public IActionResult Index(double m1, double m2, double resultado)
        {
        CambioDivisas  cd = new CambioDivisas();
            cd.Moneda1 = m1;
            cd.Moneda2 = m2;
            cd.Resultado = resultado;


            switch (m1)
            {
                case 1:

                    {
                        resultado = (m2 * 0.019);
                        ViewBag.re = "DOLLAR " + resultado;
                    }
                    
                    break;
                case 2:
                    
                    {
                        resultado = (m2 * 53.30);
                        ViewBag.re = "PESO " + resultado;

                    }
                    break;
                case 3:
                    {
                        resultado = (m2 * 0.019);
                        ViewBag.re = "EURO " + resultado;

                    }
                    break;

                case 4:
                    {
                        resultado = (m2 * 52.47);
                        ViewBag.re = "PESO " + resultado;

                    }
                    break;
                case 5:
                    {
                        resultado = (m2 * 1.02);
                        ViewBag.re = "EURO " + resultado;

                    }
                    break;
                case 6:
                    {
                        resultado = (m2 * 0.98);
                        ViewBag.re = "DOLLAR " + resultado;

                    }
                    break;
                default:
                        string divisas = resultado.ToString();
                        divisas = "Seleccione el tipo de divisa";
                        ViewBag.re = divisas;
                    break;

            }
            
            return View();
        }
    }
}
