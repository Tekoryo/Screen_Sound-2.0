Album albumOSteve = new Album("Lindas Mentiras");
Genero rap = new Genero("Rap");
Banda OSteve = new Banda("OSteve");
Usuario Thiago = new Usuario("Thiago");
Podcast teste = new Podcast("teste","Programando em C#");

Musica musica1 = new Musica(OSteve,"Lindas Mentiras")
{
    Duracao =217,
    Disponivel = true,
};

Musica musica2 = new Musica(OSteve,"Noite sem fim")
{
    Duracao = 213,
    Disponivel = false,
};

Episodio Eps1 = new Episodio("Basico de c#",45,1);

Eps1.AdicionarConvidado("Victor");
Eps1.AdicionarConvidado("Maria");
Eps1.AdicionarConvidado("João");

Episodio Eps2 = new Episodio("Avançando no c#",49,2);
Eps2.AdicionarConvidado("Thiago");

Thiago.AddNaPlaylist(musica1);
Thiago.AddNaPlaylist(musica2);

teste.AdicionarEpisodio(Eps1);
teste.AdicionarEpisodio(Eps2);
teste.ExibirDetalhe();

Thiago.ExibirPlaylist();





