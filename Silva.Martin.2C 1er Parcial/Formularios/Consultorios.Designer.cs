namespace Formularios
{
    partial class Consultorios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultorios));
            this.lblEnConsulta = new System.Windows.Forms.Label();
            this.lblAtendidos = new System.Windows.Forms.Label();
            this.listConsultorio = new System.Windows.Forms.ListBox();
            this.listAtendidos = new System.Windows.Forms.ListBox();
            this.btnConsultaHistorial = new System.Windows.Forms.Button();
            this.TimerConsulta = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEnConsulta
            // 
            this.lblEnConsulta.AutoSize = true;
            this.lblEnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblEnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEnConsulta.Location = new System.Drawing.Point(12, 29);
            this.lblEnConsulta.Name = "lblEnConsulta";
            this.lblEnConsulta.Size = new System.Drawing.Size(206, 31);
            this.lblEnConsulta.TabIndex = 2;
            this.lblEnConsulta.Text = "En Consultorio";
            // 
            // lblAtendidos
            // 
            this.lblAtendidos.AutoSize = true;
            this.lblAtendidos.BackColor = System.Drawing.Color.Transparent;
            this.lblAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAtendidos.Location = new System.Drawing.Point(412, 29);
            this.lblAtendidos.Name = "lblAtendidos";
            this.lblAtendidos.Size = new System.Drawing.Size(144, 31);
            this.lblAtendidos.TabIndex = 3;
            this.lblAtendidos.Text = "Atendidos";
            // 
            // listConsultorio
            // 
            this.listConsultorio.FormattingEnabled = true;
            this.listConsultorio.Location = new System.Drawing.Point(12, 72);
            this.listConsultorio.Name = "listConsultorio";
            this.listConsultorio.Size = new System.Drawing.Size(363, 342);
            this.listConsultorio.TabIndex = 4;
            // 
            // listAtendidos
            // 
            this.listAtendidos.FormattingEnabled = true;
            this.listAtendidos.Location = new System.Drawing.Point(384, 71);
            this.listAtendidos.Name = "listAtendidos";
            this.listAtendidos.Size = new System.Drawing.Size(363, 342);
            this.listAtendidos.TabIndex = 5;
            // 
            // btnConsultaHistorial
            // 
            this.btnConsultaHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaHistorial.Location = new System.Drawing.Point(608, 12);
            this.btnConsultaHistorial.Name = "btnConsultaHistorial";
            this.btnConsultaHistorial.Size = new System.Drawing.Size(139, 48);
            this.btnConsultaHistorial.TabIndex = 6;
            this.btnConsultaHistorial.Text = "Consultar Historial";
            this.btnConsultaHistorial.UseVisualStyleBackColor = true;
            this.btnConsultaHistorial.Click += new System.EventHandler(this.btnConsultaHistorial_Click);
            // 
            // TimerConsulta
            // 
            this.TimerConsulta.Interval = 10000;
            this.TimerConsulta.Tick += new System.EventHandler(this.TimerConsulta_Tick);
            // 
            // Consultorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Formularios.Properties.Resources.consultorio;
            this.ClientSize = new System.Drawing.Size(767, 431);
            this.Controls.Add(this.btnConsultaHistorial);
            this.Controls.Add(this.listAtendidos);
            this.Controls.Add(this.listConsultorio);
            this.Controls.Add(this.lblAtendidos);
            this.Controls.Add(this.lblEnConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 350);
            this.Name = "Consultorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultorios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultorios_FormClosing);
            this.Load += new System.EventHandler(this.Consultorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEnConsulta;
        private System.Windows.Forms.Label lblAtendidos;
        private System.Windows.Forms.ListBox listConsultorio;
        private System.Windows.Forms.ListBox listAtendidos;
        private System.Windows.Forms.Button btnConsultaHistorial;
        private System.Windows.Forms.Timer TimerConsulta;
    }
}