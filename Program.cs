// See https://aka.ms/new-console-template for more information
using net_poo_praticar.Models;

List<BibliotecasEscolares> ListBibliotecaEscolares = new List<BibliotecasEscolares>();

BibliotecasEscolares EscolaFundamentalBrasilia = new BibliotecasEscolares(
nomeAutor: "Ênio Silveira",
nomeEditoraProdutora: "Editora Moderna",
nomeLivro: "MATEMATICA", genero: "INFANTIL",
numeroDePaginas: 200, serieEscolar: "1º ANO"
);

ListBibliotecaEscolares.Add(EscolaFundamentalBrasilia);

BibliotecasEscolares EscolaFundamentalUnai = new BibliotecasEscolares(
nomeAutor: " Kátia Ciranda Cultural",
nomeEditoraProdutora: "Ciranda Cultural",
nomeLivro: "PORTUGUES", genero: "INFANTIL",
numeroDePaginas: 220, serieEscolar: "1º ANO"
);

ListBibliotecaEscolares.Add(EscolaFundamentalUnai);

BibliotecasEscolares.ExibirListaLivros(ListBibliotecaEscolares);

//Criando outra Biblioteca
Console.WriteLine("BibliotecasEspecializadas");
List<BibliotecasEspecializadas> ListBibliotecasEspecializadas = new List<BibliotecasEspecializadas>();
BibliotecasEspecializadas bibliotecasEspecializadasSaoPaulo = new BibliotecasEspecializadas(nomeAutor: "Nilo Ney Coutinho Menezes", nomeEditoraProdutora: "Novatec Editora", nomeLivro: "INTRODUÇÃO A PROGRAMAÇÃO COM PYTHON", genero: "PROGRAMAÇÃO", numeroDePaginas: 552, nomeEspecializacao: "Livros Técnicos");

ListBibliotecasEspecializadas.Add(bibliotecasEspecializadasSaoPaulo);

BibliotecasEspecializadas bibliotecasEspecializadasUnai = new BibliotecasEspecializadas(nomeAutor: "Aditya Y. Bhargava", nomeEditoraProdutora: "Novatec", nomeLivro: "Entendendo Algoritmos", genero: "PROGRAMAÇÃO", numeroDePaginas: 264, nomeEspecializacao: "Livros Técnicos");

ListBibliotecasEspecializadas.Add(bibliotecasEspecializadasUnai);

//MÉTODO STATIC PARA CHAMAR SEM CRIAR UMA INSTÂNCIA
//EXIBIR LISTA DE LIVROS
BibliotecasEspecializadas.ExibirListaLivros(ListBibliotecasEspecializadas);