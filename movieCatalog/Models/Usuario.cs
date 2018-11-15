using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ovidio_mvc.Models //Model eh para o cadastro dos usuario. Model eh o responsavel pela classes do projecto
{
    public class Usuario 
    {
        [Required] //O campo Nome eh obrigatorio prenchar, n pode ficar em branco
        public string Nome { get; set; }

        [EmailAddress]  //O campo se n for um Email, vai falar q eh invalido
        [Display(Name ="E-mail")]
        public string Email { get; set; } //Email p/ mandar ofertas no usuario

        [Display(Name ="Data Nascimento")] //Qdo View tiver a converter o codigo c# em html. Vai pegar a propriedade Name dentro display e vai
        //substituir o atributo "DataDeNascimento" p/ q visualizacao fique bonito com "Data Nascimento
        public DateTime DataDeNascimento { get; set; } //Uma data d nascimento pq podera ter certos conteudo q sera restrito p/ idade dele

        [Required]
        public string Senha { get; set; }

        [Required]
        [Display(Name ="Repitir senha")]
        public string RepitaSenha { get; set; }
    }
}