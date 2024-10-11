    using Microsoft.AspNetCore.Mvc;
using Moriccolo.Models;
using Moriccolo.Repository.Contact;

namespace Moriccolo.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
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
            if (ModelState.IsValid)
            {
                _usuarioRepository.Cadastrar(usuario);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AtualizarUsuario(int id)
        {
            return View(_usuarioRepository.ObterUsuario(id));
        }
        [HttpPost]
        public IActionResult AtualizarUsuario(Usuario usuario)
        {
            _usuarioRepository.Atualizar(usuario);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult ExcluirUsuario(int id)
        {
            _usuarioRepository.Excluir(id);
            return RedirectToAction(nameof(Index));
        }

    }
}

