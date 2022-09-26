using Control_view3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Control_view3.Controllers
{
    public class CalcularPrestamoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double m, int meses, double tp, double resultado)
        {
            C_Prestamo cp = new C_Prestamo();
            cp.Monto = m;
            cp.Meses = meses;
            cp.Tipo = tp;
            cp.Resultado = resultado;



            switch (tp)
            {
                case (int)BussinesLayer.EnumTPrestamo.Personal:
                    switch (meses)
                    {
                        case 12:
                            resultado = ((0.22 * m) + m) / 12;
                            resultado = Math.Round(resultado, 2);
                            ViewBag.pre = "$ " + resultado ;
                            break;
                        case 18:
                            resultado = ((0.22 * m) + m) / 18;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 24:
                            resultado = ((0.22 * m) + m) / 24;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 30:
                            resultado = ((0.22 * m) + m) / 30;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 36:
                            resultado = ((0.22 * m) + m) / 36;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 42:
                            resultado = ((0.22 * m) + m) / 42;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 48:
                            resultado = ((0.22 * m) + m) / 48;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 54:
                            resultado = ((0.22 * m) + m) / 54;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 60:
                            resultado = ((0.22 * m) + m) / 60;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 66:
                            resultado = ((0.22 * m) + m) / 66;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 72:
                            resultado = ((0.22 * m) + m) / 72;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 78:
                            resultado = ((0.22 * m) + m) / 78;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 84:
                            resultado = ((0.22 * m) + m) / 84;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 90:
                            resultado = ((0.22 * m) + m) / 90;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 96:
                            resultado = ((0.22 * m) + m) / 96;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 102:
                            resultado = ((0.22 * m) + m) / 102;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 108:
                            resultado = ((0.22 * m) + m) / 108;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 114:
                            resultado = ((0.22 * m) + m) / 114;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        case 120:
                            resultado = ((0.22 * m) + m) / 120;
                            ViewBag.pre = "$ " + resultado;
                            break;
                        default:

                            break;
                    }
                    break;
                case (int)BussinesLayer.EnumTPrestamo.Hipotecario:
                    switch (meses)
                    {
                        case 12:
                            resultado = ((0.08 * m) + m) / 12;
                            break;
                        case 18:
                            resultado = ((0.08 * m) + m) / 18;
                            break;
                        case 24:
                            resultado = ((0.08 * m) + m) / 24;
                            break;
                        case 30:
                            resultado = ((0.08 * m) + m) / 30;
                            break;
                        case 36:
                            resultado = ((0.08 * m) + m) / 36;
                            break;
                        case 42:
                            resultado = ((0.08 * m) + m) / 42;
                            break;
                        case 48:
                            resultado = ((0.08 * m) + m) / 48;
                            break;
                        case 54:
                            resultado = ((0.08 * m) + m) / 54;
                            break;
                        case 60:
                            resultado = ((0.08 * m) + m) / 60;
                            break;
                        case 66:
                            resultado = ((0.08 * m) + m) / 66;
                            break;
                        case 72:
                            resultado = ((0.08 * m) + m) / 72;
                            break;
                        case 78:
                            resultado = ((0.08 * m) + m) / 78;
                            break;
                        case 84:
                            resultado = ((0.08 * m) + m) / 84;
                            break;
                        case 90:
                            resultado = ((0.08 * m) + m) / 90;
                            break;
                        case 96:
                            resultado = ((0.08 * m) + m) / 96;
                            break;
                        case 102:
                            resultado = ((0.08 * m) + m) / 102;
                            break;
                        case 108:
                            resultado = ((0.08 * m) + m) / 108;
                            break;
                        case 114:
                            resultado = ((0.08 * m) + m) / 114;
                            break;
                        case 120:
                            resultado = ((0.08 * m) + m) / 120;
                            break;
                    }
                    break;
                case (int)BussinesLayer.EnumTPrestamo.Automovil:
                    switch (meses)
                    {
                        case 12:
                            resultado = ((0.12 * m) + m) / 12;
                            break;
                        case 18:
                            resultado = ((0.12 * m) + m) / 18;
                            break;
                        case 24:
                            resultado = ((0.12 * m) + m) / 24;
                            break;
                        case 30:
                            resultado = ((0.12 * m) + m) / 30;
                            break;
                        case 36:
                            resultado = ((0.12 * m) + m) / 36;
                            break;
                        case 42:
                            resultado = ((0.12 * m) + m) / 42;
                            break;
                        case 48:
                            resultado = ((0.12 * m) + m) / 48;
                            break;
                        case 54:
                            resultado = ((0.12 * m) + m) / 54;
                            break;
                        case 60:
                            resultado = ((0.12 * m) + m) / 60;
                            break;
                        case 66:
                            resultado = ((0.12 * m) + m) / 66;
                            break;
                        case 72:
                            resultado = ((0.12 * m) + m) / 72;
                            break;
                        case 78:
                            resultado = ((0.12 * m) + m) / 78;
                            break;
                        case 84:
                            resultado = ((0.12 * m) + m) / 84;
                            break;
                        case 90:
                            resultado = ((0.12 * m) + m) / 90;
                            break;
                        case 96:
                            resultado = ((0.12 * m) + m) / 96;
                            break;
                        case 102:
                            resultado = ((0.12 * m) + m) / 102;
                            break;
                        case 108:
                            resultado = ((0.12 * m) + m) / 108;
                            break;
                        case 114:
                            resultado = ((0.12 * m) + m) / 114;
                            break;
                        case 120:
                            resultado = ((0.12 * m) + m) / 120;
                            break;
                        default:

                            break;
                    }
                    break;

            }
            return View();
        }
    }
}