using System;

namespace CatalogoUnimedBH
{
    public class Stream : EntidadeBase
    {
        // Atributos
        private Playlist Playlist { get; set; }
        private string Titulo { get; set; }
        private float Duracao { get; set; }
        private string Descricao { get; set; }
        private string Link { get; set; }
        private bool Excluido { get; set; }

        // Métodos
        public Stream(int id, Playlist playlist, string titulo, float duracao, string descricao, string link)
        {
            this.Id = id;
            this.Playlist = playlist;
            this.Titulo = titulo;
            this.Duracao = duracao;
            this.Descricao = descricao;
            this.Link = link;
            this.Excluido = false;
        }

        public override string ToString()
        {

            string retorno = "";
            Console.WriteLine();
            retorno += "Playlist: " + this.Playlist + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Duração: " + this.Duracao + " minuto(s)" + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Link: " + this.Link + Environment.NewLine;
            retorno += "Excluido: " + (this.Excluido ? "Sim" : "Não");
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}