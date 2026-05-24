
Conta conta = new Conta() {
    Id = 1,
    Titular = "Bruno",
    Saldo = 50.60f,
    Senha = 1234
};

conta.ExibirInformacoes();

Console.WriteLine("\n////////////////////////////////////////\n");

Carro carro = new Carro() {
    Fabricante = "Volkswagen",
    Modelo = "Gol (versão MPI)",
    Ano = 1950,
    Portas = 4
};

Console.WriteLine(carro.Descricao);
carro.Acelerar();
carro.Buzinar();
carro.Frear();

Console.WriteLine("\n////////////////////////////////////////\n");

Produto produto = new Produto() {
    Nome = "Kindle Paperwhite (16 GB)",
    Marca = "Amazon",
    Preco = 721.05f,
    Estoque = 500    
};

Console.WriteLine(produto.Descricao);
