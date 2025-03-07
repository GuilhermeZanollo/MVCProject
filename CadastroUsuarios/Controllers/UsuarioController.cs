using System.Web.Mvc;
using CadastroUsuarios.Models;
using System.Collections.Generic;
using System;

namespace CadastroUsuarios.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult Listar()
        {
            var listaUsuarios = RetornarUsuariosCadastrados();

            if (TempData["UsuariosNovos"] != null)
            {
                var listaUsuariosNovos = (List<UsuarioViewModel>)TempData["UsuariosNovos"];

                listaUsuarios.AddRange(listaUsuariosNovos);
            }

            TempData.Keep("UsuariosNovos");

            return View(listaUsuarios); // retorna a view da ACTION INDEX() -> INDEX.CSHTML
        }

        private List<UsuarioViewModel> RetornarUsuariosCadastrados()
        {
            return new List<UsuarioViewModel>
            {
                new UsuarioViewModel
                {
                    Nome = "Elvis",
                    Sobrenome = "Presley",
                    DataNascimento = new DateTime(1935, 1, 8)
                },
                new UsuarioViewModel
                {
                    Nome = "Ayrton",
                    Sobrenome = "Senna",
                    DataNascimento = new DateTime(1960, 3, 21)
                }
            };
        }

        [HttpGet]
            public ActionResult Cadastrar() // A ROTA É CADASTRAR, ENTÃO: Usuario/Cadastrar
            {
                var usuario = new UsuarioViewModel
                {
                    Ativo = true,
                    Nome = "Guilherme",
                    Sobrenome = "Zanollo",
                    Senha = "1",
                    DataNascimento = new System.DateTime(1990,10,10)
                };

                return View(usuario); // retorna a view da action CADASTRAR()
            }

        [HttpPost]
        public ActionResult CadastrarPost(UsuarioViewModel model) // Retornar na listagem objeto já cadastrado / recebe como parametro tudo preenchido
        {
            if (!ModelState.IsValid) // Verifica se as informações são válidas de acordo com os pre requisitos de atributo da model
            {
                ViewBag.mensagemErro = "Usuário não cadastrado";

                return View("Cadastrar", model); // Retorna para a tela de cadastro para ser preenchida apenas os dados não validos
            }

            TempData["UsuariosNovos"] = RetornarNovosUsuarios(model);
            TempData["mensagemSucesso"] = "Usuário cadastrado!";

            return RedirectToAction("Listar"); // Redireciona a requisição HTTP para a URL do método Listar().
        }

        private List<UsuarioViewModel> RetornarNovosUsuarios(UsuarioViewModel model)
        {
            if (TempData["UsuariosNovos"] == null)
                return new List<UsuarioViewModel>
                {
                    model
                };
            var lista = (List<UsuarioViewModel>)TempData["UsuariosNovos"];
            lista.Add(model);

            return lista;
        }
    }
}
