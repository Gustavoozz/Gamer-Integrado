using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Gamer_Full.Models
{
    public class Login
    {
        [Key]

        public string? Email { get; set; }

        public string? Senha { get; set; }

    }
}