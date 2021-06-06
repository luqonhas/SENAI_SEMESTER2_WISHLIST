using senai_wishlist_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webAPI.Interfaces
{
    interface IDesejoRepository
    {
        // COM ID JWT INCLUÍDO:

        //List<Desejo> ListarDesejos();

        //Desejo BuscarPorId(int id);

        //void Cadastrar(Desejo novoDesejo);

        //void Atualizar(int id, Desejo desejoAtualizado);

        //void Deletar(int id);


        // SEM ID JWT:

        List<Desejo> Listar();

        Desejo BuscarPorId(int id);

        void Cadastrar(Desejo novoDesejo);

        void Atualizar(int id, Desejo desejoAtualizado);

        void Deletar(int id);
    }
}
