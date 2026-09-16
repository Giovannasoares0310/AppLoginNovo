using AppLogin.Libraries.Filtro;
using AppLogin.Models.Constant;
using Microsoft.AspNetCore.Mvc;

namespace AppLogin.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao(ColaboradorTipoConstant.Gerente)]

    public class ColaboradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
