using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_praticar.Models
{
    public abstract class Livro : IAutores
    {
        public string NomeAutor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NomeEditora { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected string NomeLivro;
        protected int NumeroDePaginas;
        protected string Genero;


    }
}