Album albumOSteve = new Album();
Genero rap = new Genero();
Banda OSteve = new Banda();

OSteve.Nome = "OSteve";
albumOSteve.Nome = "Lindas Mentiras";
rap.Nome = "Rap";

Musica musica1 = new Musica(OSteve);
musica1.Nome = "Lindas Mentiras";
musica1.Duracao = 217;

Musica musica2 = new Musica(OSteve);
musica2.Nome = "Noite sem fim";
musica2.Duracao = 213;

albumOSteve.AdicionarMusica(musica1);
albumOSteve.AdicionarMusica(musica2);
rap.AdicionarMusica(musica1);
rap.AdicionarMusica(musica2);

albumOSteve.ExibirAlbum();
rap.ExibirGenero();

OSteve.AdicionarAlbum(albumOSteve);
OSteve.ExibirAlbum();






