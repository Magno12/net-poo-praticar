using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_praticar.Models
{
    public class BibliotecasEspecializadas : Livro
    {
        public BibliotecasEspecializadas
        (string nomeAutor, string nomeEditoraProdutora, string nomeLivro, string genero, int numeroDePaginas, string nomeEspecializacao) : base(nomeAutor: nomeAutor, nomeEditoraProdutora: nomeEditoraProdutora, nomeLivro: nomeLivro, genero: genero)
        {
            NumeroDePaginas = numeroDePaginas;
            NomeEspecializacao = nomeEspecializacao;
        }
        public string NomeEspecializacao { get; set; }

        public static void ExibirListaLivros(List<BibliotecasEspecializadas> listaLivros)
        {
            foreach (var item in listaLivros)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Nome do Autor: {item.NomeAutor} \n Editora: {item.NomeEditoraProdutora}");
                Console.WriteLine($"Nome do Livro: {item.NomeLivro} \n Genero: {item.Genero}");
                Console.WriteLine($"Numero de Paginas: {item.NumeroDePaginas} \n Especialização: {item.NomeEspecializacao}");
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}