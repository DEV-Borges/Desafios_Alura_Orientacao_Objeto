class Carro {
    public string Fabricante { get; set; }
    public string Modelo { get; set; }

    private int ano;
    public int Ano {
        get {
            return ano;
        }
        set {
            if (value < 1960 || value > 2023) {
                Console.WriteLine("Ano inválido\n");
                ano = 0;
            } else {
                ano = value;
            }
        } 
    }
    public int Portas { get; set; }

    public string Descricao => $"O {Modelo} da marca {Fabricante} do ano {Ano} com {Portas} portas.";

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