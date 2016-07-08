using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Intenção_de_Matrícula
{
    public class ConexaoBancoMySQL
    {
        private static MySqlConnection objConexao = null;

        //string mysql rodando na maquina do desenvolvedor.
        private String stringconnection1 = "server=localhost;User Id=root;password=;database=intencoes_matricula";

        // string mysql acessa o banco do servidor de hospedagem
        private String stringconnection2 = "server=192.168.6.100;User Id=admin;password=yb5731;database=intencoes_matricula";

        #region metodos que tentam abrir conexao com projeto rodando local ou hospedado

        public void tentarAbrirConexaoLocal()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection1;
            objConexao.Open();
        }

        public void tentarAbrirConexaoRemota()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection2;
            objConexao.Open();
        }
        #endregion

        public ConexaoBancoMySQL()
        {
            try
            {
                tentarAbrirConexaoRemota();
            }
            catch
            {
                try
                {
                    tentarAbrirConexaoLocal();
                }
                catch
                {
                    Console.WriteLine("Não foi possível validar seu acesso. Tente novamente.");
                    // Você pode substituir esta notificação por qualquer outra coisa que faça o mesmo que o metodo console.whiteline
                }
            }
        }

        public MySqlConnection getConexao()
        {
            new ConexaoBancoMySQL();
            return objConexao;
        }
        public static void fecharConexao()
        {
            objConexao.Close();
        }
    }
}