using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroUsuarios.Models
{
    public class UsuarioViewModel // as viewModel representam todos os objetos que estamos manipulando na tela
    {
        [Display(Name = "Status")] // Define o que vai ser exibido ao usuário
        public bool Ativo {  get; set; }

        [Required] // Campo obrigatório
        [StringLength(100)] // Deve ter no máximo 100 caracteres
        [Display(Name = "Nome do usuário: ")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [StringLength(100)]
        [Display(Name = "Nome social")]
        public string NomeSocial { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength (250)]
        public string Senha { get; set; }
    }
}