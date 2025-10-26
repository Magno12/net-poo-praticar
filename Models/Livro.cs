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
        public virtual void ExibirLivros()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Nome Autor {NomeAutor}");
        }

    }
}