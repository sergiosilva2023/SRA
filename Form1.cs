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
using System.IO;
using System.Diagnostics;

namespace SRA
{
    public partial class frmPrincipal : Form
    {
        // instanciar a classe conexão
        Conexao conetar = new Conexao();
        String sql;
        MySqlCommand cmd;
        String idescolas;
        String foto;

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
            gridView.Columns[23].HeaderText = "FOTO";
            gridView.Columns[24].HeaderText = "NOVAINSCRICAO";
            // ocultar estes grids abaixo no gridView
            gridView.Columns[0].Visible = false;
            gridView.Columns[23].Visible = false;
            gridView.Columns[6].Visible = false;
            gridView.Columns[7].Visible = false;
            gridView.Columns[8].Visible = false;
            gridView.Columns[9].Visible = false;
            gridView.Columns[10].Visible = false;
            gridView.Columns[11].Visible = false;
            gridView.Columns[12].Visible = false;
            gridView.Columns[13].Visible = false;
            gridView.Columns[14].Visible = false;
            gridView.Columns[15].Visible = false;
            gridView.Columns[16].Visible = false;
            gridView.Columns[17].Visible = false;
            gridView.Columns[18].Visible = false;
            gridView.Columns[19].Visible = false;
            gridView.Columns[20].Visible = false;
            gridView.Columns[21].Visible = false;
            gridView.Columns[24].Visible = false;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // carrega tudo ao abrir
            limparFoto();
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
        // método para ativar campos
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
            image.Enabled = true;
        }
        // método para desativar campos
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
        // método para pesquisar nome
        private void pesquisarNome()
        {
            conetar.abrirConexao();
            sql = "SELECT * FROM escolasfutebol WHERE nomeatleta LIKE @nomeatleta ORDER BY nomeatleta ASC";
            cmd = new MySqlCommand(sql, conetar.con);
            cmd.Parameters.AddWithValue("@nomeatleta", txtPesquisar.Text + "%");
            conetar.fecharConexao();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable dt = new DataTable();
            data.Fill(dt);
            gridView.DataSource = dt;
            conetar.fecharConexao();
            formatargridView();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ativarBotoes();
            limparDados();
            limparFoto();
            ativarCampos();
            txtNomeAtleta.Focus();
            btnNovo.Enabled=false;
            btnApagar.Enabled=false;
            btnEditar.Enabled=false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desativarBotoes();
            limparDados();
            desativarCampos();
            btnNovo.Enabled=true;
            txtPesquisar.Enabled = true;
            btnPesquisar.Enabled = true;
            limparFoto();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNomeAtleta.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite o nome do atleta", "Gravar dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeAtleta.Text = "";
                txtNomeAtleta.Focus();
                return;                
            }

            if (txtNomeAtleta.Text.ToString().Length < 10)
            {
                MessageBox.Show("[ERRO] => nome demasiado curto!");
                txtNomeAtleta.Text = "";
                txtNomeAtleta.Focus();
                return;
            }

            if (txtNifAtleta.Text.Trim() == "")
            {
                MessageBox.Show("Digite o NIF do atleta", "Gravar dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNifAtleta.Text = "";
                txtNifAtleta.Focus();
                return;
            }
            if (txtBiAtleta.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nº BI/CC do atleta", "Gravar dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            sql = "INSERT INTO escolasfutebol (dataentrada, reinscricao, numsocioatleta, examemedico, nomeatleta, telefoneatleta, biccatleta, nifatleta, datanasciatleta, mensalidade, nomeres, moradaatleta, moradares, telefoneres, numsociores, biccres, nifres, datanascires, email1, email2, equipamento, inscricao, fotoatleta, novainscricao) VALUES (@dataentrada, @reinscricao, @numsocioatleta, @examemedico, @nomeatleta, @telefoneatleta, @biccatleta, @nifatleta, @datanasciatleta, @mensalidade, @nomeres, @moradaatleta, @moradares, @telefoneres, @numsociores, @biccres, @nifres, @datanascires, @email1, @email2, @equipamento, @inscricao, @fotoatleta, @novainscricao)";
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
            cmd.Parameters.AddWithValue("@fotoatleta", img()); // método img()
            cmd.Parameters.AddWithValue("@novainscricao", txtNovaInscricao.Text);

            cmd.ExecuteNonQuery();
            conetar.fecharConexao();
            desativarBotoes();
            limparDados();
            desativarCampos();
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            txtPesquisar.Enabled = true;
           
            MessageBox.Show("Dados gravados com sucesso!","Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparFoto();
            listargridView();
            gridView.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja apagar este registo?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {

                conetar.abrirConexao();
                sql = "DELETE FROM escolasfutebol WHERE idescolas=@idescolas";
                cmd = new MySqlCommand(sql, conetar.con);
                cmd.Parameters.AddWithValue("@idescolas", idescolas);
                cmd.ExecuteNonQuery();
                conetar.fecharConexao();
                desativarBotoes();
                limparDados();
                desativarCampos();
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                listargridView();
                MessageBox.Show("Dados apagados com sucesso!", "Apagar registo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            conetar.abrirConexao();
            sql = "UPDATE escolasfutebol SET dataentrada=@dataentrada, reinscricao=@reinscricao, numsocioatleta=@numsocioatleta, examemedico=@examemedico, nomeatleta=@nomeatleta, telefoneatleta=@telefoneatleta, biccatleta=@biccatleta, nifatleta=@nifatleta, datanasciatleta=@datanasciatleta, mensalidade=@mensalidade, nomeres=@nomeres, moradaatleta=@moradaatleta, moradares=@moradares, telefoneres=@telefoneres, numsociores=@numsociores, biccres=@biccres, nifres=@nifres, datanascires=@datanascires, email1=@email1, email2=@email2, equipamento=@equipamento, inscricao=@inscricao, novainscricao=@novainscricao , fotoatleta=@fotoatleta WHERE idescolas=@idescolas";
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
            cmd.Parameters.AddWithValue("@inscricao", txtNumInscricao.Text);
            cmd.Parameters.AddWithValue("@novainscricao", txtNovaInscricao.Text);
            cmd.Parameters.AddWithValue("@fotoatleta", image);
            cmd.ExecuteNonQuery();
            conetar.fecharConexao();
            desativarBotoes();
            limparDados();
            limparFoto();
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
            txtPesquisar.Enabled = true;
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
            image.Text = gridView.CurrentRow.Cells[23].Value.ToString();
            txtNovaInscricao.Text = gridView.CurrentRow.Cells[24].Value.ToString();
            
            // pegar a foto
            if (gridView.CurrentRow.Cells[23].Value != DBNull.Value)
            {
                byte[] imagem = (byte[])gridView.Rows[e.RowIndex].Cells[23].Value;
                MemoryStream ms = new MemoryStream(imagem);
                image.Image = Image.FromStream(ms);
            } else
            {
                limparFoto();
            }
        }



        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisarNome();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fotos(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png;"; // carregar os tipos de ficheiro
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // pega o caminho da imagen selecionada e joga no imgage
                foto = dialog.FileName.ToString();
                image.ImageLocation = foto;
            }
        }

        private byte [] img()
        {
            byte[] imagem_byte = null;
            if (foto == "")
            {
                return null;
            }
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }

        // método limpar foto
        private void limparFoto()
        {
            image.Image = Properties.Resources.logo;
            foto = "ft/perfil.png";

        }

    }
}
