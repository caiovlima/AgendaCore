using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Tarefa : Entity
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Titulo { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFim { get; set; }

        public DateTime Data { get; set; }
    }
}
