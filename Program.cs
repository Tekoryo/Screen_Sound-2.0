Album albumOSteve = new Album("Lindas Mentiras");
Genero rap = new Genero("Rap");
Banda OSteve = new Banda("OSteve");

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


void CadastroDeUsuario()
{

}

void LoginDeUsuario()
{
    
}


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumOSteve.AdicionarMusica(musica1);
albumOSteve.AdicionarMusica(musica2);
rap.AdicionarMusica(musica1);
rap.AdicionarMusica(musica2);

albumOSteve.ExibirAlbum();
rap.ExibirGenero();

OSteve.AdicionarAlbum(albumOSteve);
OSteve.ExibirAlbum();





