namespace Formularios
{
    partial class Turnero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turnero));
            this.grpPacientes = new System.Windows.Forms.GroupBox();
            this.cmbPacientesN = new System.Windows.Forms.ComboBox();
            this.btnHideShowPaciente = new System.Windows.Forms.Button();
            this.cmbPacientesA = new System.Windows.Forms.ComboBox();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.grpEspecialistas = new System.Windows.Forms.GroupBox();
            this.cmbEspecialistasN = new System.Windows.Forms.ComboBox();
            this.btnHideShowEspecialista = new System.Windows.Forms.Button();
            this.cmbEspecialistasA = new System.Windows.Forms.ComboBox();
            this.dgvEspecialista = new System.Windows.Forms.DataGridView();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbProcedencia = new System.Windows.Forms.ComboBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProcedencia = new System.Windows.Forms.Button();
            this.grpPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.grpEspecialistas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPacientes
            // 
            this.grpPacientes.BackColor = System.Drawing.Color.Transparent;
            this.grpPacientes.Controls.Add(this.cmbPacientesN);
            this.grpPacientes.Controls.Add(this.btnHideShowPaciente);
            this.grpPacientes.Controls.Add(this.cmbPacientesA);
            this.grpPacientes.Controls.Add(this.dgvPaciente);
            this.grpPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPacientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPacientes.Location = new System.Drawing.Point(24, 106);
            this.grpPacientes.Name = "grpPacientes";
            this.grpPacientes.Size = new System.Drawing.Size(445, 594);
            this.grpPacientes.TabIndex = 0;
            this.grpPacientes.TabStop = false;
            this.grpPacientes.Text = "Pacientes";
            // 
            // cmbPacientesN
            // 
            this.cmbPacientesN.FormattingEnabled = true;
            this.cmbPacientesN.Location = new System.Drawing.Point(235, 25);
            this.cmbPacientesN.Name = "cmbPacientesN";
            this.cmbPacientesN.Size = new System.Drawing.Size(186, 28);
            this.cmbPacientesN.TabIndex = 8;
            this.cmbPacientesN.SelectedIndexChanged += new System.EventHandler(this.cmbPacienteN_SelectedIndexChanged);
            // 
            // btnHideShowPaciente
            // 
            this.btnHideShowPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHideShowPaciente.Location = new System.Drawing.Point(85, 59);
            this.btnHideShowPaciente.Name = "btnHideShowPaciente";
            this.btnHideShowPaciente.Size = new System.Drawing.Size(283, 35);
            this.btnHideShowPaciente.TabIndex = 7;
            this.btnHideShowPaciente.Text = "Mostrar lista de pacientes";
            this.btnHideShowPaciente.UseVisualStyleBackColor = true;
            this.btnHideShowPaciente.Click += new System.EventHandler(this.btnHideShowPaciente_Click);
            // 
            // cmbPacientesA
            // 
            this.cmbPacientesA.FormattingEnabled = true;
            this.cmbPacientesA.Location = new System.Drawing.Point(14, 25);
            this.cmbPacientesA.Name = "cmbPacientesA";
            this.cmbPacientesA.Size = new System.Drawing.Size(201, 28);
            this.cmbPacientesA.TabIndex = 6;
            this.cmbPacientesA.SelectedIndexChanged += new System.EventHandler(this.cmbPacientesA_SelectedIndexChanged);
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(6, 100);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.Size = new System.Drawing.Size(432, 485);
            this.dgvPaciente.TabIndex = 0;
            // 
            // grpEspecialistas
            // 
            this.grpEspecialistas.BackColor = System.Drawing.Color.Transparent;
            this.grpEspecialistas.Controls.Add(this.cmbEspecialistasN);
            this.grpEspecialistas.Controls.Add(this.btnHideShowEspecialista);
            this.grpEspecialistas.Controls.Add(this.cmbEspecialistasA);
            this.grpEspecialistas.Controls.Add(this.dgvEspecialista);
            this.grpEspecialistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEspecialistas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpEspecialistas.Location = new System.Drawing.Point(508, 106);
            this.grpEspecialistas.Name = "grpEspecialistas";
            this.grpEspecialistas.Size = new System.Drawing.Size(445, 594);
            this.grpEspecialistas.TabIndex = 1;
            this.grpEspecialistas.TabStop = false;
            this.grpEspecialistas.Text = "Especialistas";
            // 
            // cmbEspecialistasN
            // 
            this.cmbEspecialistasN.FormattingEnabled = true;
            this.cmbEspecialistasN.Location = new System.Drawing.Point(238, 25);
            this.cmbEspecialistasN.Name = "cmbEspecialistasN";
            this.cmbEspecialistasN.Size = new System.Drawing.Size(180, 28);
            this.cmbEspecialistasN.TabIndex = 9;
            this.cmbEspecialistasN.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialistasN_SelectedIndexChanged);
            // 
            // btnHideShowEspecialista
            // 
            this.btnHideShowEspecialista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHideShowEspecialista.Location = new System.Drawing.Point(88, 59);
            this.btnHideShowEspecialista.Name = "btnHideShowEspecialista";
            this.btnHideShowEspecialista.Size = new System.Drawing.Size(283, 35);
            this.btnHideShowEspecialista.TabIndex = 8;
            this.btnHideShowEspecialista.Text = "Mostrar lista de especialistas";
            this.btnHideShowEspecialista.UseVisualStyleBackColor = true;
            this.btnHideShowEspecialista.Click += new System.EventHandler(this.btnHideShowEspecialista_Click);
            // 
            // cmbEspecialistasA
            // 
            this.cmbEspecialistasA.FormattingEnabled = true;
            this.cmbEspecialistasA.Location = new System.Drawing.Point(6, 25);
            this.cmbEspecialistasA.Name = "cmbEspecialistasA";
            this.cmbEspecialistasA.Size = new System.Drawing.Size(203, 28);
            this.cmbEspecialistasA.TabIndex = 7;
            this.cmbEspecialistasA.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialistasA_SelectedIndexChanged);
            // 
            // dgvEspecialista
            // 
            this.dgvEspecialista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialista.Location = new System.Drawing.Point(8, 100);
            this.dgvEspecialista.Name = "dgvEspecialista";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEspecialista.Size = new System.Drawing.Size(432, 485);
            this.dgvEspecialista.TabIndex = 6;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(198, 63);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(267, 21);
            this.cmbEspecialidad.TabIndex = 2;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEspecialidad.Location = new System.Drawing.Point(33, 63);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(135, 25);
            this.lblEspecialidad.TabIndex = 3;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // dtpHorario
            // 
            this.dtpHorario.Enabled = false;
            this.dtpHorario.Location = new System.Drawing.Point(659, 66);
            this.dtpHorario.MinDate = new System.DateTime(2020, 6, 20, 0, 0, 0, 0);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(267, 20);
            this.dtpHorario.TabIndex = 0;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHorario.Location = new System.Drawing.Point(534, 63);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(82, 25);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horario";
            // 
            // cmbProcedencia
            // 
            this.cmbProcedencia.FormattingEnabled = true;
            this.cmbProcedencia.Location = new System.Drawing.Point(198, 15);
            this.cmbProcedencia.Name = "cmbProcedencia";
            this.cmbProcedencia.Size = new System.Drawing.Size(267, 21);
            this.cmbProcedencia.TabIndex = 6;
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(109, 706);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(230, 50);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Alta de turno";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.AutoSize = true;
            this.lblProcedencia.BackColor = System.Drawing.Color.Transparent;
            this.lblProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProcedencia.Location = new System.Drawing.Point(33, 15);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(132, 25);
            this.lblProcedencia.TabIndex = 7;
            this.lblProcedencia.Text = "Procedencia";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(649, 706);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(230, 50);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnProcedencia
            // 
            this.btnProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcedencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcedencia.Location = new System.Drawing.Point(483, 12);
            this.btnProcedencia.Name = "btnProcedencia";
            this.btnProcedencia.Size = new System.Drawing.Size(213, 30);
            this.btnProcedencia.TabIndex = 9;
            this.btnProcedencia.Text = "Buscar por Procedencia";
            this.btnProcedencia.UseVisualStyleBackColor = true;
            this.btnProcedencia.Click += new System.EventHandler(this.btnProcedencia_Click);
            // 
            // Turnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formularios.Properties.Resources.littn2;
            this.ClientSize = new System.Drawing.Size(966, 781);
            this.Controls.Add(this.btnProcedencia);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblProcedencia);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.cmbProcedencia);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.grpEspecialistas);
            this.Controls.Add(this.grpPacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "Turnero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Turnero - Altas.              Silva Martín 2do C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Turnero_FormClosing);
            this.Load += new System.EventHandler(this.Turnero_Load);
            this.grpPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.grpEspecialistas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPacientes;
        private System.Windows.Forms.GroupBox grpEspecialistas;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.DataGridView dgvEspecialista;
        private System.Windows.Forms.ComboBox cmbProcedencia;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnHideShowPaciente;
        private System.Windows.Forms.ComboBox cmbPacientesA;
        private System.Windows.Forms.Button btnHideShowEspecialista;
        private System.Windows.Forms.ComboBox cmbEspecialistasA;
        private System.Windows.Forms.Label lblProcedencia;
        private System.Windows.Forms.ComboBox cmbPacientesN;
        private System.Windows.Forms.ComboBox cmbEspecialistasN;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProcedencia;
    }
}

