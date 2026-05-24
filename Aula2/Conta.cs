class Conta{
    public int Id { get; set; }
    public string Titular { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }

    public void ExibirInformacoes(){
        Console.WriteLine($"Titular: {Titular} \nSaldo: {Saldo:N2}");
    }

}