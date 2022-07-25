namespace Trarefa_Um
{
    partial class FrmQuestao1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(12, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(83, 17);
            this.txbNome.Name = "txbNome";
            this.txbNome.PlaceholderText = "Nome";
            this.txbNome.Size = new System.Drawing.Size(316, 29);
            this.txbNome.TabIndex = 1;
            this.txbNome.Text = "FFFF";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargo.Location = new System.Drawing.Point(12, 72);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 21);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.Location = new System.Drawing.Point(12, 117);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 21);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(163, 168);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 42);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbSalario
            // 
            this.txbSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSalario.Location = new System.Drawing.Point(83, 109);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.PlaceholderText = "R$ 0,00";
            this.txbSalario.Size = new System.Drawing.Size(210, 29);
            this.txbSalario.TabIndex = 6;
            this.txbSalario.Text = "100";
            this.txbSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSalario_KeyPress);
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Operador",
            "Programador"});
            this.cmbCargo.Location = new System.Drawing.Point(83, 70);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(316, 23);
            this.cmbCargo.TabIndex = 2;
            // 
            // FrmClienteQuestao01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 237);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txbSalario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmClienteQuestao01";
            this.Text = "Questao01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox txbNome;
        private Label lblCargo;
        private Label lblSalario;
        private Button btnCalcular;
        private TextBox txbSalario;
        private ComboBox cmbCargo;
    }
}