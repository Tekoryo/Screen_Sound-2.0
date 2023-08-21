Album albumOSteve = new Album();
Genero rap = new Genero();

albumOSteve.Nome = "Lindas Mentiras";
rap.Nome = "Rap";

Musica musica1 = new Musica();
musica1.Nome = "Lindas Mentiras";
musica1.Duracao = 217;

Musica musica2 = new Musica();
musica2.Nome = "Noite sem fim";
musica2.Duracao = 213;

albumOSteve.AdicionarMusica(musica1);
albumOSteve.AdicionarMusica(musica2);
rap.AdicionarMusica(musica1);
rap.AdicionarMusica(musica2);

albumOSteve.ExibirAlbum();
rap.ExibirGenero();






