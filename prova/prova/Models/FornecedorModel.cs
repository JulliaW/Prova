using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prova.Models
{
    public class FornecedorModel
    {
        [Key]
        [Display(Name = "ID:")]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Informe o nome do fornecedor:")]
        [Display(Name = "Nome do fornecedor:")]
        public String Nome { get; set; }

        [Display(Name = "E-mail:")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public String Email { get; set; }

        [Display(Name = "Logradouro:")]
        public String Logradouro { get; set; }

        [Display(Name = "Numero:")]
        public String Numero { get; set; }

        [Display(Name = "Complemento:")]
        public String Complemento { get; set; }

        [Display(Name = "Bairro:")]
        public String Bairro { get; set; }

        [Display(Name = "Cidade:")]
        public String Cidade { get; set; }

        public ProdutoModel Produto { get; set; }
    }
}