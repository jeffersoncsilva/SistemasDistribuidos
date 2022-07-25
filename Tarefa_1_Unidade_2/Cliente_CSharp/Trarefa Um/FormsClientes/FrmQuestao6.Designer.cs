namespace Trarefa_Um.FormsClientes
{
    partial class FrmQuestao6
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
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.GbNivel = new System.Windows.Forms.GroupBox();
            this.RbA = new System.Windows.Forms.RadioButton();
            this.RbB = new System.Windows.Forms.RadioButton();
            this.RbC = new System.Windows.Forms.RadioButton();
            this.RbD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbDependentes = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.GbNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxbNome
            // 
            this.TxbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbNome.Location = new System.Drawing.Point(12, 12);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.PlaceholderText = "Digite seu nome...";
            this.TxbNome.Size = new System.Drawing.Size(289, 29);
            this.TxbNome.TabIndex = 0;
            // 
            // GbNivel
            // 
            this.GbNivel.Controls.Add(this.RbD);
            this.GbNivel.Controls.Add(this.RbC);
            this.GbNivel.Controls.Add(this.RbB);
            this.GbNivel.Controls.Add(this.RbA);
            this.GbNivel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GbNivel.Location = new System.Drawing.Point(12, 57);
            this.GbNivel.Name = "GbNivel";
            this.GbNivel.Size = new System.Drawing.Size(149, 167);
            this.GbNivel.TabIndex = 1;
            this.GbNivel.TabStop = false;
            this.GbNivel.Text = "Escolha seu Nível";
            // 
            // RbA
            // 
            this.RbA.AutoSize = true;
            this.RbA.Location = new System.Drawing.Point(48, 28);
            this.RbA.Name = "RbA";
            this.RbA.Size = new System.Drawing.Size(38, 25);
            this.RbA.TabIndex = 0;
            this.RbA.TabStop = true;
            this.RbA.Text = "A";
            this.RbA.UseVisualStyleBackColor = true;
            // 
            // RbB
            // 
            this.RbB.AutoSize = true;
            this.RbB.Location = new System.Drawing.Point(48, 59);
            this.RbB.Name = "RbB";
            this.RbB.Size = new System.Drawing.Size(37, 25);
            this.RbB.TabIndex = 1;
            this.RbB.TabStop = true;
            this.RbB.Text = "B";
            this.RbB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbB.UseVisualStyleBackColor = true;
            // 
            // RbC
            // 
            this.RbC.AutoSize = true;
            this.RbC.Location = new System.Drawing.Point(48, 91);
            this.RbC.Name = "RbC";
            this.RbC.Size = new System.Drawing.Size(38, 25);
            this.RbC.TabIndex = 2;
            this.RbC.TabStop = true;
            this.RbC.Text = "C";
            this.RbC.UseVisualStyleBackColor = true;
            // 
            // RbD
            // 
            this.RbD.AutoSize = true;
            this.RbD.Location = new System.Drawing.Point(48, 122);
            this.RbD.Name = "RbD";
            this.RbD.Size = new System.Drawing.Size(39, 25);
            this.RbD.TabIndex = 3;
            this.RbD.TabStop = true;
            this.RbD.Text = "D";
            this.RbD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite seu salário: R$";
            // 
            // TxbSalario
            // 
            this.TxbSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbSalario.Location = new System.Drawing.Point(173, 237);
            this.TxbSalario.Name = "TxbSalario";
            this.TxbSalario.PlaceholderText = "0,00";
            this.TxbSalario.Size = new System.Drawing.Size(128, 29);
            this.TxbSalario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de dependentes:";
            // 
            // TxbDependentes
            // 
            this.TxbDependentes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbDependentes.Location = new System.Drawing.Point(212, 296);
            this.TxbDependentes.Name = "TxbDependentes";
            this.TxbDependentes.PlaceholderText = "0";
            this.TxbDependentes.Size = new System.Drawing.Size(89, 29);
            this.TxbDependentes.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCalcular.Location = new System.Drawing.Point(69, 346);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(166, 56);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // FrmQuestao6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 415);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxbDependentes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbNivel);
            this.Controls.Add(this.TxbNome);
            this.Name = "FrmQuestao6";
            this.Text = "FrmQuestao06";
            this.GbNivel.ResumeLayout(false);
            this.GbNivel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxbNome;
        private GroupBox GbNivel;
        private RadioButton RbD;
        private RadioButton RbC;
        private RadioButton RbB;
        private RadioButton RbA;
        private Label label1;
        private TextBox TxbSalario;
        private Label label2;
        private TextBox TxbDependentes;
        private Button BtnCalcular;
    }
}