using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_do_Allan
{
    class DaoCliente
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        

        public class Cliente
        {
            public string Login { get; set; }
            public string Senha { get; set; }
        }

        public DaoCliente()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=Acesso;Uid=root;Password=;Convert Zero DateTime=True");
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
        }

        public void Cadastrar(string nome, string telefone, string endereco, DateTime dataNascimento, string login, string senha)
        {
            try
            {
                this.dados = $"('', '{nome}', '{telefone}', '{endereco}', '{dataNascimento}', '{login}', '{senha}')";
                this.comando = $"Insert into cliente(codigo, nome, endereco, dataNascimento, login, senha) values{this.dados}";
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

        public bool ValidarLogin(string login, string senha)
        {
            try
            {
                string query = "SELECT * FROM cliente WHERE login = @login AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro ao validar login: {erro}");
                return false;
            }
        }
    }
}
