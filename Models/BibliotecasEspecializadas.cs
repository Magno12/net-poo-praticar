using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_praticar.Models
{
    public class BibliotecasEspecializadas : Livro
    {
        public BibliotecasEspecializadas
        (string nomeAutor, string nomeEditora, string nomeLivro, string genero, int numeroDePaginas)
        {
            NomeAutor = nomeAutor;
            NomeEditora = nomeEditora;
            NomeLivro = nomeLivro;
            Genero = genero;
            NumeroDePaginas = numeroDePaginas;
        }

        public string NomeEspecializacao { get; set; }
    }
}