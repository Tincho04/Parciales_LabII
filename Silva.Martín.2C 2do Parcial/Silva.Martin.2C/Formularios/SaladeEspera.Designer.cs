namespace Formularios
{
    partial class SaladeEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaladeEspera));
            this.lblEspera = new System.Windows.Forms.Label();
            this.listEspera = new System.Windows.Forms.ListBox();
            this.timerEspera = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEspera
            // 
            this.lblEspera.AutoSize = true;
            this.lblEspera.BackColor = System.Drawing.Color.Transparent;
            this.lblEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEspera.Location = new System.Drawing.Point(307, 25);
            this.lblEspera.Name = "lblEspera";
            this.lblEspera.Size = new System.Drawing.Size(160, 25);
            this.lblEspera.TabIndex = 1;
            this.lblEspera.Text = "Sala de Espera";
            // 
            // listEspera
            // 
            this.listEspera.FormattingEnabled = true;
            this.listEspera.Location = new System.Drawing.Point(95, 63);
            this.listEspera.Name = "listEspera";
            this.listEspera.Size = new System.Drawing.Size(591, 199);
            this.listEspera.TabIndex = 2;
            // 
            // timerEspera
            // 
            this.timerEspera.Interval = 10000;
            this.timerEspera.Tick += new System.EventHandler(this.timerEspera_Tick);
            // 
            // SaladeEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formularios.Properties.Resources.sala_de_espera;
            this.ClientSize = new System.Drawing.Size(755, 274);
            this.Controls.Add(this.listEspera);
            this.Controls.Add(this.lblEspera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 20);
            this.Name = "SaladeEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sala de Espera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaladeEspera_FormClosing);
            this.Load += new System.EventHandler(this.SaladeEspera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEspera;
        private System.Windows.Forms.ListBox listEspera;
        private System.Windows.Forms.Timer timerEspera;
    }
}