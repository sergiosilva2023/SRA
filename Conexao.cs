using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRA
{
    internal class Conexao
    {   // string de conexão local
        public string conec = "SERVER=localhost; DATABASE=db_sra; UID=root; PWD=; PORT=;";

        // string de conexão remota
        //public string conec = "SERVER=mysql835.umbler.com; DATABASE=db_sra; UID=srauserdb2024; PWD=s((4x)2H]W; PORT=41890;";
        //public string conec = "SERVER=5.135.143.184; DATABASE=restaur2_db_sra; UID=restaur2_user_dbsra; PWD=dbsra2024sistema; PORT=;";

        // variavél de ligação
        public MySqlConnection con = null;

        // abrir a conexão sql
        public void abrirConexao()
        {
            // testar a conexão
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro do servidor ao ligar á base de dados: ==>" + ex.Message);
            }
            
        }

        // fechar a conexão
        public void fecharConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro do servidor ao encerrar a base de dados!" + ex.Message);
            }
        }
    }
}
