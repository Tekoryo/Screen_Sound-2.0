class Genero
{
    List<Musica> musicas = new List<Musica>();
        public String Nome { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirGenero()
    {
        Console.WriteLine($"Todas as musica do Genero {Nome}:\n");
        foreach(var musica in musicas){
            Console.WriteLine($"Musica: {musica.Nome}");
        }
    }
}