using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_do_Allan
{
    class controlCliente 
    {
        DaoCliente cliente;
        public int opcao;

        public controlCliente()
        {
            cliente = new DaoCliente();
        }

        public void MostrarMenu()
        {
            Console.WriteLine("------MENU------\n\n" +
                "\n0.Sair" +
                "\n1.Cadastrar Cliente" +
                "\nEscolha uma das opções acima:");
            this.opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void ExecutarOperacao()
        {
            do
            {
                this.cliente = new DaoCliente();
                this.MostrarMenu();
                switch (this.opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar cliente: ");

                        Console.WriteLine("Informe o nome do cliente: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe o telefone do cliente: ");
                        string telefone = Console.ReadLine();

                        Console.WriteLine("Informe o endereço do cliente: ");
                        string endereco = Console.ReadLine();

                        Console.WriteLine("Informe a data de nascimento do cliente: ");
                        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Crie um login: ");
                        string login = Console.ReadLine();

                        Console.WriteLine("Crie uma senha: ");
                        string senha = Console.ReadLine();

                        this.cliente.Cadastrar(nome, telefone, endereco, dataNascimento, login, senha);
                        break;
                    default:
                        Console.WriteLine("Código informado é inválido!");
                        break;
                }
            } while (this.opcao != 0);//fim do escolha
        }//fim da executar operação
    }//fim da classe
}//fim do projeto
    
