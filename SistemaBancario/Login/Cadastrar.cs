using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario.Login
{
    internal class Cadastrar
    {
        private String titular { get; set; }
        private String cpf { get; set; }
        private String senha { get; set; }
        private String cnpj { get; set; }
        private int dataNascimento { get; set; }
        private String email { get; set; }
        private int numeroCelular { get; set; }

        public Cadastrar(String titular, String cpf, String cnpj, int dataNascimento)
        {
            this.titular = titular;
            this.cpf = cpf;
            this.cnpj = cnpj;
            this.dataNascimento = dataNascimento;
        }

        public String criarConta()
        {

            Console.WriteLine("Digite seu nome completo: ");
            Console.ReadLine();

            return 0;
        }

        //métodos para iserir os dados do usuário e depois poder fazer login
        //método para cadastrar o usuário fazer verificação que se for >= 18 anos pode cadastrar, caso contrário não pode
        //método de escolhar qual conta quer 


        
         using System;

public class Usuario
{
    public string Titular { get; set; }
    public string Cpf { get; set; }
    public string Cnpj { get; set; } // Para empresas
    public string Senha { get; set; }
    public string Email { get; set; }
    public int NumeroCelular { get; set; }
    public DateTime DataNascimento { get; set; }

    // Método para cadastrar o usuário com validação de 18 anos
    public bool CriarConta()
    {
        Console.WriteLine("=== SISTEMA DE CADASTRO ===");
        
        Console.Write("Digite seu nome completo: ");
        Titular = Console.ReadLine();

        Console.Write("Digite sua data de nascimento (formato: AAAA-MM-DD): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime nascimento))
        {
            DataNascimento = nascimento;
        }
        else
        {
            Console.WriteLine("Data inválida!");
            return false;
        }

        Console.Write("Digite seu CPF (ou CNPJ se for empresa): ");
        string documento = Console.ReadLine();
        
        if (documento.Length == 14) // Exemplo simples para diferenciar CNPJ
        {
            Cpf = documento;
        }
        else
        {
            Cnpj = documento;
        }

        Console.Write("Digite sua senha: ");
        Senha = Console.ReadLine();

        // Validação de maioridade (>= 18 anos)
        int idade = DateTime.Now.Year - DataNascimento.Year;
        if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
        {
            idade--; // Ajuste caso ainda não tenha feito aniversário este ano
        }

        if (idade < 18)
        {
            Console.WriteLine($"\nCadastro negado! Você tem {idade} anos. É necessário ter pelo menos 18 anos para criar uma conta.");
            return false;
        }

        Console.WriteLine("\nCadastro realizado com sucesso! Você é maior de idade.");
        return true;
    }

    // Método de Login
    public bool FazerLogin(string cpfOuCnpjDigitado, string senhaDigitada)
    {
        bool documentoConfere = (Cpf == cpfOuCnpjDigitado || Cnpj == cpfOuCnpjDigitado);
        bool senhaConfere = (Senha == senhaDigitada);

        if (documentoConfere && senhaConfere)
        {
            Console.WriteLine("Login realizado com sucesso! Bem-vindo(a), " + Titular);
            return true;
        }
        else
        {
            Console.WriteLine("CPF/CNPJ ou senha incorretos.");
            return false;
        }
    }

    // Método para escolher o tipo de conta
    public void EscolherTipoConta()
    {
        Console.WriteLine("\n--- ESCOLHA O TIPO DE CONTA ---");
        Console.WriteLine("1 - Conta Corrente");
        Console.WriteLine("2 - Conta Poupança");
        Console.WriteLine("3 - Conta Jurídica (Empresarial)");
        Console.Write("Digite a opção desejada: ");
        
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Você selecionou: Conta Corrente.");
                // Instanciar sua classe ContaCorrente aqui
                break;
            case "2":
                Console.WriteLine("Você selecionou: Conta Poupança.");
                // Instanciar sua classe ContaPoupanca aqui
                break;
            case "3":
                Console.WriteLine("Você selecionou: Conta Jurídica.");
                // Instanciar sua classe ContaJuridica aqui
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
         
         


    }
}
