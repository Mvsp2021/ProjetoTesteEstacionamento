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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
            AtualizaDG();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            new FormEntrada().Show();
            this.Hide();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            new FormSaida().Show();
            this.Hide();
        }

        //Atualiza os dados do DataGridView
        public void AtualizaDG()
        {
            List<Model.Objetos.Vagas> lista = Control.BAL.VagasBAL.GetVagasPreenchidas();

            foreach (var item in lista)
            {
                dataGridView1.Rows.Add(item.DataEntrada, item.Placa, item.HoraEntrada);
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
