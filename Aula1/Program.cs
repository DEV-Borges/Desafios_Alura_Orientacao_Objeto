Conta conta = new Conta() {
Id = 1,
titular = "Bruno",
saldo = 50.60f,
senha = 1234
};

conta.ExibirInformacoes();

Console.WriteLine("\n\n////////////////////////////////////////\n\n");

Carro carro = new Carro() { 
    marca = "Volkswagen",
    modelo = "Gol (versão MPI)",
    ano = 2022,
    portas = 4
};

carro.ExibirInformacoes();
carro.Acelerar();
carro.Buzinar();
carro.Frear();



