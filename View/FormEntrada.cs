using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTesteSistemaEstacionamento
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            lblDataAtual.Text = DateTime.Now.ToShortDateString();
        }

        private void btnHoraEntrada_Click(object sender, EventArgs e)
        {
            //Recebe o resultado da inclusão do registro de entrada
            int resultado = Control.BAL.VagasBAL.AdicionarVaga(lblDataAtual.Text, maskedTxtPlaca.Text.ToUpper(), maskedTxtHoraEntrada.Text);

            if (resultado < 0)
            {
                MessageBox.Show(Control.BAL.ErroBAL.MensagemErro(resultado));
            }
            else
            {
                maskedTxtPlaca.Clear();
                maskedTxtHoraEntrada.Clear();
                new FormPrincipal().Show();
                this.Hide();
            }
        }


        private void FormEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormPrincipal().Show();
            this.Hide();
        }


    }
}
