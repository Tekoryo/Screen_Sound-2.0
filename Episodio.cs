using System.Diagnostics.Contracts;

class Episodio{

    List<int> Convidado = new List<int>();
  
    public string Titulo {get; set;}
    public int Duracao {get; set;}
    public int Ordem {get; set;}
    public string Resumo {get; set;}

    public void AdicionarConvidado(int NomeConvidado){
        Convidado.Add(NomeConvidado);
    }
    public void ExibirEpisodio(){
        Console.WriteLine($"Episodio: {Ordem}º - {Titulo}\n");
        Console.WriteLine($"Duração: {Duracao}\n");
        Console.WriteLine($"Detalhe do Ep: {Resumo}\n");

    }

}