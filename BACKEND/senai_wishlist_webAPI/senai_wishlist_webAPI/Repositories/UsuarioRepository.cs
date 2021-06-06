using Microsoft.EntityFrameworkCore;
using senai_wishlist_webAPI.Contexts;
using senai_wishlist_webAPI.Domains;
using senai_wishlist_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webAPI.Repositories
{
    public class UsuarioRepository // : IUsuarioRepository
    {
        // COM ID JWT INCLUÍDO:

        //WishListContext ctx = new WishListContext();
        //public List<Usuario> Listar()
        //{
        //    return ctx.Usuarios.ToList();
        //}

        //public List<Usuario> ListarPerfil(int id)
        //{
        //    return ctx.Usuarios.Include(x => x.Desejos).Where(x => x.IdUsuario == id).ToList();
        //}

        //public Usuario BuscarPorId(int id)
        //{
        //    return ctx.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
        //}

        //public void Cadastrar(Usuario novoUsuario)
        //{
        //    ctx.Usuarios.Add(novoUsuario);

        //    ctx.SaveChanges();
        //}

        //public Usuario Login(string email, string senha)
        //{
        //    Usuario login = ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);

        //    return login;
        //}

    }
}
