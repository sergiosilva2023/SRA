using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRA 
{
    public partial class FrmLogin: Form
    {
        // abrir ligação ao banco de dados
        Conexao conetar = new Conexao();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // autenticação para login
            if (txtNome.Text.ToString().Trim() == "" || txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Dgite os dados de acesso!");
                txtNome.Focus();
                txtNome.Text= string.Empty;
                return;
            }

            try
            {

                // para efetuar a ligação na tabela do banco de dados
                conetar.abrirConexao();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader;
                cmdVerificar = new MySqlCommand("SELECT * FROM login WHERE nome=@nome AND senha=@senha", conetar.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@nome", txtNome.Text);
                cmdVerificar.Parameters.AddWithValue("@senha", txtSenha.Text);
                reader = cmdVerificar.ExecuteReader();

                if (reader.HasRows)
                {
                    FrmMenu frm = new FrmMenu();
                    frm.ShowDialog();
                    this.Close();
                    
                } else
                {
                    MessageBox.Show("Dados incorretos!", "Acesso ao sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } 

            catch (Exception)
            {

            }



        }
    }
}
