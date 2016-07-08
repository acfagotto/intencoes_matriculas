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
    public partial class FrmCadSerie : Form
    {
        public FrmCadSerie()
        {
            InitializeComponent();
        }

        private void FrmCadSerie_Load(object sender, EventArgs e)
        {
            carregaCombo();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DAO insere = new DAO();
            if (insere.inserirSerie(txtSerie.Text, Convert.ToInt32(comboSegmento.SelectedValue)) == true)  
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtSerie.Text = "";
                carregaCombo();
                txtSerie.Focus();
            }
        }

        private void carregaCombo()
        {
            comboSegmento.DataSource = DAO.retornaSegmento();
            comboSegmento.DisplayMember = "descricao_segmento";
            comboSegmento.ValueMember = "id_segmento";
        }
    }
}