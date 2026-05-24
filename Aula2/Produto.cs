using System.Text.Json;

class Produto {
    public string? Nome { get; set; }
    public string? Marca { get; set; }

    private float preco = 0;
    public float Preco {
        get { 
            return preco;
        }
        set {
            if (value > 0) { 
                preco = value;
            } else {
                preco = 0;
            }
        }
    }
    private int estoque = 0;
    public int Estoque {
        get {
            return estoque;
        }
        set {
            if (value > 0) {
                estoque = value;
            }
        }
    }

    public string Descricao => $"Produto {Nome} da marca {Marca} no preço de R$ {Preco} esta com {Estoque} no estoque.";

}