class Musica
{
    public Musica(Banda artista,String nome)
    {
         Artista = artista;
         Nome = nome;
    }
    public string Nome {get;set;}
    public Banda Artista {get;}
    public int Duracao {get;set;}
    public bool Disponivel {get;set;}
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"duracao: {Duracao} seg");
        if(Disponivel){
        Console.WriteLine($"disponivel: Sim!\n");
        }else{
            Console.WriteLine($"disponivel: Não!\n");
        }
    }
    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
        
    }   
}
