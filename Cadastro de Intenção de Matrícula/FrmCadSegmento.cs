using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadastro_de_Intenção_de_Matrícula
{
    public partial class FrmCadSegmento : Form
    {
        public FrmCadSegmento()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DAO insere = new DAO();
            if (insere.inserirSegmento(txtDescSeg.Text) == true)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtDescSeg.Text = "";
                txtDescSeg.Focus();
            }
        }

        private void FrmCadSegmento_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
