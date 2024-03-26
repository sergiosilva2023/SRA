using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SRA
{
    public partial class frmPrincipal : Form
    {
        // instanciar a classe conexão
        Conexao conetar = new Conexao();
        String sql;
        MySqlCommand cmd;
        String idescolas;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void formatargridView()
        {
            gridView.Columns[0].HeaderText = "ID-ESCOLAS";
            gridView.Columns[1].HeaderText = "NOME-ATLETA";
            gridView.Columns[2].HeaderText = "NIF-ATLETA";
            gridView.Columns[3].HeaderText = "DATA-ENTRADA";
            gridView.Columns[4].HeaderText = "NUM-SOCIO-ATLETA";
            gridView.Columns[5].HeaderText = "TEL-ATLETA";
            gridView.Columns[6].HeaderText = "DATA-NASCI-ATLETA";
            gridView.Columns[7].HeaderText = "BI-CC-ATLETA";
            gridView.Columns[8].HeaderText = "MORADA-ATLETA";
            gridView.Columns[9].HeaderText = "EXAME-MEDICO";
            gridView.Columns[10].HeaderText = "REINSCRICAO";
            gridView.Columns[11].HeaderText = "MENSALIDADE";
            gridView.Columns[12].HeaderText = "NOME-RES";
            gridView.Columns[13].HeaderText = "MORADA-RESPONSAVEL";
            gridView.Columns[14].HeaderText = "TEL-RESPONSAVEL";
            gridView.Columns[15].HeaderText = "NUM-SOCIO-RES";
            gridView.Columns[16].HeaderText = "BI-CC-RES";
            gridView.Columns[17].HeaderText = "NIF-RES";
            gridView.Columns[18].HeaderText = "DATA-NASCI-RES";
            gridView.Columns[19].HeaderText = "EMAIL1";
            gridView.Columns[20].HeaderText = "EMAIL2";
            gridView.Columns[21].HeaderText = "EQUIPAMENTO";
            gridView.Columns[22].HeaderText = "INSCRICAO";
            gridView.Columns[0].Visible = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // carrega tudo ao abrir
           listargridView();
        }

        private void listargridView()
        {
            conetar.abrirConexao();
            sql = "SELECT * FROM escolasfutebol ORDER BY NOMEATLETA ASC";
            cmd = new MySqlCommand(sql, conetar.con);
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable dt = new DataTable();
            data.Fill(dt);
            gridView.DataSource = dt;
            conetar.fecharConexao();
            formatargridView();
        }




        // metodo para desativar botões
        private void desativarBotoes()
        {
            btnNovo.Enabled = false;
            btnGravar.Enabled = false;
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = false;
        }
        // metodo para ativar botões
        private void ativarBotoes()
        {
            btnNovo.Enabled = true;
            btnGravar.Enabled = true;
            btnEditar.Enabled = true;
            btnApagar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtNomeAtleta.Focus();
        }
        // método para limpar os campos
        private void limparDados()
        {
            txtNomeAtleta.Text = string.Empty;
            txtNifAtleta.Text= string.Empty;
            txtBiAtleta.Text = string.Empty;
            txtDataEntrada.Text = string.Empty;
            txtTelAtleta.Text = string.Empty;
            txtSocioAtleta.Text = string.Empty;
            txtMoradaAtleta.Text = string.Empty;
            txtExame.Text = string.Empty;
            txtNumInscricao.Text = string.Empty;
            txtNasciAtleta.Text = string.Empty;
            txtNomeRes.Text = string.Empty;
            txtTelRes.Text = string.Empty;
            txtEmail1.Text = string.Empty;
            txtEmail2.Text = string.Empty;
            txtSocioRes.Text = string.Empty;
            txtMoradaRes.Text = string.Empty;
            txtNasciRes.Text = string.Empty;
            txtBoxReinscricao.Text = string.Empty;
            txtMensalidade.Text = string.Empty;
            txtNifRes.Text = string.Empty;
            txtBiRes.Text = string.Empty;
            txtEquipamento.Text = string.Empty;
            txtNumInscricao.Text = string.Empty;
        }
        private void ativarCampos()
        {
            txtNomeAtleta.Enabled=true;
            txtNifAtleta.Enabled=true;
            txtBiAtleta.Enabled=true;
            txtDataEntrada.Enabled=true;
            txtTelAtleta.Enabled=true;
            txtSocioAtleta.Enabled = true;
            txtMoradaAtleta.Enabled = true;
            txtExame.Enabled = true;
            txtNumInscricao.Enabled = true;
            txtNasciAtleta.Enabled = true;
            txtNomeRes.Enabled = true;
            txtTelRes.Enabled = true;
            txtEmail1.Enabled = true;
            txtEmail2.Enabled = true;
            txtSocioRes.Enabled = true;
            txtMoradaRes.Enabled = true;
            txtNasciRes.Enabled = true;
            txtBoxReinscricao.Enabled=true;
            txtMensalidade.Enabled=true;
            txtNifRes.Enabled = true;
            txtBiRes.Enabled = true;
            txtEquipamento.Enabled = true;
        }
        private void desativarCampos()
        {
            txtNomeAtleta.Enabled = false;
            txtNifAtleta.Enabled = false;
            txtBiAtleta.Enabled = false;
            txtDataEntrada.Enabled = false;
            txtTelAtleta.Enabled = false;
            txtSocioAtleta.Enabled = false;
            txtMoradaAtleta.Enabled = false;
            txtExame.Enabled = false;
            txtNumInscricao.Enabled = false;
            txtNasciAtleta.Enabled = false;
            txtNomeRes.Enabled = false;
            txtTelRes.Enabled = false;
            txtEmail1.Enabled = false;
            txtEmail2.Enabled = false;
            txtSocioRes.Enabled = false;
            txtMoradaRes.Enabled = false;
            txtNasciRes.Enabled = false;
            txtBoxReinscricao.Enabled = false;
            txtMensalidade.Enabled = false;
            txtNifRes.Enabled = false;
            txtBiRes.Enabled = false;
            txtEquipamento.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ativarBotoes();
            limparDados();
            ativarCampos();
            txtNomeAtleta.Focus();
            btnNovo.Enabled=false;
            btnApagar.Enabled=false;
            btnEditar.Enabled=false;
            txtPesquisar.Enabled=false;
            btnPesquisar.Enabled =false;
            gridView.Enabled=false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desativarBotoes();
            limparDados();
            desativarCampos();
            btnNovo.Enabled=true;
            txtPesquisar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNomeAtleta.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite o nome do atleta");
                txtNomeAtleta.Text = "";
                txtNomeAtleta.Focus();
                return;
            }
            if (txtNifAtleta.Text.Trim() == "")
            {
                MessageBox.Show("Digite o Nif do atleta");
                txtNifAtleta.Text = "";
                txtNifAtleta.Focus();
                return;
            }
            if (txtBiAtleta.Text.Trim() == "")
            {
                MessageBox.Show("Digite o BI/CC do atleta");
                txtBiAtleta.Text = "";
                txtBiAtleta.Focus();    
                return;
            }
            if(txtDataEntrada.Text.Trim()== "")
            {
                MessageBox.Show("Digite a data de entrada");
                txtDataEntrada.Text = "";
                txtDataEntrada.Focus();
                return;
            }

            // inserir dados na tabela
            conetar.abrirConexao();
            sql = "INSERT INTO escolasfutebol (dataentrada, reinscricao, numsocioatleta, examemedico, nomeatleta, telefoneatleta, biccatleta, nifatleta, datanasciatleta, mensalidade, nomeres, moradaatleta, moradares, telefoneres, numsociores, biccres, nifres, datanascires, email1, email2, equipamento, inscricao) VALUES (@dataentrada, @reinscricao, @numsocioatleta, @examemedico, @nomeatleta, @telefoneatleta, @biccatleta, @nifatleta, @datanasciatleta, @mensalidade, @nomeres, @moradaatleta, @moradares, @telefoneres, @numsociores, @biccres, @nifres, @datanascires, @email1, @email2, @equipamento, @inscricao)";
            cmd = new MySqlCommand (sql, conetar.con);
            cmd.Parameters.AddWithValue("@dataentrada", txtDataEntrada.Text);
            cmd.Parameters.AddWithValue("@reinscricao", txtBoxReinscricao.Text);
            cmd.Parameters.AddWithValue("@numsocioatleta", txtSocioAtleta.Text);
            cmd.Parameters.AddWithValue("@examemedico", txtExame.Text);
            cmd.Parameters.AddWithValue("@nomeatleta", txtNomeAtleta.Text);
            cmd.Parameters.AddWithValue("@telefoneatleta", txtTelAtleta.Text);
            cmd.Parameters.AddWithValue("@biccatleta", txtBiAtleta.Text);
            cmd.Parameters.AddWithValue("@nifatleta", txtNifAtleta.Text);
            cmd.Parameters.AddWithValue("@datanasciatleta", txtNasciAtleta.Text);
            cmd.Parameters.AddWithValue("@mensalidade", txtMensalidade.Text);
            cmd.Parameters.AddWithValue("@nomeres", txtNomeRes.Text);
            cmd.Parameters.AddWithValue("@moradaatleta", txtMoradaAtleta.Text);
            cmd.Parameters.AddWithValue("@moradares", txtMoradaRes.Text);
            cmd.Parameters.AddWithValue("@telefoneres", txtTelRes.Text);
            cmd.Parameters.AddWithValue("@numsociores", txtSocioRes.Text);
            cmd.Parameters.AddWithValue("@biccres", txtBiRes.Text);
            cmd.Parameters.AddWithValue("@nifres", txtNifRes.Text);
            cmd.Parameters.AddWithValue("@datanascires", txtNasciRes.Text);
            cmd.Parameters.AddWithValue("@email1", txtEmail1.Text);
            cmd.Parameters.AddWithValue("@email2", txtEmail2.Text);
            cmd.Parameters.AddWithValue("@equipamento", txtEquipamento.Text);
            cmd.Parameters.AddWithValue("@inscricao", txtNumInscricao.Text);

            cmd.ExecuteNonQuery();
            conetar.fecharConexao();
            desativarBotoes();
            limparDados();
            desativarCampos();
            btnNovo.Enabled = true;
            MessageBox.Show("Dados gravados com sucesso!","Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listargridView();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            desativarBotoes();
            limparDados();
            desativarCampos();
            btnNovo.Enabled = true;
            MessageBox.Show("Deseja apagar este registo?","Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            listargridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            conetar.abrirConexao();
            sql = "UPDATE escolasfutebol SET dataentrada=@dataentrada, reinscricao=@reinscricao, numsocioatleta=@numsocioatleta, examemedico=@examemedico, nomeatleta=@nomeatleta, telefoneatleta=@telefoneatleta, biccatleta=@biccatleta, nifatleta=@nifatleta, datanasciatleta=@datanasciatleta, mensalidade=@mensalidade, nomeres=@nomeres, moradaatleta=@moradaatleta, moradares=@moradares, telefoneres=@telefoneres, numsociores=@numsociores, biccres=@biccres, nifres=@nifres, datanascires=@datanascires, email1=@email1, email2=@email2, equipamento=@equipamento, inscricao=@inscricao WHERE idescolas=@idescolas";
            cmd = new MySqlCommand(sql, conetar.con);
            cmd.Parameters.AddWithValue("@idescolas", idescolas);
            cmd.Parameters.AddWithValue("@dataentrada", txtDataEntrada.Text);
            cmd.Parameters.AddWithValue("@reinscricao", txtBoxReinscricao.Text);
            cmd.Parameters.AddWithValue("@numsocioatleta", txtSocioAtleta.Text);
            cmd.Parameters.AddWithValue("@examemedico", txtExame.Text);
            cmd.Parameters.AddWithValue("@nomeatleta", txtNomeAtleta.Text);
            cmd.Parameters.AddWithValue("@telefoneatleta", txtTelAtleta.Text);
            cmd.Parameters.AddWithValue("@biccatleta", txtBiAtleta.Text);
            cmd.Parameters.AddWithValue("@nifatleta", txtNifAtleta.Text);
            cmd.Parameters.AddWithValue("@datanasciatleta", txtNasciAtleta.Text);
            cmd.Parameters.AddWithValue("@mensalidade", txtMensalidade.Text);
            cmd.Parameters.AddWithValue("@nomeres", txtNomeRes.Text);
            cmd.Parameters.AddWithValue("@moradaatleta", txtMoradaAtleta.Text);
            cmd.Parameters.AddWithValue("@moradares", txtMoradaRes.Text);
            cmd.Parameters.AddWithValue("@telefoneres", txtTelRes.Text);
            cmd.Parameters.AddWithValue("@numsociores", txtSocioRes.Text);
            cmd.Parameters.AddWithValue("@biccres", txtBiRes.Text);
            cmd.Parameters.AddWithValue("@nifres", txtNifRes.Text);
            cmd.Parameters.AddWithValue("@datanascires", txtNasciRes.Text);
            cmd.Parameters.AddWithValue("@email1", txtEmail1.Text);
            cmd.Parameters.AddWithValue("@email2", txtEmail2.Text);
            cmd.Parameters.AddWithValue("@equipamento", txtEquipamento.Text);
            cmd.Parameters.AddWithValue(@"inscricao", txtNumInscricao.Text);
            cmd.ExecuteNonQuery();
            conetar.fecharConexao();
            desativarBotoes();
            limparDados();
            desativarCampos();
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            MessageBox.Show("Dados editados com sucesso!","Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listargridView();
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ativarBotoes();
            btnNovo.Enabled=false;
            btnGravar.Enabled=false;
            ativarCampos();

            idescolas = gridView.CurrentRow.Cells[0].Value.ToString();

            txtNomeAtleta.Text = gridView.CurrentRow.Cells[1].Value.ToString();
            txtNifAtleta.Text = gridView.CurrentRow.Cells[2].Value.ToString();
            txtDataEntrada.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            txtSocioAtleta.Text = gridView.CurrentRow.Cells[4].Value.ToString();
            txtTelAtleta.Text = gridView.CurrentRow.Cells[5].Value.ToString();
            txtNasciAtleta.Text = gridView.CurrentRow.Cells[6].Value.ToString();
            txtBiAtleta.Text = gridView.CurrentRow.Cells[7].Value.ToString();
            txtMoradaAtleta.Text = gridView.CurrentRow.Cells[8].Value.ToString();
            txtExame.Text = gridView.CurrentRow.Cells[9].Value.ToString();
            txtBoxReinscricao.Text = gridView.CurrentRow.Cells[10].Value.ToString();
            txtMensalidade.Text = gridView.CurrentRow.Cells[11].Value.ToString();
            txtNomeRes.Text = gridView.CurrentRow.Cells[12].Value.ToString();
            txtMoradaRes.Text = gridView.CurrentRow.Cells[13].Value.ToString();
            txtTelRes.Text = gridView.CurrentRow.Cells[14].Value.ToString();
            txtSocioRes.Text = gridView.CurrentRow.Cells[15].Value.ToString();
            txtBiRes.Text = gridView.CurrentRow.Cells[16].Value.ToString();
            txtNifRes.Text = gridView.CurrentRow.Cells[17].Value.ToString();
            txtNasciRes.Text = gridView.CurrentRow.Cells[18].Value.ToString();
            txtEmail1.Text = gridView.CurrentRow.Cells[19].Value.ToString();
            txtEmail2.Text = gridView.CurrentRow.Cells[20].Value.ToString();
            txtEquipamento.Text = gridView.CurrentRow.Cells[21].Value.ToString();
            txtNumInscricao.Text = gridView.CurrentRow.Cells[22].Value.ToString();
        }
    }
}
