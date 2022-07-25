namespace Trarefa_Um.FormsClientes
{
    partial class FrmQuestao7
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
            this.TxbIdade = new System.Windows.Forms.TextBox();
            this.TxbTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxbIdade
            // 
            this.TxbIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbIdade.Location = new System.Drawing.Point(162, 12);
            this.TxbIdade.Name = "TxbIdade";
            this.TxbIdade.PlaceholderText = "Idade";
            this.TxbIdade.Size = new System.Drawing.Size(101, 29);
            this.TxbIdade.TabIndex = 0;
            // 
            // TxbTempo
            // 
            this.TxbTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbTempo.Location = new System.Drawing.Point(162, 54);
            this.TxbTempo.Name = "TxbTempo";
            this.TxbTempo.PlaceholderText = "10";
            this.TxbTempo.Size = new System.Drawing.Size(101, 29);
            this.TxbTempo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tempo de Serviço";
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVerificar.Location = new System.Drawing.Point(81, 101);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(105, 40);
            this.BtnVerificar.TabIndex = 3;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idade";
            // 
            // FrmQuestao7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbTempo);
            this.Controls.Add(this.TxbIdade);
            this.Name = "FrmQuestao7";
            this.Text = "FrmQuestao7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxbIdade;
        private TextBox TxbTempo;
        private Label label1;
        private Button BtnVerificar;
        private Label label2;
    }
}