using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_do_Allan
{
    class ControlReserva
    {
        DaoReserva reserva;
        public int opcao;

        public ControlReserva()
        {
            reserva = new DaoReserva();
        }

        public void MostrarMenu()
        {
            Console.WriteLine("------MENU------\n\n" +
                "\n0.Sair" +
                "\n1.Reserva do livro" +
                "\nEscolha uma das opções acima:");
            this.opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void ExecutarOperacao()
        {
            do
            {
                this.reserva = new DaoReserva();
                this.MostrarMenu();
                switch (this.opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(this.reserva.ConsultarTudo());
                        Console.WriteLine("Escolha um dos livros acima: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        if(codigo != codigo) 
                        {
                            Console.WriteLine("Informe o nome do livro que vamos preparar a reserva");
                        }
                        else
                            Console.WriteLine("Parabéns pela escolha! Aguarde a entrega do livro");
                        break;
                    default:
                        Console.WriteLine("Código informado é inválido!");
                        break;
                }
            } while (this.opcao != 0);//fim do escolha
        }//fim da executar operação
    }
}
