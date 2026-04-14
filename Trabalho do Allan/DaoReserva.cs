using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_do_Allan
{
    class DaoReserva
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public int[] codigo;
        public string[] descricao;
        public string[] editoria;
        public int[] quantidade;
        public decimal[] precoUnitario;
        public int i;
        public int contar;
        public string msg;

        public DaoReserva()
        { //conexão com banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=acesso;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//abrir a conexão
                Console.WriteLine("Conectado com sucesso!");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Algo deu errado!\n\n {erro}");
                conexao.Close();//fecha conexão com o banco de dados
            }//fim do try_catch
        }//fim do construtor

        public void PreencherVetor()
        {
            string query = "select * from livro"; //mostrando os dados da tabela autor

            //instalando os vetor
            this.codigo = new int[100];
            this.descricao = new string[100];
            this.editoria = new string[100];
            this.quantidade = new int[100];
            this.precoUnitario = new decimal[100];

            //Preencher os vetores com valores padrões
            for (i = 0; i < 100; i++)
            {
                this.codigo[i] = 0;
                this.descricao[i] = "";
                this.editoria[i] = "";
                this.quantidade[i] = 0;
                this.precoUnitario[i] = 0;
            }//fim do for

            //executar comando do SQL
            MySqlCommand coletar = new MySqlCommand(query, this.conexao);

            //leitura do dado no banco
            MySqlDataReader leitura = coletar.ExecuteReader();//percorre o banco e traz os dados

            //Zerar o contador

            i = 0;
            this.contar = 0;
            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.descricao[i] = leitura["descricao"] + "";
                this.editoria[i] = leitura["editoria"] + "";
                this.quantidade[i] = Convert.ToInt32(leitura["quantidade"]);
                this.precoUnitario[i] = Convert.ToInt32(leitura["precoUnitario"]);
                i++;
                this.contar++;//informa quantos dados tem no banco
            }//fim do while

            leitura.Close();
        }//fim do método PreencherVetor

        public string ConsultarTudo()
        {
            PreencherVetor();//preencher todos oos dados do vetor
            this.msg = "";

            for (int i = 0; i < this.contar; i++)
            {
                this.msg += $"\n Código: {this.codigo[i]} \nDescrição: {this.descricao[i]} \nEditoria: {this.editoria[i]} \nQuantidade: {this.quantidade[i]}" +
                    $"\nPreço Unitario: {this.precoUnitario[i]}";
            }//fim do for
            return this.msg;
        }//fim do método consultarTudo

        public string ConsultarPorCodigo(int codigo)
        {
            PreencherVetor();//preencher todos os dados do vetor
            this.msg = "";

            for (int i = 0; i < this.contar; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    this.msg = $"\n Código: {this.codigo[i]} \nDescrição: {this.descricao[i]} \nEditoria: {this.editoria[i]} \nQuantidade: {this.quantidade[i]}\n " +
                        $"\nPreço Unitario: {this.precoUnitario[i]}";
                    return this.msg;
                }//fim do if
            }//fim do for
            return "Código informado não existe";
        }//fim do método consultarPorCodigo
    }
}
