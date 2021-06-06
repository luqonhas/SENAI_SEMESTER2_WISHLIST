using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_wishlist_webAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Desejos = new HashSet<Desejo>();
        }

        public int IdUsuario { get; set; }

        [RegularExpression("^[a-zA-Z ç ~ ã õ ê â î ô ñ û ú í á é ó ü ï ä ö ë]+$", ErrorMessage = "O nickname deve conter apenas letras!")]
        [StringLength(maximumLength: 50, MinimumLength = 10, ErrorMessage = "O nickname inserido é muito curto ou muito longo!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'nickname' obrigatório!")]
        public string Nickname { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "O valor inserido não é um e-mail válido!")]
        [StringLength(maximumLength: 200, MinimumLength = 10, ErrorMessage = "O e-mail inserido é muito curto ou muito longo!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'email' obrigatório!")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(maximumLength: 200, MinimumLength = 6, ErrorMessage = "A senha inserida é muito curta ou muito longa!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'senha' obrigatório!")]
        public string Senha { get; set; }

        public virtual ICollection<Desejo> Desejos { get; set; }
    }
}
