class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(String nome)
    {
        Nome = nome;
    }

    public String Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirAlbum()
    {
        Console.WriteLine($"Lista de música do álbum {Nome}:\n");
       foreach(var musica in musicas)
       {
        Console.WriteLine($"Musica: {musica.Nome}");
       }
        Console.WriteLine($"Para ouvir o álbum inteiro é preciso de {DuracaoTotal}\n");
   }
}