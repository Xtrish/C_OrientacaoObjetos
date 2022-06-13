<<<<<<< HEAD
﻿using bytebank;
using bytebank.Titular;
=======
﻿using bytebank.Titular;
>>>>>>> 5410cfa81756d32877723bfa21a07ebf2a7b3c07

namespace bytebank
{
    public class ContaCorrente
    {

<<<<<<< HEAD
        public Cliente Titular
        {
            get; set;
        }

        public string Conta
        {
            get; set;
=======
        public Cliente Titular { get; set; }
        public string Nome_Agencia { get; set; }
        public int Numero_agencia
        {
            get;

            set;
            

        }
        public string Conta
        {
            get;
            set;
        }

        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
>>>>>>> 5410cfa81756d32877723bfa21a07ebf2a7b3c07
        }
        public int Numero_agencia
        {
            get; set;
        }
        public string Nome_agencia
        {
            get; set;
        }

        private double saldo;


        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
<<<<<<< HEAD

=======
>>>>>>> 5410cfa81756d32877723bfa21a07ebf2a7b3c07
            if (valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }

<<<<<<< HEAD



=======
>>>>>>> 5410cfa81756d32877723bfa21a07ebf2a7b3c07
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

<<<<<<< HEAD
        public void ExibirDadosDaConta()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Conta:" + conta);
            Console.WriteLine("Número Agência :" + numero_agencia);
            Console.WriteLine("Nome Agência:" + nome_agencia);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("*************************************");
        }


        //public void SetSaldo(double valor)
        //{
        //    if (valor < 0)
        //    {
        //        return;
        //    }
        //    saldo = saldo+valor;
        //}
        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }
=======
       
>>>>>>> 5410cfa81756d32877723bfa21a07ebf2a7b3c07
    }
}