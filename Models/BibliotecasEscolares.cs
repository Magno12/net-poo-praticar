using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_praticar.Models
{
    public class BibliotecasEscolares : Livro
    {

        public BibliotecasEscolares
        (string nomeAutor, string nomeEditoraProdutora, string nomeLivro, string genero, int numeroDePaginas, string serieEscolar)
        {
            NomeAutor = nomeAutor;
            NomeEditoraProdutora = nomeEditoraProdutora;
            NomeLivro = nomeLivro;
            Genero = genero;
            NumeroDePaginas = numeroDePaginas;
            SerieEscolar = serieEscolar;
        }
        public string SerieEscolar { get; set; }

        public override void ExibirLivros()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Nome do Autor: {NomeAutor} \n Editora: {NomeEditoraProdutora}");
            Console.WriteLine($"Nome do Livro: {NomeLivro} \n Genero: {Genero}");
            Console.WriteLine($"Numero de Paginas: {NumeroDePaginas} \n Serie Escolar: {SerieEscolar}");
            Console.WriteLine("----------------------------------------");
        }

        public static void ExibirListaLivros(List<BibliotecasEscolares> listaLivros)
        {
            foreach (var item in listaLivros)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Nome do Autor: {item.NomeAutor} \n Editora: {item.NomeEditoraProdutora}");
                Console.WriteLine($"Nome do Livro: {item.NomeLivro} \n Genero: {item.Genero}");
                Console.WriteLine($"Numero de Paginas: {item.NumeroDePaginas} \n Serie Escolar: {item.SerieEscolar}");
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}