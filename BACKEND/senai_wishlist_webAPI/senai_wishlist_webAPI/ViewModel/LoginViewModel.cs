using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webAPI.ViewModel
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "O valor inserido não é um e-mail válido!")]
        [StringLength(maximumLength: 200, MinimumLength = 10, ErrorMessage = "O e-mail inserido é muito curto ou muito longo!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'email' obrigatório!")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(maximumLength: 200, MinimumLength = 6, ErrorMessage = "A senha inserida é muito curta ou muito longa!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'senha' obrigatório!")]
        public string senha { get; set; }
    }
}
