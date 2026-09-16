namespace SistemaBancario
{
 /*Ter de fato um login e depois com o login poder fazer transações */
    internal class ContaBancaria
    {
        private string titular;
        private int numeroConta;
        private double saldo;

        public ContaBancaria(/*string titular, int numeroConta, double saldo*/)
        {
            this.titular = titular;
            this.numeroConta = numeroConta;
            this.saldo = saldo;
        }

        //MÉTODOS depositar, sacar, consultarSaldo 

        public double sacar(double valorSacado)
        {

            //while (/*condicao ai que so sai quando de fato sacar,caso o valor a sacar seja maior repetiar a transação 
            //        e caso seja 0 mandar o usuário deposista primeiro*/) 
            //{ 

            //}
            if (saldo >= valorSacado)
            {
                saldo = saldo - valorSacado;
                return valorSacado;
            } else if (saldo == 0)
            {
                Console.WriteLine($"Você possui {saldo}.\nPrimeiro faça um deposito para depois pode sacar.");
            } else
            {
                Console.WriteLine($"Você possuiu {saldo} e quer sacar {valorSacado} transação incopatível.");
            }
            return 0;
        }

        public double depositar(double valorDepositado)
        {
            saldo += valorDepositado; 
            return 0;
        }

        public String consultarSaldo()
        {
            String informacoes 
            return ;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //}
    }
}
