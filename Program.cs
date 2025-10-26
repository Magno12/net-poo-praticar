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

