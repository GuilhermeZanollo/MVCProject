using System.Web.Mvc;
using CadastroUsuarios.Models;

namespace CadastroUsuarios.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); // retorna a view da ACTION INDEX() -> QUE NO CASO É A QUE CONFIGURAMOS QUE FICA EM: VIEW -> HOME -> INDEX.CSHTML
        }
        
        public ActionResult Cadastrar() // A ROTA É CADASTRAR, ENTÃO: Home/Cadastrar
        {
            var usuario = new UsuarioViewModel();

            return View(usuario); // retorna a view da action CADASTRAR()
        }
    }
}