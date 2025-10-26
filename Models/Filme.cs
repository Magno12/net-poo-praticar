using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_praticar.Models
{
    public abstract class Filme : IAutores
    {
        public string NomeAutor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NomeEditoraProdutora { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected string NomeFilme;
        protected string TempoDuracao;
        protected string Genero;


    }
}