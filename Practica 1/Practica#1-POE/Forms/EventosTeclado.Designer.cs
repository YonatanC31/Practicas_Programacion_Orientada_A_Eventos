namespace Practica_1_POE.Forms
{
	partial class EventosTeclado
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
            MayusculasTextBox = new TextBox();
            PreviewTextBox = new TextBox();
            SuspendLayout();
            // 
            // MayusculasTextBox
            // 
            MayusculasTextBox.Location = new Point(302, 81);
            MayusculasTextBox.Margin = new Padding(3, 4, 3, 4);
            MayusculasTextBox.Name = "MayusculasTextBox";
            MayusculasTextBox.Size = new Size(114, 27);
            MayusculasTextBox.TabIndex = 0;
            MayusculasTextBox.KeyPress += MayusculasTextBox_KeyPress;
            // 
            // PreviewTextBox
            // 
            PreviewTextBox.Location = new Point(302, 160);
            PreviewTextBox.Margin = new Padding(3, 4, 3, 4);
            PreviewTextBox.Name = "PreviewTextBox";
            PreviewTextBox.Size = new Size(114, 27);
            PreviewTextBox.TabIndex = 1;
            PreviewTextBox.PreviewKeyDown += PreviewTextBox_PreviewKeyDown;
            // 
            // EventosTeclado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 404);
            Controls.Add(PreviewTextBox);
            Controls.Add(MayusculasTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EventosTeclado";
            Text = "EventosTeclado";
            KeyDown += EventosTeclado_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MayusculasTextBox;
		private TextBox PreviewTextBox;
	}
}