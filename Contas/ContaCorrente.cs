using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBank2._0.Titular;

namespace byteBank2._0.Contas
{
    public class ContaCorrente
    {
        //ALGO STATIC ELE PASSA A SER UMA PROPRIEDADE DA CLASSE E NÃO DO OBJETO
        public static int TotalDeContasCriadas { get; private set; } //O PRIVATE É PARA DEIXA-LO MAIS SEGURO PARA NÃO CONSEGUIREM MUDAR O VALOR.


        private int numero_agencia;
        public int Numero_Agencia
        {
            get { return this.numero_agencia; }
            private set {
                if(value > 0)   //O VALOR DO VALUE NÃO PODE SER MENOR QUE 0
                {
                    this.numero_agencia = value;
                }
            }
        }

        //private string conta;
        public string Conta { get; set; } 

        private double saldo = 100; //ELE SÓ É VISIVEL PARA A PROPRIA CLASSE

        public Cliente Titular { get; set; } //RECEBENDO REFERENCIA

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!!");
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        //METODO PUBLICO QUE TEM E RETORNA O ACESSO A VARIAVEL INTERNA
        public double GetSaldo()
        {
            return this.saldo;
        }

        //METODO CONSTRUTOR
        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_Agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }

        
    }
}

