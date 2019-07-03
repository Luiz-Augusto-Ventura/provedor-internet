using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void radioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadio FR = new FrmRadio();
            FR.ShowDialog();
        }

        private void torreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTorre FT = new FrmTorre();
            FT.ShowDialog();
        }

        private void planoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlano FP = new FrmPlano();
            FP.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente FC = new FrmCliente();
            FC.ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExportar FE = new FrmExportar();
            FE.ShowDialog();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportar FI = new FrmImportar();
            FI.ShowDialog();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio FR = new FrmRelatorio();
            FR.ShowDialog();
        }
    }
}
