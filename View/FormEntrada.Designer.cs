
namespace ProjetoTesteSistemaEstacionamento
{
    partial class FormEntrada
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.btnHoraEntrada = new System.Windows.Forms.Button();
            this.maskedTxtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(146, 13);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 2;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Location = new System.Drawing.Point(106, 58);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(61, 24);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.ForeColor = System.Drawing.Color.White;
            this.lblHoraEntrada.Location = new System.Drawing.Point(69, 158);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(133, 24);
            this.lblHoraEntrada.TabIndex = 4;
            this.lblHoraEntrada.Text = "Hora Entrada";
            // 
            // btnHoraEntrada
            // 
            this.btnHoraEntrada.BackColor = System.Drawing.Color.MediumBlue;
            this.btnHoraEntrada.FlatAppearance.BorderSize = 0;
            this.btnHoraEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoraEntrada.ForeColor = System.Drawing.Color.White;
            this.btnHoraEntrada.Location = new System.Drawing.Point(82, 268);
            this.btnHoraEntrada.Name = "btnHoraEntrada";
            this.btnHoraEntrada.Size = new System.Drawing.Size(109, 51);
            this.btnHoraEntrada.TabIndex = 5;
            this.btnHoraEntrada.Text = "Cadastrar";
            this.btnHoraEntrada.UseVisualStyleBackColor = false;
            this.btnHoraEntrada.Click += new System.EventHandler(this.btnHoraEntrada_Click);
            // 
            // maskedTxtHoraEntrada
            // 
            this.maskedTxtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtHoraEntrada.Location = new System.Drawing.Point(76, 197);
            this.maskedTxtHoraEntrada.Mask = "00:00";
            this.maskedTxtHoraEntrada.Name = "maskedTxtHoraEntrada";
            this.maskedTxtHoraEntrada.Size = new System.Drawing.Size(121, 50);
            this.maskedTxtHoraEntrada.TabIndex = 6;
            this.maskedTxtHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTxtHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTxtPlaca
            // 
            this.maskedTxtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtPlaca.Location = new System.Drawing.Point(44, 95);
            this.maskedTxtPlaca.Mask = "aaa-0000";
            this.maskedTxtPlaca.Name = "maskedTxtPlaca";
            this.maskedTxtPlaca.Size = new System.Drawing.Size(187, 50);
            this.maskedTxtPlaca.TabIndex = 7;
            this.maskedTxtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtual.ForeColor = System.Drawing.Color.White;
            this.lblDataAtual.Location = new System.Drawing.Point(89, 23);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(0, 20);
            this.lblDataAtual.TabIndex = 8;
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(276, 333);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.maskedTxtPlaca);
            this.Controls.Add(this.maskedTxtHoraEntrada);
            this.Controls.Add(this.btnHoraEntrada);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEntrada_FormClosed);
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Button btnHoraEntrada;
        private System.Windows.Forms.MaskedTextBox maskedTxtHoraEntrada;
        private System.Windows.Forms.MaskedTextBox maskedTxtPlaca;
        private System.Windows.Forms.Label lblDataAtual;
    }
}