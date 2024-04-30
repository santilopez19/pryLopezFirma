namespace pryLopezFirma
{
    partial class frmFirma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirma));
            btnGuardar = new Button();
            btnLimpiar = new Button();
            pctFirma = new PictureBox();
            lblindicacion = new Label();
            ((System.ComponentModel.ISupportInitialize)pctFirma).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(14, 49);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 56);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(14, 128);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 56);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Borrar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pctFirma
            // 
            pctFirma.BackColor = Color.White;
            pctFirma.BorderStyle = BorderStyle.Fixed3D;
            pctFirma.Location = new Point(188, 49);
            pctFirma.Name = "pctFirma";
            pctFirma.Size = new Size(482, 331);
            pctFirma.TabIndex = 2;
            pctFirma.TabStop = false;
            pctFirma.MouseClick += PictureBox1_MouseMove;
            pctFirma.MouseDown += PictureBox1_MouseDown;
            pctFirma.MouseMove += PictureBox1_MouseMove;
            pctFirma.MouseUp += PictureBox1_MouseUp;
            // 
            // lblindicacion
            // 
            lblindicacion.AutoSize = true;
            lblindicacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblindicacion.Location = new Point(188, 21);
            lblindicacion.Name = "lblindicacion";
            lblindicacion.Size = new Size(171, 25);
            lblindicacion.TabIndex = 3;
            lblindicacion.Text = "Dibuje su firma aqui";
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(694, 403);
            Controls.Add(lblindicacion);
            Controls.Add(pctFirma);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma";
            ((System.ComponentModel.ISupportInitialize)pctFirma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnLimpiar;
        private PictureBox pctFirma;
        private Label lblindicacion;
    }
}
