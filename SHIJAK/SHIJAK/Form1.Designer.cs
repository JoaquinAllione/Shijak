namespace SHIJAK
{
    partial class Form_carga_inicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_carga_inicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar_carga = new System.Windows.Forms.ProgressBar();
            this.timer_aparicion = new System.Windows.Forms.Timer(this.components);
            this.timer_desaparicion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 235);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar_carga
            // 
            this.progressBar_carga.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar_carga.ForeColor = System.Drawing.Color.Black;
            this.progressBar_carga.Location = new System.Drawing.Point(-6, 232);
            this.progressBar_carga.Name = "progressBar_carga";
            this.progressBar_carga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar_carga.Size = new System.Drawing.Size(610, 10);
            this.progressBar_carga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_carga.TabIndex = 2;
            // 
            // timer_aparicion
            // 
            this.timer_aparicion.Interval = 30;
            this.timer_aparicion.Tick += new System.EventHandler(this.timer_aparicion_Tick);
            // 
            // timer_desaparicion
            // 
            this.timer_desaparicion.Interval = 30;
            this.timer_desaparicion.Tick += new System.EventHandler(this.timer_desaparicion_Tick);
            // 
            // Form_carga_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 239);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar_carga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_carga_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_carga_inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar_carga;
        private System.Windows.Forms.Timer timer_aparicion;
        private System.Windows.Forms.Timer timer_desaparicion;
    }
}

