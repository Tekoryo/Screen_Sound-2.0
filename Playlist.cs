class Playlist
{
    List<Musica> musicas = new List<Musica>();
    public Playlist(String nomePlaylist)
    {
        Nome = nomePlaylist;
    }

    public string Nome {get;}

    public void AddPlaylist(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirPlaylist()
    {
       
    }
}