
namespace ProjetoTesteSistemaEstacionamento
{
    partial class FormSaida
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.cbPlacas = new System.Windows.Forms.ComboBox();
            this.maskedTxtHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.btnValor = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Location = new System.Drawing.Point(123, 27);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(61, 24);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSaida.ForeColor = System.Drawing.Color.White;
            this.lblHoraSaida.Location = new System.Drawing.Point(93, 139);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(113, 24);
            this.lblHoraSaida.TabIndex = 2;
            this.lblHoraSaida.Text = "Hora Saida";
            // 
            // cbPlacas
            // 
            this.cbPlacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlacas.FormattingEnabled = true;
            this.cbPlacas.Location = new System.Drawing.Point(44, 71);
            this.cbPlacas.Name = "cbPlacas";
            this.cbPlacas.Size = new System.Drawing.Size(216, 50);
            this.cbPlacas.TabIndex = 3;
            // 
            // maskedTxtHoraSaida
            // 
            this.maskedTxtHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtHoraSaida.Location = new System.Drawing.Point(88, 180);
            this.maskedTxtHoraSaida.Mask = "00:00";
            this.maskedTxtHoraSaida.Name = "maskedTxtHoraSaida";
            this.maskedTxtHoraSaida.Size = new System.Drawing.Size(124, 50);
            this.maskedTxtHoraSaida.TabIndex = 4;
            this.maskedTxtHoraSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTxtHoraSaida.ValidatingType = typeof(System.DateTime);
            // 
            // btnValor
            // 
            this.btnValor.BackColor = System.Drawing.Color.Green;
            this.btnValor.FlatAppearance.BorderSize = 0;
            this.btnValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValor.ForeColor = System.Drawing.Color.White;
            this.btnValor.Location = new System.Drawing.Point(92, 252);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(115, 42);
            this.btnValor.TabIndex = 5;
            this.btnValor.Text = "Valor";
            this.btnValor.UseVisualStyleBackColor = false;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(32, 313);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Valor a pagar:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.BackColor = System.Drawing.Color.White;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPagar.Location = new System.Drawing.Point(181, 308);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(0, 29);
            this.lblTotalPagar.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(95, 374);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(103, 46);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnValor);
            this.Controls.Add(this.maskedTxtHoraSaida);
            this.Controls.Add(this.cbPlacas);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.lblPlaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSaida_FormClosed);
            this.Load += new System.EventHandler(this.Saida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.ComboBox cbPlacas;
        private System.Windows.Forms.MaskedTextBox maskedTxtHoraSaida;
        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}