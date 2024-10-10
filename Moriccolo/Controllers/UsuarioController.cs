using Microsoft.AspNetCore.Mvc;
using Moriccolo.Models;
using Moriccolo.Repository.Contact;

namespace Moriccolo.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioController (IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            return View(_usuarioRepository.ObterTodosUsuarios());
        }
        [HttpPost]
        public IActionResult CadastrarUsuario()
        {
            return View();
        }
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                _usuarioRepository.Cadastrar(usuario);
            }
            return View();
        }
    }
}
