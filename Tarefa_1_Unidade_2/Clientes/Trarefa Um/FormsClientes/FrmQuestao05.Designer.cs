namespace Trarefa_Um.FormsClientes
{
    partial class FrmQuestao05
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
            this.BtnValidar = new System.Windows.Forms.Button();
            this.TxbIdade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnValidar
            // 
            this.BtnValidar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnValidar.Location = new System.Drawing.Point(85, 90);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(176, 43);
            this.BtnValidar.TabIndex = 0;
            this.BtnValidar.Text = "Verifica Categoria";
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // TxbIdade
            // 
            this.TxbIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbIdade.Location = new System.Drawing.Point(137, 34);
            this.TxbIdade.Name = "TxbIdade";
            this.TxbIdade.Size = new System.Drawing.Size(178, 29);
            this.TxbIdade.TabIndex = 1;
            this.TxbIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbIdade_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe a idade";
            // 
            // FrmQuestao05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbIdade);
            this.Controls.Add(this.BtnValidar);
            this.Name = "FrmQuestao05";
            this.Text = "FrmQuestao05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnValidar;
        private TextBox TxbIdade;
        private Label label1;
    }
}