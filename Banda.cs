class Banda
{
    private List<Album> albums = new List<Album>();
    public String Nome { get; set; }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirAlbum()
    {
        Console.WriteLine($"Discografia da banda {Nome}:\n");
        foreach(var album in albums){
            Console.WriteLine($"Álbum: {album.Nome} - ({album.DuracaoTotal})");
        }
    }

}