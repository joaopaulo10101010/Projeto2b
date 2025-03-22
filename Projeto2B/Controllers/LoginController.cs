using Microsoft.AspNetCore.Mvc;
using Projeto2B.Models;
using Projeto2B.Repositorio;

namespace Projeto2B.Controllers
{
    public class LoginController : Controller
    {

        // DECLARA UMA VARIAVEL PRIVADA SOMENTE LEITURA 
        private readonly UsuarioRepositorio _usuarioRepositorio;

        // CONSTRUTOR

        public LoginController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;

        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(String email,String senha)
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
