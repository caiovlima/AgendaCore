using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

        /* Podemos usar {0} que representa  o nome do campo para criar uma mensagem genérica */
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        /* {2} é o segundo parâmetro que é o minLenght e o {1} é oprimeiro parametro, 200 */
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        public DateTime DataCdastro { get; set; }

        public bool Ativo { get; set; }

        /* Ef Relations (N produtos => 1 Fornecedor) */
        public Fornecedor Fornecedor { get; set; }
    }
}
