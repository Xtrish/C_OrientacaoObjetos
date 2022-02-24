namespace bytebank
{
    class ContaCorrente
    {
        public string conta;
        public int codigo_agencia;
        public string nome_agencia;
        public double saldo = 150;
        public string titular;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

       
    }
}
