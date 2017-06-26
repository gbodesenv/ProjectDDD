using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rj.SME.Sismonrio.Domain.Contracts.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Rj.SME.Sismonrio.WebCore.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService iUsuarioService)
        {
            _usuarioService = iUsuarioService;
        }

        // GET: /<controller>/
        public IActionResult Listar()
        {
            return View(_usuarioService.ListarGrid(new Domain.Filters.UsuarioFilter()));
        }
    }
}
