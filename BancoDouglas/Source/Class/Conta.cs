using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BancoDouglas.Source.Class
{
    //Está estendendo a classe Pessoa, recebendo as propriedades da classe. 
    class Conta : Pessoa
    {
        private Random random = new Random();
        private List<Conta> contas;
        private int agencia = 37005;
        private int conta { get; set; }

        private enum pessoa_rank
        {
            Cliente,
            Gerente
        }

        private enum tipo_conta
        {
            Poupanca,
            Corrente
        }
        
        private Double corrente { get; set; }
        private Double poupanca { get; set; }
        private String senha { get; set; }

        public Conta()
        {
            contas = new List<Conta>();
        }

        public void AbrirConta()
        {            
            //Hashtable
            conta = random.Next(0, 99999);
            nome = "";
            nascimento = DateTime.Today;            
        }
    }
}