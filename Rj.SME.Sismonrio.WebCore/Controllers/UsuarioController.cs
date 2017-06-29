using Microsoft.AspNetCore.Mvc;
using Rj.SME.Sismonrio.Domain.Contracts.Services;

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

        public IActionResult VisualizarUsuario()
        {
            return View();
        }
    }
}