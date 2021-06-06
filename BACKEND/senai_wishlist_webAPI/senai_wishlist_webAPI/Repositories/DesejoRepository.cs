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
    public class DesejoRepository : IDesejoRepository
    {
        WishListContext ctx = new WishListContext();

        public Desejo BuscarPorId(int id)
        {
            return ctx.Desejos.FirstOrDefault(x => x.IdDesejo == id);
        }

        public void Cadastrar(Desejo novoDesejo)
        {
            novoDesejo.DataCriacao = DateTime.Now;

            novoDesejo.Favorito = false;

            ctx.Desejos.Add(novoDesejo);

            ctx.SaveChanges();
        }

        public List<Desejo> Listar()
        {
            return ctx.Desejos.ToList();
        }

        public void Atualizar(int id, Desejo desejoAtualizado)
        {
            Desejo desejoBuscado = BuscarPorId(id);

            if (desejoAtualizado.Descricao != null)
            {
                desejoBuscado.Descricao = desejoAtualizado.Descricao;
            }

            desejoBuscado.DataCriacao = DateTime.Now;

            desejoBuscado.Favorito = desejoAtualizado.Favorito;

            ctx.Desejos.Update(desejoBuscado);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Desejos.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }


        // COM ID JWT INCLUÍDO:

        //public void Atualizar(int id, Desejo desejoAtualizado)
        //{
        //    Desejo desejoBuscado = BuscarPorId(id);

        //    if (desejoAtualizado.Descricao != null)
        //    {
        //        desejoBuscado.Descricao = desejoAtualizado.Descricao;
        //    }

        //    desejoBuscado.DataCriacao = DateTime.Now;

        //    desejoBuscado.Favorito = desejoAtualizado.Favorito;

        //    ctx.Desejos.Update(desejoBuscado);

        //    ctx.SaveChanges();
        //}

        //public Desejo BuscarPorId(int id)
        //{
        //    return ctx.Desejos.FirstOrDefault(x => x.IdDesejo == id);
        //}

        //public void Cadastrar(Desejo novoDesejo)
        //{
        //    novoDesejo.Favorito = false;

        //    novoDesejo.DataCriacao = DateTime.Now;

        //    ctx.Desejos.Add(novoDesejo);

        //    ctx.SaveChanges();
        //}

        //public void Deletar(int id)
        //{
        //    ctx.Desejos.Remove(BuscarPorId(id));

        //    ctx.SaveChanges();
        //}

        //public List<Desejo> ListarDesejos()
        //{
        //    return ctx.Desejos.Include(x => x.IdUsuarioNavigation).ToList();
        //}


    }
}
