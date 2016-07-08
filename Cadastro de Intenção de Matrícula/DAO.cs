using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Intenção_de_Matrícula
{
    class DAO
    {
        private MySqlConnection mConn = new MySqlConnection("server=192.168.6.100;User Id=admin;password=yb5731;database=intencoes_matricula");
        //private MySqlDataAdapter mAdapter;
        //private DataSet mDataSet;
        //ConexaoBancoMySQL bd = new ConexaoBancoMySQL();

        public Boolean inserirSegmento(String segmento)
        {
            mConn.Open();
            
            //Query SQL
            MySqlCommand command = new MySqlCommand("INSERT INTO segmento (descricao_segmento)" +
            "VALUES('" + segmento + "')", mConn);

            //Executa a Query SQL
            command.ExecuteNonQuery();

            // Fecha a conexão
            mConn.Close();

            //Mensagem de Sucesso
            return true;

            // Método criado para que quando o registo é gravado, automaticamente a dataGridView efectue um "Refresh"
            //mostraResultados();
        }

        public Boolean inserirSerie(String serie, int id_segmento)
        {
            mConn.Open();

            //Query SQL
            MySqlCommand command = new MySqlCommand("INSERT INTO serie (descricao_serie, id_segmento)" +
            "VALUES('" + serie + "', " + id_segmento + ")", mConn);

            //Executa a Query SQL
            command.ExecuteNonQuery();

            // Fecha a conexão
            mConn.Close();

            //Mensagem de Sucesso
            return true;

            // Método criado para que quando o registo é gravado, automaticamente a dataGridView efectue um "Refresh"
            //mostraResultados();
        }

        public static List<Segmento> retornaSegmento()
        {
            MySqlConnection mConn2 = new MySqlConnection("server=192.168.6.100;User Id=admin;password=yb5731;database=intencoes_matricula");
            string sql = "SELECT id_segmento, descricao_segmento FROM segmento";
            MySqlCommand cmd = new MySqlCommand(sql, mConn2);

            var lista = new List<Segmento>();

            mConn2.Open();

            var leitor = cmd.ExecuteReader();

            if(leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var seg = new Segmento();
                    seg.id_segmento = Convert.ToInt32(leitor["id_segmento"]);
                    seg.descricao_segmento = leitor["descricao_segmento"].ToString();
                    lista.Add(seg);
                }
            }
            mConn2.Close();
            return lista;
        }

        private void semNada()
        {

        }
    }
}