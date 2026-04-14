using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_do_Allan
{
    class ControlFuncionario
    {
        DaoFuncionario funcionario;
        public int opcao;

        public ControlFuncionario()
        {
            funcionario = new DaoFuncionario();
        }

        public void MostrarMenu()
        {
            Console.WriteLine("------MENU------\n\n" +
                "\n0.Sair" +
                "\n1.Cadastrar Funcionario:" +
                "\nEscolha uma das opções acima:");
            this.opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void ExecutarOperacao()
        {
            do
            {
                this.funcionario = new DaoFuncionario();
                this.MostrarMenu();
                switch (this.opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Cadastre o funcionario: ");
                        Console.WriteLine("Informe o nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe o endereço: ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Informe o telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe o cargo: ");
                        string cargo = Console.ReadLine();
                        Console.WriteLine("Informe o salario: ");
                        decimal salario = Convert.ToDecimal(Console.ReadLine());
                        this.funcionario.Inserir(nome, endereco, telefone, cargo, salario);
                    break;
                    default:
                        Console.WriteLine("Código informado é inválido!");
                        break;
                }
            } while (this.opcao != 0);//fim do escolha
        }//fim da executar operação
    }
}
