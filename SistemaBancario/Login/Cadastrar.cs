using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario.Login
{
    internal class Cadastrar
    {
        private String titular { get; set; }
        private String cpf { get; set; } //cnpj para empresas
        //private String senha { get; set; }
        private String cnpj { get; set; }
        private int dataNascimento { get; set; }
        private String email { get; set; }
        private int numeroCelular { get; set; }

        public Cadastrar(String titular, String cpf, String senha, String cnpj, int dataNascimento)
        {
            this.titular = titular;
            this.cpf = cpf;
            //this.senha = senha;
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



    }
}
