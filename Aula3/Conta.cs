class Conta{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int ContaBancaria { get; set; }
    public float Saldo { get; set; }
    public float Limite { get; set; }

    public void ExibirInformacoes() {
        Console.WriteLine($"Agência: {Agencia} \nConta: {ContaBancaria} \nTitular da Conta: {Titular.NomeTitular} \nSaldo: {Saldo} \nLimite: {Limite}");
    }


}