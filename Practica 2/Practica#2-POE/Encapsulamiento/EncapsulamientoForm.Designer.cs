namespace Practica_2_POE.Encapsulamiento
{
	partial class EncapsulamientoForm
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
            label1 = new Label();
            MontoTextBox = new TextBox();
            DepositarButton = new Button();
            RetirarButton = new Button();
            SaldoButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 106);
            label1.Name = "label1";
            label1.Size = new Size(260, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el monto a depositar o retirar:";
            // 
            // MontoTextBox
            // 
            MontoTextBox.Location = new Point(312, 154);
            MontoTextBox.Margin = new Padding(3, 4, 3, 4);
            MontoTextBox.Name = "MontoTextBox";
            MontoTextBox.Size = new Size(114, 27);
            MontoTextBox.TabIndex = 1;
            // 
            // DepositarButton
            // 
            DepositarButton.Location = new Point(199, 222);
            DepositarButton.Margin = new Padding(3, 4, 3, 4);
            DepositarButton.Name = "DepositarButton";
            DepositarButton.Size = new Size(86, 31);
            DepositarButton.TabIndex = 2;
            DepositarButton.Text = "Depositar";
            DepositarButton.UseVisualStyleBackColor = true;
            DepositarButton.Click += DepositarButton_Click;
            // 
            // RetirarButton
            // 
            RetirarButton.Location = new Point(324, 222);
            RetirarButton.Margin = new Padding(3, 4, 3, 4);
            RetirarButton.Name = "RetirarButton";
            RetirarButton.Size = new Size(86, 31);
            RetirarButton.TabIndex = 3;
            RetirarButton.Text = "Retirar";
            RetirarButton.UseVisualStyleBackColor = true;
            RetirarButton.Click += RetirarButton_Click;
            // 
            // SaldoButton
            // 
            SaldoButton.Location = new Point(443, 222);
            SaldoButton.Margin = new Padding(3, 4, 3, 4);
            SaldoButton.Name = "SaldoButton";
            SaldoButton.Size = new Size(86, 31);
            SaldoButton.TabIndex = 4;
            SaldoButton.Text = "Saldo";
            SaldoButton.UseVisualStyleBackColor = true;
            SaldoButton.Click += SaldoButton_Click;
            // 
            // EncapsulamientoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 393);
            Controls.Add(SaldoButton);
            Controls.Add(RetirarButton);
            Controls.Add(DepositarButton);
            Controls.Add(MontoTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EncapsulamientoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EncapsulamientoForm";
            Load += EncapsulamientoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private TextBox MontoTextBox;
		private Button DepositarButton;
		private Button RetirarButton;
		private Button SaldoButton;
	}
}