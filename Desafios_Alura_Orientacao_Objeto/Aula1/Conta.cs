using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Alura_Orientacao_Objeto.Aula1
{
    class Conta
    {
        public string titular;
        public int id;
        public float saldo;
        public int senha;

        public void exibirInformacoes() {
            Console.WriteLine("INFORMAÇÕES DA CONTA:");
            Console.WriteLine($"Titular: {this.titular}");
            Console.WriteLine($"Saldo atual: {this.saldo}");
        }
    }
}
