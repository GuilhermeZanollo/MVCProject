using System.Web.Mvc;
using CadastroUsuarios.Models;

namespace CadastroUsuarios.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(); // retorna a view da ACTION INDEX() -> INDEX.CSHTML
        }

        [HttpGet]
        public ActionResult Cadastrar() // A ROTA É CADASTRAR, ENTÃO: Usuario/Cadastrar
        {
            var usuario = new UsuarioViewModel
            {
                Ativo = true
            };

            return View(usuario); // retorna a view da action CADASTRAR()
        }

        [HttpPost]
        public ActionResult CadastrarPost(UsuarioViewModel model) // Retornar na listagem objeto já cadastrado / recebe como parametro tudo preenchido
        {
            if (!ModelState.IsValid) // Verifica se as informações são válidas de acordo com os pre requisitos de atributo da model
            {
                return View("Cadastrar", model); // Retorna para a tela de cadastro para ser preenchida apenas os dados não validos
            }
            return RedirectToAction("Index", "Teste"); // Redireciona a requisição HTTP para a URL do método Index() no controlador Teste.
        }
    }
}