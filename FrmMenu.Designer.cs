namespace SRA
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.registoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.registoEscolas = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioAtletas = new System.Windows.Forms.ToolStripMenuItem();
            this.registoSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.registoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaConexao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoMenu,
            this.registoMenu,
            this.ajudaMenu});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // arquivoMenu
            // 
            this.arquivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoAbrir,
            this.arquivoGuardar,
            this.arquivoAjuda});
            this.arquivoMenu.Name = "arquivoMenu";
            this.arquivoMenu.Size = new System.Drawing.Size(61, 20);
            this.arquivoMenu.Text = "Arquivo";
            // 
            // arquivoAbrir
            // 
            this.arquivoAbrir.Name = "arquivoAbrir";
            this.arquivoAbrir.Size = new System.Drawing.Size(116, 22);
            this.arquivoAbrir.Text = "Abrir";
            // 
            // arquivoGuardar
            // 
            this.arquivoGuardar.Name = "arquivoGuardar";
            this.arquivoGuardar.Size = new System.Drawing.Size(116, 22);
            this.arquivoGuardar.Text = "Guardar";
            // 
            // arquivoAjuda
            // 
            this.arquivoAjuda.Name = "arquivoAjuda";
            this.arquivoAjuda.Size = new System.Drawing.Size(116, 22);
            this.arquivoAjuda.Text = "Ajuda";
            // 
            // registoMenu
            // 
            this.registoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registoEscolas,
            this.registoSocios,
            this.registoUsuarios});
            this.registoMenu.Name = "registoMenu";
            this.registoMenu.Size = new System.Drawing.Size(58, 20);
            this.registoMenu.Text = "Registo";
            // 
            // registoEscolas
            // 
            this.registoEscolas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioAtletas});
            this.registoEscolas.Name = "registoEscolas";
            this.registoEscolas.Size = new System.Drawing.Size(180, 22);
            this.registoEscolas.Text = "Escolas Futebol";
            this.registoEscolas.Click += new System.EventHandler(this.menuEscolas_Click);
            // 
            // relatorioAtletas
            // 
            this.relatorioAtletas.Name = "relatorioAtletas";
            this.relatorioAtletas.Size = new System.Drawing.Size(180, 22);
            this.relatorioAtletas.Text = "Relatório Atletas";
            this.relatorioAtletas.Click += new System.EventHandler(this.relatorioAtletas_Click);
            // 
            // registoSocios
            // 
            this.registoSocios.Name = "registoSocios";
            this.registoSocios.Size = new System.Drawing.Size(180, 22);
            this.registoSocios.Text = "Sócios";
            // 
            // registoUsuarios
            // 
            this.registoUsuarios.Name = "registoUsuarios";
            this.registoUsuarios.Size = new System.Drawing.Size(180, 22);
            this.registoUsuarios.Text = "Usuários";
            // 
            // ajudaMenu
            // 
            this.ajudaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaSistema,
            this.ajudaConexao});
            this.ajudaMenu.Name = "ajudaMenu";
            this.ajudaMenu.Size = new System.Drawing.Size(50, 20);
            this.ajudaMenu.Text = "Ajuda";
            // 
            // ajudaSistema
            // 
            this.ajudaSistema.Name = "ajudaSistema";
            this.ajudaSistema.Size = new System.Drawing.Size(121, 22);
            this.ajudaSistema.Text = "Sistema";
            this.ajudaSistema.Click += new System.EventHandler(this.menuSistema_Click);
            // 
            // ajudaConexao
            // 
            this.ajudaConexao.Name = "ajudaConexao";
            this.ajudaConexao.Size = new System.Drawing.Size(121, 22);
            this.ajudaConexao.Text = "Conexão";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::SRA.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmMenu";
            this.Text = "Sociedade Recreativa Atalaiense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoMenu;
        private System.Windows.Forms.ToolStripMenuItem registoMenu;
        private System.Windows.Forms.ToolStripMenuItem registoEscolas;
        private System.Windows.Forms.ToolStripMenuItem registoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ajudaMenu;
        private System.Windows.Forms.ToolStripMenuItem ajudaSistema;
        private System.Windows.Forms.ToolStripMenuItem arquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem arquivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem arquivoAjuda;
        private System.Windows.Forms.ToolStripMenuItem ajudaConexao;
        private System.Windows.Forms.ToolStripMenuItem registoSocios;
        private System.Windows.Forms.ToolStripMenuItem relatorioAtletas;
    }
}