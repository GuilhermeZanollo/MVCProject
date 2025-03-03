using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroUsuarios.Models
{
    public class UsuarioViewModel // as viewModel representam todos os objetos que estamos manipulando na tela ex: nome, sobrenome, data nascimento, senha
    {
        [Display(Name = "Nome do usuário: ")]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeSocial { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
    }
}