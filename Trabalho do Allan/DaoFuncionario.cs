using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_do_Allan
{
    class DaoFuncionario
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;

        public DaoFuncionario()
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

        public void Inserir(string nome, string endereco, string telefone, string cargo, decimal salario)
        {
            try
            {
                this.dados = $"('', '{nome}', '{endereco}', '{telefone}', '{cargo}', '{salario}')";
                this.comando = $"Insert into autor(codigo, nome, endereco, telefone, cargo, salario) values{this.dados}";
                //Inserir comando
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                Console.WriteLine($"Inserido com Sucesso! \n\n{resultado}");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Algo deu errado\n\n {erro}");
            }
        }//fim do inserir
    }
}
