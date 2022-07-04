using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.Models
{
    public class Resposta
    {
        [Required(ErrorMessage ="Field 'name' must be filled in ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field 'e-mail' must be filled in")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field 'answer' must be filled in")]
        public bool? Yes { get; set; }
    }
}
