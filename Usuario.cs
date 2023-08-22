class Usuario
{
    Playlist favorito = new Playlist("favorito");
    public Usuario(String nomeDeUsuario)
    {
        NomeDeUsuario = nomeDeUsuario;
    }
    public string NomeDeUsuario {get;}

    public void AddNaPlaylist(Musica musica)
    {
        favorito.AddMusicaPlaylist(musica);
    }
    public void ExibirPlaylist()
    {
       favorito.ExibirPlaylist();
    }
}