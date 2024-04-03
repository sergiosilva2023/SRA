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
    public partial class FrmMenu : Form
    {
        
        public FrmMenu()
        {
            InitializeComponent();
            
        }

        private void menuEscolas_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.MdiParent = this;
            frm.Show();
        }



        private void menuSistema_Click(object sender, EventArgs e)
        {
            FrmAjuda frm = new FrmAjuda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relatorioAtletas_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelatorioAtletas frm = new Relatorios.FrmRelatorioAtletas();
            frm.MdiParent = this;
            frm.Show();
        }


    }
}
