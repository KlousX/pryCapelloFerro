namespace pryCapelloFerro
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.panInformacion = new System.Windows.Forms.Panel();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.mkdDistancia = new System.Windows.Forms.MaskedTextBox();
            this.dtpIda = new System.Windows.Forms.DateTimePicker();
            this.lblIda = new System.Windows.Forms.Label();
            this.gBoxFechas = new System.Windows.Forms.GroupBox();
            this.picAvion = new System.Windows.Forms.PictureBox();
            this.dtpVuelta = new System.Windows.Forms.DateTimePicker();
            this.lblVuelta = new System.Windows.Forms.Label();
            this.panInformacion.SuspendLayout();
            this.gBoxFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(246, 172);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(122, 31);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar Reserva";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(24, 172);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(122, 31);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Información";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(186, 13);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(61, 15);
            this.lblDistancia.TabIndex = 3;
            this.lblDistancia.Text = "Distancia:";
            this.lblDistancia.Click += new System.EventHandler(this.lblDistancia_Click);
            // 
            // panInformacion
            // 
            this.panInformacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panInformacion.Controls.Add(this.txtDestino);
            this.panInformacion.Controls.Add(this.lblDestino);
            this.panInformacion.Controls.Add(this.mkdDistancia);
            this.panInformacion.Controls.Add(this.lblDistancia);
            this.panInformacion.Location = new System.Drawing.Point(12, 12);
            this.panInformacion.Name = "panInformacion";
            this.panInformacion.Size = new System.Drawing.Size(368, 48);
            this.panInformacion.TabIndex = 4;
            this.panInformacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(67, 13);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 21);
            this.txtDestino.TabIndex = 0;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(9, 13);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(52, 15);
            this.lblDestino.TabIndex = 6;
            this.lblDestino.Text = "Destino:";
            this.lblDestino.Click += new System.EventHandler(this.label1_Click);
            // 
            // mkdDistancia
            // 
            this.mkdDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdDistancia.Location = new System.Drawing.Point(253, 13);
            this.mkdDistancia.Mask = "99999";
            this.mkdDistancia.Name = "mkdDistancia";
            this.mkdDistancia.Size = new System.Drawing.Size(103, 21);
            this.mkdDistancia.TabIndex = 1;
            this.mkdDistancia.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkdDistancia_MaskInputRejected);
            // 
            // dtpIda
            // 
            this.dtpIda.Location = new System.Drawing.Point(67, 28);
            this.dtpIda.Name = "dtpIda";
            this.dtpIda.Size = new System.Drawing.Size(212, 20);
            this.dtpIda.TabIndex = 3;
            // 
            // lblIda
            // 
            this.lblIda.AutoSize = true;
            this.lblIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIda.Location = new System.Drawing.Point(9, 28);
            this.lblIda.Name = "lblIda";
            this.lblIda.Size = new System.Drawing.Size(27, 15);
            this.lblIda.TabIndex = 6;
            this.lblIda.Text = "Ida:";
            // 
            // gBoxFechas
            // 
            this.gBoxFechas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gBoxFechas.Controls.Add(this.picAvion);
            this.gBoxFechas.Controls.Add(this.dtpVuelta);
            this.gBoxFechas.Controls.Add(this.lblVuelta);
            this.gBoxFechas.Controls.Add(this.dtpIda);
            this.gBoxFechas.Controls.Add(this.lblIda);
            this.gBoxFechas.Location = new System.Drawing.Point(12, 66);
            this.gBoxFechas.Name = "gBoxFechas";
            this.gBoxFechas.Size = new System.Drawing.Size(368, 100);
            this.gBoxFechas.TabIndex = 10;
            this.gBoxFechas.TabStop = false;
            this.gBoxFechas.Text = "Fechas";
            // 
            // picAvion
            // 
            this.picAvion.Image = ((System.Drawing.Image)(resources.GetObject("picAvion.Image")));
            this.picAvion.Location = new System.Drawing.Point(285, 9);
            this.picAvion.Name = "picAvion";
            this.picAvion.Size = new System.Drawing.Size(77, 85);
            this.picAvion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvion.TabIndex = 11;
            this.picAvion.TabStop = false;
            // 
            // dtpVuelta
            // 
            this.dtpVuelta.Location = new System.Drawing.Point(67, 65);
            this.dtpVuelta.Name = "dtpVuelta";
            this.dtpVuelta.Size = new System.Drawing.Size(212, 20);
            this.dtpVuelta.TabIndex = 4;
            // 
            // lblVuelta
            // 
            this.lblVuelta.AutoSize = true;
            this.lblVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelta.Location = new System.Drawing.Point(9, 65);
            this.lblVuelta.Name = "lblVuelta";
            this.lblVuelta.Size = new System.Drawing.Size(44, 15);
            this.lblVuelta.TabIndex = 9;
            this.lblVuelta.Text = "Vuelta:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(395, 215);
            this.Controls.Add(this.gBoxFechas);
            this.Controls.Add(this.panInformacion);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferro Viajes";
            this.panInformacion.ResumeLayout(false);
            this.panInformacion.PerformLayout();
            this.gBoxFechas.ResumeLayout(false);
            this.gBoxFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Panel panInformacion;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.MaskedTextBox mkdDistancia;
        private System.Windows.Forms.DateTimePicker dtpIda;
        private System.Windows.Forms.Label lblIda;
        private System.Windows.Forms.GroupBox gBoxFechas;
        private System.Windows.Forms.DateTimePicker dtpVuelta;
        private System.Windows.Forms.Label lblVuelta;
        private System.Windows.Forms.PictureBox picAvion;
    }
}

