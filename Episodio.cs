using System.Diagnostics.Contracts;

class Episodio{

    List<int> Convidado = new List<int>();

    public Episodio(string titulo, int duracao, int ordem, string resumo)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
        Resumo = resumo;
    }
  
    public string Titulo {get; }
    public int Duracao {get; }
    public int Ordem {get; }
    public string Resumo {get; }

    public void AdicionarConvidado(int NomeConvidado){
        Convidado.Add(NomeConvidado);
    }
    public void ExibirEpisodio(){
        Console.WriteLine($"Episodio: {Ordem}º - {Titulo}\n");
        Console.WriteLine($"Duração: {Duracao}\n");
        Console.WriteLine($"Detalhe do Ep: {Resumo}\n");

    }

}