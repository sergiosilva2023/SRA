using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRA.Relatorios
{
    public partial class FrmRelatorioAtletas : Form
    {
        public FrmRelatorioAtletas()
        {
            InitializeComponent();
        }

        private void FrmRelatorioAtletas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sraDataSet.escolasfutebol'. Você pode movê-la ou removê-la conforme necessário.
            this.escolasfutebolTableAdapter.Fill(this.db_sraDataSet.escolasfutebol);

            this.reportViewer1.RefreshReport();
        }
    }
}
