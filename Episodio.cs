using System.Diagnostics.Contracts;

class Episodio{

    List<string> Convidado = new List<string>();

    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
       
    }
  
    public string Titulo {get; }
    public int Duracao {get; }
    public int Ordem {get; }
    public string Resumo => $"{Ordem}º {Titulo} - ({Duracao} min) - {string.Join(", ",Convidado)}";

    public void AdicionarConvidado(string NomeConvidado){
        Convidado.Add(NomeConvidado);
    }
    public void ExibirEpisodio()
    {
        Console.WriteLine(Resumo);
    }

}