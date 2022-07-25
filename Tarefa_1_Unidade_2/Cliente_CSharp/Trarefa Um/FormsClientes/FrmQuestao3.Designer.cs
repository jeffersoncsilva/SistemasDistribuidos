namespace Trarefa_Um.FormsClientes
{
    partial class FrmQuestao3
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNota1 = new System.Windows.Forms.TextBox();
            this.txbNota2 = new System.Windows.Forms.TextBox();
            this.txbNota3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(250, 63);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(105, 38);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNota1.Location = new System.Drawing.Point(12, 9);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(57, 21);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNota2.Location = new System.Drawing.Point(192, 14);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(57, 21);
            this.lblNota2.TabIndex = 2;
            this.lblNota2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 3";
            // 
            // txbNota1
            // 
            this.txbNota1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota1.Location = new System.Drawing.Point(75, 11);
            this.txbNota1.Name = "txbNota1";
            this.txbNota1.Size = new System.Drawing.Size(100, 29);
            this.txbNota1.TabIndex = 4;
            this.txbNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNota1_KeyPress);
            // 
            // txbNota2
            // 
            this.txbNota2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota2.Location = new System.Drawing.Point(255, 11);
            this.txbNota2.Name = "txbNota2";
            this.txbNota2.Size = new System.Drawing.Size(100, 29);
            this.txbNota2.TabIndex = 5;
            this.txbNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNota1_KeyPress);
            // 
            // txbNota3
            // 
            this.txbNota3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota3.Location = new System.Drawing.Point(75, 63);
            this.txbNota3.Name = "txbNota3";
            this.txbNota3.Size = new System.Drawing.Size(100, 29);
            this.txbNota3.TabIndex = 6;
            this.txbNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNota1_KeyPress);
            // 
            // FrmQuestao3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 119);
            this.Controls.Add(this.txbNota3);
            this.Controls.Add(this.txbNota2);
            this.Controls.Add(this.txbNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.btnEnviar);
            this.Name = "FrmQuestao3";
            this.Text = "FrmQuestao3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnviar;
        private Label lblNota1;
        private Label lblNota2;
        private Label label3;
        private TextBox txbNota1;
        private TextBox txbNota2;
        private TextBox txbNota3;
    }
}