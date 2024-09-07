namespace Practica_3POE
{
	partial class StudentSystem
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreAlumno = new TextBox();
            txtApellidoAlumno = new TextBox();
            txtNumeroTelefono = new TextBox();
            txtCarreraAlumno = new TextBox();
            lstbRegistroAlumno = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 24);
            label1.Name = "label1";
            label1.Size = new Size(384, 50);
            label1.TabIndex = 0;
            label1.Text = "Registro de Alumnos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(14, 83);
            label2.Name = "label2";
            label2.Size = new Size(249, 31);
            label2.TabIndex = 1;
            label2.Text = "Nombres del Alumno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(14, 145);
            label3.Name = "label3";
            label3.Size = new Size(252, 31);
            label3.TabIndex = 2;
            label3.Text = "Apellidos del Alumno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(14, 216);
            label4.Name = "label4";
            label4.Size = new Size(370, 31);
            label4.TabIndex = 3;
            label4.Text = "Numero de Telefono del Alumno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(14, 277);
            label5.Name = "label5";
            label5.Size = new Size(228, 31);
            label5.TabIndex = 4;
            label5.Text = "Carrera del Alumno:";
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(403, 88);
            txtNombreAlumno.Margin = new Padding(3, 4, 3, 4);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(253, 27);
            txtNombreAlumno.TabIndex = 5;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(403, 151);
            txtApellidoAlumno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(253, 27);
            txtApellidoAlumno.TabIndex = 6;
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Location = new Point(403, 221);
            txtNumeroTelefono.Margin = new Padding(3, 4, 3, 4);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(253, 27);
            txtNumeroTelefono.TabIndex = 7;
            // 
            // txtCarreraAlumno
            // 
            txtCarreraAlumno.Location = new Point(403, 283);
            txtCarreraAlumno.Margin = new Padding(3, 4, 3, 4);
            txtCarreraAlumno.Name = "txtCarreraAlumno";
            txtCarreraAlumno.Size = new Size(253, 27);
            txtCarreraAlumno.TabIndex = 8;
            // 
            // lstbRegistroAlumno
            // 
            lstbRegistroAlumno.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstbRegistroAlumno.FormattingEnabled = true;
            lstbRegistroAlumno.ItemHeight = 37;
            lstbRegistroAlumno.Location = new Point(14, 448);
            lstbRegistroAlumno.Margin = new Padding(3, 4, 3, 4);
            lstbRegistroAlumno.Name = "lstbRegistroAlumno";
            lstbRegistroAlumno.Size = new Size(643, 189);
            lstbRegistroAlumno.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnAgregar.Location = new Point(167, 363);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(145, 47);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(378, 363);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(145, 47);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // StudentSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 689);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstbRegistroAlumno);
            Controls.Add(txtCarreraAlumno);
            Controls.Add(txtNumeroTelefono);
            Controls.Add(txtApellidoAlumno);
            Controls.Add(txtNombreAlumno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentSystem";
            Text = "StudentSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox txtNombreAlumno;
		private TextBox txtApellidoAlumno;
		private TextBox txtNumeroTelefono;
		private TextBox txtCarreraAlumno;
		private ListBox lstbRegistroAlumno;
		private Button btnAgregar;
		private Button btnEliminar;
	}
}