namespace SRA.Relatorios
{
    partial class FrmRelatorioAtletas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioAtletas));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_sraDataSet = new SRA.db_sraDataSet();
            this.escolasfutebolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escolasfutebolTableAdapter = new SRA.db_sraDataSetTableAdapters.escolasfutebolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_sraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolasfutebolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEscolas";
            reportDataSource1.Value = this.escolasfutebolBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SRA.Relatorios.RelAtletas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(830, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_sraDataSet
            // 
            this.db_sraDataSet.DataSetName = "db_sraDataSet";
            this.db_sraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // escolasfutebolBindingSource
            // 
            this.escolasfutebolBindingSource.DataMember = "escolasfutebol";
            this.escolasfutebolBindingSource.DataSource = this.db_sraDataSet;
            // 
            // escolasfutebolTableAdapter
            // 
            this.escolasfutebolTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioAtletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 394);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorioAtletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Atletas";
            this.Load += new System.EventHandler(this.FrmRelatorioAtletas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_sraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolasfutebolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_sraDataSet db_sraDataSet;
        private System.Windows.Forms.BindingSource escolasfutebolBindingSource;
        private db_sraDataSetTableAdapters.escolasfutebolTableAdapter escolasfutebolTableAdapter;
    }
}