using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_praticar.Models
{
    public class Livro : IAutores
    {
        public string NomeAutor { get; set; }
        public string NomeEditoraProdutora { get; set; }
        protected string NomeLivro;
        protected int NumeroDePaginas;
        protected string Genero;
        public Livro() { }

        public Livro
        (string nomeAutor, string nomeEditoraProdutora, string nomeLivro, string genero)
        {
            NomeAutor = nomeAutor;
            NomeEditoraProdutora = nomeEditoraProdutora;
            NomeLivro = nomeLivro;
            Genero = genero;
        }

        public virtual void ExibirLivros()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Nome Autor {NomeAutor}");
        }
    }
}