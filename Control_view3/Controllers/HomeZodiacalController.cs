using Control_view3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Control_view3.Controllers
{
    public class HomeZodiacalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( int Mes, int Dia)
        {
            SignZodiaco sz = new SignZodiaco();
            sz.Dia = Dia;
            sz.Mes = Mes;

            switch (Mes)
            {
                case 1:
                    if (Dia < 21)
                    {
                        ViewBag.SGZ = "Capricornio";
                    }
                    else
                    {
                        ViewBag.SGZ = "Acuario";

                    }
                    break;
                case 2:
                    if (Dia < 19)
                    {
                        ViewBag.SGZ = "Acuario";

                    }
                    else
                    {
                        ViewBag.SGZ = "Piscis";

                    }
                    break;
                case 3:
                    if (Dia < 21)
                    {
                        ViewBag.SGZ = "Piscis";
                    }
                    else
                    {
                        ViewBag.SGZ = "Aries";

                    }
                    break;
                case 4:
                    if (Dia < 21)
                    {
                        ViewBag.SGZ = "Aries";
                    }
                    else
                    {
                        ViewBag.SGZ = "Tauro";

                    }
                    break;
                case 5:
                    if (Dia < 20)
                    {
                        ViewBag.SGZ = "Tauro";

                    }
                    else
                    {
                        ViewBag.SGZ = "Geminis";
                    }
                    break;
                case 6:
                    if (Dia < 22)
                    {
                        ViewBag.SGZ = "Geminis";

                    }
                    else
                    {
                        ViewBag.SGZ = "Cancer";

                    }
                    break;
                case 7:
                    if (Dia < 23)
                    {
                        ViewBag.SGZ = "Cancer";

                    }
                    else
                    {
                        ViewBag.SGZ = "Leo";

                    }
                    break;
                case 8:
                    if (Dia < 24)
                    {
                        ViewBag.SGZ = "Leo";

                    }
                    else
                    {
                        ViewBag.SGZ = "Virgo";

                    }
                    break;
                case 9:
                    if (Dia < 24)
                    {
                        ViewBag.SGZ = "Virgo";

                    }
                    else
                    {

                        ViewBag.SGZ = "Libra";

                    }
                    break;
                case 10:
                    if (Dia < 24)
                    {
                        ViewBag.SGZ = "libra";

                    }
                    else
                    {
                        ViewBag.SGZ = "Escorpion";

                    }
                    break;
                case 11:
                    if (Dia < 23)
                    {
                        ViewBag.SGZ = "Escorpion";

                    }
                    else
                    {
                        ViewBag.SGZ = "Sagitario";

                    }
                    break;
                case 12:
                    if (Dia < 22)
                    {
                        ViewBag.SGZ = "Sagitario";

                    }
                    else
                    {
                        ViewBag.SGZ = "Capricornio";

                    }
                    break;
            }
            return View();
        }
    }
}

