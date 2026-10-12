namespace ClinicaSePriceApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(122)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(63, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 60);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Registrar Paciente";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "APELLIDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "OBRA SOCIAL / PREPAGA:";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtDni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtDni.Location = new System.Drawing.Point(300, 21);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(160, 26);
            this.txtDni.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombre.Location = new System.Drawing.Point(300, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtApellido.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtApellido.Location = new System.Drawing.Point(300, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 26);
            this.txtApellido.TabIndex = 7;
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtObraSocial.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtObraSocial.Location = new System.Drawing.Point(300, 146);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(160, 26);
            this.txtObraSocial.TabIndex = 8;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.GridColor = System.Drawing.Color.LightGray;
            this.dgvPacientes.Location = new System.Drawing.Point(481, 12);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 62;
            this.dgvPacientes.Size = new System.Drawing.Size(650, 230);
            this.dgvPacientes.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::ClinicaSePriceApp.Properties.Resources.clinica_SePrice;
            this.ClientSize = new System.Drawing.Size(1143, 480);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.txtObraSocial);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Clínica SePrice - Registro de Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.DataGridView dgvPacientes;
    }
}