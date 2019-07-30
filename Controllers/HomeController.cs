using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProBoostrapFramework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult StartTemplate() => View();

        public IActionResult Base() => View();

        public IActionResult MediaQueries() => View();

        public IActionResult ContainerRows() => View();

        public IActionResult Grid() => View();

        public IActionResult AlinhamentoOffset() => View();

        public IActionResult Paginador() => View();

        public IActionResult CheckRadio() => View();

        public IActionResult LoginAmericanas() => View();

        public IActionResult Formulario() => View();
        public IActionResult Tabela() => View();
        public IActionResult Imagens() => View();
        public IActionResult Figure() => View();
        public IActionResult FonteAwesome() => View();
        public IActionResult Cards() => View();
        public IActionResult Navbar() => View();

    }
}
