using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_do_Allan
{
    class ControlLivro
    {
        DaoLivro livro;
        public int opcao;

        public ControlLivro() 
        {
            livro = new DaoLivro();
        }

        public void MostrarMenu()
        {
            Console.WriteLine("------MENU------\n\n" +
                "\n0.Sair" +
                "\n1.Validar Login e senha | escolha o livro" +
                "\nEscolha uma das opções acima:");
            this.opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void ExecutarOperacao()
        {
            do
            {
                this.livro = new DaoLivro();
                this.MostrarMenu();
                switch (this.opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Login: ");
                        string loginInformado = Console.ReadLine();
                        Console.WriteLine("Senha: ");
                        string senhaInformada = Console.ReadLine();
                        bool loginValido = this.livro.ValidarLogin(loginInformado, senhaInformada);
                        if (loginValido)
                        {
                            Console.WriteLine(this.livro.ConsultarTudo());
                            Console.WriteLine("Escolha um dos livros acima: ");
                            int codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Parabéns pela escolha! Aguarde a entrega do livro");
                        }
                        else
                        {
                            Console.WriteLine("Login ou senha inválidos!");
                        }
                        break;
                    default:
                        Console.WriteLine("Código informado é inválido!");
                        break;
                }
            } while (this.opcao != 0);//fim do escolha
        }//fim da executar operação
    }//fim da classe
}//fim do projeto
    

