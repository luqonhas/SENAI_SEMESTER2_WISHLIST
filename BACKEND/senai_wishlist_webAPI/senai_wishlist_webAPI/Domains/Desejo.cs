using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_wishlist_webAPI.Domains
{
    public partial class Desejo
    {
        public int IdDesejo { get; set; }
        public int? IdUsuario { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public bool? Favorito { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
