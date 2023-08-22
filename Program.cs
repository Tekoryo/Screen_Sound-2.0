Album albumOSteve = new Album("Lindas Mentiras");
Genero rap = new Genero("Rap");
Banda OSteve = new Banda("OSteve");
Usuario Thiago = new Usuario("Thiago");


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


Thiago.AddNaPlaylist(musica1);
Thiago.AddNaPlaylist(musica2);







