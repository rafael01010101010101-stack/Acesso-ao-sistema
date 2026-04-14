using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_do_Allan
{
    class ControlCompra
    {
        DaoCompra compra;
        public int opcao;

        public ControlCompra()
        {
            compra = new DaoCompra();
        }

        public void MostrarMenu()
        {
            Console.WriteLine("------MENU------\n\n" +
                "\n0.Sair" +
                "\n1.Pagamento do livro" +
                "\nEscolha uma das opções acima:");
            this.opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void ExecutarOperacao()
        {
            do
            {
                this.compra = new DaoCompra();
                this.MostrarMenu();
                switch (this.opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                    break;

                    case 1:
                        Console.WriteLine(this.compra.ConsultarTudo());
                        Console.WriteLine("Escolha um dos livros acima: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe a forma de pagamento: ");
                            string cartao = Console.ReadLine();
                            Console.WriteLine("Insira a senha: ");
                            int senha = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Pago com sucesso!");
                    break;

                    default:
                        Console.WriteLine("Código informado é inválido!");
                    break;
                }
            } while (this.opcao != 0);//fim do escolha
        }//fim da executar operação
    }
}
