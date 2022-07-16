using System;
using System.Collections.Generic;
using CatalogoUnimedBH.Interfaces;

namespace CatalogoUnimedBH
{
    public class StreamRepositorio : IRepositorio<Stream>
    {
        private List<Stream> listaStream = new List<Stream>();
        public void Atualiza(int id, Stream objeto)
        {
            listaStream[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaStream[id].Excluir();
        }

        public void Insere(Stream objeto)
        {
            listaStream.Add(objeto);
        }

        public List<Stream> Lista()
        {
            return listaStream;
        }

        public int ProximoId()
        {
            return listaStream.Count;
        }

        public Stream RetornaPorId(int id)
        {
            return listaStream[id];
        }
    }
}