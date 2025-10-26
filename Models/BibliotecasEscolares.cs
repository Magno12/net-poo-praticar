using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_praticar.Models
{
    public class BibliotecasEscolares : Livro
    {

        public BibliotecasEscolares
        (string nomeAutor, string nomeEditora, string nomeLivro, string genero, int numeroDePaginas, string serieEscolar)
        {
            NomeAutor = nomeAutor;
            NomeEditora = nomeEditora;
            NomeLivro = nomeLivro;
            Genero = genero;
            NumeroDePaginas = numeroDePaginas;
            SerieEscolar = serieEscolar;
        }
        public string SerieEscolar { get; set; }

    }
}