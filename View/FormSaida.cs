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
    public partial class FormSaida : Form
    {
        public FormSaida()
        {
            InitializeComponent();
        }

        private void Saida_Load(object sender, EventArgs e)
        {
            cbPlacas.DataSource = Control.BAL.VagasBAL.MostraPlaca();
            btnConfirmar.Visible = false;
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            //Busca a hora de entrada da placa selecionada
            Model.DAL.VagasDal.BuscaHoraEntrada(cbPlacas.Text);
            TimeSpan horaSaida = new TimeSpan();

            //Verifica se a hora de saída foi informada corretamente
            if (maskedTxtHoraSaida.Text.Length == 5)
            {
                horaSaida = TimeSpan.Parse(maskedTxtHoraSaida.Text);

                //Recebe o resultado do cálculo do valor a pagar
                int resultado = Convert.ToInt32(Control.BAL.SaidaBal.ValorPagar(horaSaida, cbPlacas.Text));
                if (resultado < 0)
                {
                    MessageBox.Show(Control.BAL.ErroBAL.MensagemErro(resultado));
                }

                lblTotalPagar.Text = resultado.ToString("C");

                btnConfirmar.Visible = true;
            }
            else
            {
                MessageBox.Show(Control.BAL.ErroBAL.MensagemErro(-2));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Realiza a exclusão do registro, liberando a vaga do estacionamento
            Control.BAL.SaidaBal.LiberaVaga(cbPlacas.Text);

            new FormPrincipal().Show();
            this.Hide();
        }

        private void FormSaida_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormPrincipal().Show();
            this.Hide();
        }


    }
}
