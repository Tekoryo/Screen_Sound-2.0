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

Episodio Eps1 = new Episodio("Basico de c#",2400,1,"Vamos Aprender a usar o C#");

Eps1.AdicionarConvidado(2);

Episodio Eps2 = new Episodio("Avançando no c#",2400,2,"Vamos avança no C#");

Thiago.AddNaPlaylist(musica1);
Thiago.AddNaPlaylist(musica2);

teste.AdicionarEpisodio(Eps1);
teste.AdicionarEpisodio(Eps2);
teste.ExibirDetalhe();

Thiago.ExibirPlaylist();





