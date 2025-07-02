namespace Actividad_III
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumcuenta = new System.Windows.Forms.TextBox();
            this.txtNomCompleto = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.DtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarAlumnos = new System.Windows.Forms.Button();
            this.btnMostrarAlumnos = new System.Windows.Forms.Button();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.NumCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegistros
            // 
            this.LblRegistros.AutoSize = true;
            this.LblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistros.Location = new System.Drawing.Point(671, 37);
            this.LblRegistros.Name = "LblRegistros";
            this.LblRegistros.Size = new System.Drawing.Size(151, 15);
            this.LblRegistros.TabIndex = 0;
            this.LblRegistros.Text = "Registros de Alumnos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Carrera:";
            // 
            // txtNumcuenta
            // 
            this.txtNumcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumcuenta.Location = new System.Drawing.Point(229, 37);
            this.txtNumcuenta.Name = "txtNumcuenta";
            this.txtNumcuenta.Size = new System.Drawing.Size(115, 21);
            this.txtNumcuenta.TabIndex = 5;
            // 
            // txtNomCompleto
            // 
            this.txtNomCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCompleto.Location = new System.Drawing.Point(229, 75);
            this.txtNomCompleto.Name = "txtNomCompleto";
            this.txtNomCompleto.Size = new System.Drawing.Size(266, 21);
            this.txtNomCompleto.TabIndex = 6;
            // 
            // txtCarrera
            // 
            this.txtCarrera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(229, 155);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(186, 21);
            this.txtCarrera.TabIndex = 7;
            // 
            // DtpNacimiento
            // 
            this.DtpNacimiento.Location = new System.Drawing.Point(229, 120);
            this.DtpNacimiento.Name = "DtpNacimiento";
            this.DtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DtpNacimiento.TabIndex = 8;
            // 
            // btnAgregarAlumnos
            // 
            this.btnAgregarAlumnos.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAgregarAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumnos.FlatAppearance.CheckedBackColor = System.Drawing.Color.RosyBrown;
            this.btnAgregarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumnos.Location = new System.Drawing.Point(233, 194);
            this.btnAgregarAlumnos.Name = "btnAgregarAlumnos";
            this.btnAgregarAlumnos.Size = new System.Drawing.Size(117, 44);
            this.btnAgregarAlumnos.TabIndex = 9;
            this.btnAgregarAlumnos.Text = "Agregar Alumnos";
            this.btnAgregarAlumnos.UseVisualStyleBackColor = false;
            this.btnAgregarAlumnos.Click += new System.EventHandler(this.btnAgregarAlumnos_Click);
            // 
            // btnMostrarAlumnos
            // 
            this.btnMostrarAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMostrarAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarAlumnos.FlatAppearance.BorderSize = 0;
            this.btnMostrarAlumnos.FlatAppearance.CheckedBackColor = System.Drawing.Color.RosyBrown;
            this.btnMostrarAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMostrarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAlumnos.Location = new System.Drawing.Point(376, 194);
            this.btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            this.btnMostrarAlumnos.Size = new System.Drawing.Size(125, 44);
            this.btnMostrarAlumnos.TabIndex = 10;
            this.btnMostrarAlumnos.Text = "Mostrar Alumnos";
            this.btnMostrarAlumnos.UseVisualStyleBackColor = false;
            this.btnMostrarAlumnos.Click += new System.EventHandler(this.btnMostrarAlumnos_Click);
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCuenta,
            this.NomCompleto,
            this.Fecha_Nacimiento,
            this.Carrera});
            this.DGVDatos.Location = new System.Drawing.Point(151, 279);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.Size = new System.Drawing.Size(695, 150);
            this.DGVDatos.TabIndex = 11;
            // 
            // NumCuenta
            // 
            this.NumCuenta.HeaderText = "Num_Cuenta";
            this.NumCuenta.Name = "NumCuenta";
            // 
            // NomCompleto
            // 
            this.NomCompleto.HeaderText = "Nombre Completo";
            this.NomCompleto.Name = "NomCompleto";
            this.NomCompleto.Width = 250;
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 200;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RosyBrown;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(522, 194);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 44);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar Alumno";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.btnMostrarAlumnos);
            this.Controls.Add(this.btnAgregarAlumnos);
            this.Controls.Add(this.DtpNacimiento);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtNomCompleto);
            this.Controls.Add(this.txtNumcuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRegistros);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumcuenta;
        private System.Windows.Forms.TextBox txtNomCompleto;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.DateTimePicker DtpNacimiento;
        private System.Windows.Forms.Button btnAgregarAlumnos;
        private System.Windows.Forms.Button btnMostrarAlumnos;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
    }
}

