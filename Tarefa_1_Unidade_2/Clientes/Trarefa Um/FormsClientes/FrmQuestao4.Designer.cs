namespace Trarefa_Um.FormsClientes
{
    partial class FrmQuestao4
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
            this.BtnCalcula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.RbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BtnCalcula
            // 
            this.BtnCalcula.Location = new System.Drawing.Point(90, 106);
            this.BtnCalcula.Name = "BtnCalcula";
            this.BtnCalcula.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcula.TabIndex = 0;
            this.BtnCalcula.Text = "Calcular Peso";
            this.BtnCalcula.UseVisualStyleBackColor = true;
            this.BtnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura";
            // 
            // TxbNome
            // 
            this.TxbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbNome.Location = new System.Drawing.Point(106, 6);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.PlaceholderText = "Altura cm";
            this.TxbNome.Size = new System.Drawing.Size(138, 29);
            this.TxbNome.TabIndex = 2;
            // 
            // RbFeminino
            // 
            this.RbFeminino.AutoSize = true;
            this.RbFeminino.Location = new System.Drawing.Point(35, 62);
            this.RbFeminino.Name = "RbFeminino";
            this.RbFeminino.Size = new System.Drawing.Size(75, 19);
            this.RbFeminino.TabIndex = 3;
            this.RbFeminino.TabStop = true;
            this.RbFeminino.Text = "Feminino";
            this.RbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(132, 62);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 4;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // FrmQuestao4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 155);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.RbFeminino);
            this.Controls.Add(this.TxbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcula);
            this.Name = "FrmQuestao4";
            this.Text = "FrmQuestao4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCalcula;
        private Label label1;
        private TextBox TxbNome;
        private RadioButton RbFeminino;
        private RadioButton rbMasculino;
    }
}