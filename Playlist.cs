class Playlist
{
    List<Musica> musicas = new List<Musica>();
    List<Podcast> podcast = new List<Podcast>();
    public Playlist(String nomePlaylist)
    {
        Nome = nomePlaylist;
    }

    public string Nome {get;}

    public void AddMusicaPlaylist(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirPlaylist()
    {
       Console.WriteLine($"Musica da playlist {Nome}: \n");
       int i =0;
       foreach(var musica in musicas)
       {
        i++;
        Console.WriteLine($"{i}º Musica: {musica.Nome}");
       }
       Console.Write("\n");
    }
}