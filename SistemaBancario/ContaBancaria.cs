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

            while (true)
            {
                Console.WriteLine("Digite o valor que deseja sacar: ");
                valorSacado = double.Parse(Console.ReadLine());

                if (saldo >= valorSacado && valorSacado > 0)
                {
                    saldo = saldo - valorSacado;
                    Console.WriteLine($"Saque realizado com sucesso!\nSaldo conta: {saldo}");
                    return valorSacado;
                }
                else if (saldo == 0)
                {
                    Console.WriteLine($"Você possui {saldo}.\nPrimeiro faça um deposito para depois pode sacar.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Você possuiu {saldo} e quer sacar {valorSacado} transação incopatível.");
                }

            }

            return 0;
        
        }

        public double depositar(double valorDepositado)
        {
            saldo += valorDepositado;
            Console.WriteLine($"Valor deposistado com sucesso!\nSaldo: {saldo}.");
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
