class Carro {
    public string marca;
    public string modelo;
    public int ano;
    public int portas;

    public void ExibirInformacoes() {
        Console.WriteLine($"O {modelo} da marca {marca} do ano {ano} com {portas} portas.");
    }

    public void Acelerar() {
        Console.WriteLine($"Acelerou");
    }
    public void Frear() {
        Console.WriteLine($"Freou");
    }
    public void Buzinar() {
        Console.WriteLine($"Buzinou");
    }

}