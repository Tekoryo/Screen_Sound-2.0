class Musica
{
    public string Nome {get;set;}
    public string Artista {get;set;}
    public int Duracao {get;set;}
    public bool Disponivel {get;set;}
    public string NomeCompleto { get; set; }
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"duracao: {Duracao} min");
        if(Disponivel){
        Console.WriteLine($"disponivel: Sim!");
        }else{
            Console.WriteLine($"disponivel: Não!");
        }
    }
    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
        
    }
}