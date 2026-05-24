class Conta{
    public int Id;
    public string titular;
    public float saldo;
    public int senha;

    public void ExibirInformacoes(){
        Console.WriteLine($"Titular: {titular} \nSaldo: {saldo:N2}");
    }

}