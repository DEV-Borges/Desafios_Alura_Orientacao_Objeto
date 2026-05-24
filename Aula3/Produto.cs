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

class EstoqueDeProdutos {
    private List<Produto> Produtos { get; set; } = new List<Produto>();

    public void AdicionarProduto(Produto produto) {
        Produtos.Add((produto));
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");
    }

    public void ExibirProdutos() {
        if (Produtos.Count == 0) {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        } else {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach (var produto in Produtos) {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}