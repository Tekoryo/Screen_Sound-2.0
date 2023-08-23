class Podcast{

    private List<Episodio> Eps = new List<Episodio>();
    public Podcast(string nomeDeHost, string nome)
    {
        Host = nomeDeHost;
        Nome = nome;
    }
    public string Host {get;}
    public string Nome {get;}
    public int TotalEpisodio = -1;
    public void AdicionarEpisodio(Episodio eps)
    {
        Eps.Add(eps);
        
        foreach(var episodio in Eps)
        {
            TotalEpisodio++;
        }
        
    }

    public void ExibirDetalhe()
    {
        Console.WriteLine($"{Host}, Apresenta:");
        Console.WriteLine($"O Podcast {Nome}\n");
        Console.WriteLine($"Total de Episodio: {TotalEpisodio} \n");
        Console.WriteLine($"Detalhe dos Episodio: \n");

        foreach(var episodio in Eps)
        {
            episodio.ExibirEpisodio();
        }
    }

}