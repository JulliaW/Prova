using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prova.Models
{
    public class ProdutoModel
    {
        [Key]
        [Display(Name = "ID:")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Informe o nome do produto:")]
        [Display(Name = "Nome do produto:")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do produto:")]
        [Display(Name = "Descrição:")]
        public String Descricao { get; set; }

        public virtual ICollection<FornecedorModel> Fornecedor { get; set; }

    }
}