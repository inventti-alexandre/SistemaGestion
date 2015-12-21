namespace GestionAdministrativa.Win.Forms
{
    partial class FrmPrincipal
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.BtnChofer = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.BtnMovilListado = new Telerik.WinControls.UI.RadButton();
            this.BtnChoferListado = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMovilListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChoferListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 24);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Movil";
            this.radButton1.ThemeName = "TelerikMetro";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // BtnChofer
            // 
            this.BtnChofer.Location = new System.Drawing.Point(12, 61);
            this.BtnChofer.Name = "BtnChofer";
            this.BtnChofer.Size = new System.Drawing.Size(130, 24);
            this.BtnChofer.TabIndex = 1;
            this.BtnChofer.Text = "Chofer";
            this.BtnChofer.ThemeName = "TelerikMetro";
            this.BtnChofer.Click += new System.EventHandler(this.BtnChofer_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(208, 12);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(130, 24);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Movil";
            this.radButton2.ThemeName = "TelerikMetro";
            // 
            // BtnMovilListado
            // 
            this.BtnMovilListado.Location = new System.Drawing.Point(208, 61);
            this.BtnMovilListado.Name = "BtnMovilListado";
            this.BtnMovilListado.Size = new System.Drawing.Size(130, 24);
            this.BtnMovilListado.TabIndex = 2;
            this.BtnMovilListado.Text = "Movil Listado";
            this.BtnMovilListado.ThemeName = "TelerikMetro";
            this.BtnMovilListado.Click += new System.EventHandler(this.BtnMovilListado_Click);
            // 
            // BtnChoferListado
            // 
            this.BtnChoferListado.Location = new System.Drawing.Point(12, 106);
            this.BtnChoferListado.Name = "BtnChoferListado";
            this.BtnChoferListado.Size = new System.Drawing.Size(130, 24);
            this.BtnChoferListado.TabIndex = 3;
            this.BtnChoferListado.Text = "Chofer Listado";
            this.BtnChoferListado.ThemeName = "TelerikMetro";
            this.BtnChoferListado.Click += new System.EventHandler(this.BtnChoferListado_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 493);
            this.Controls.Add(this.BtnChoferListado);
            this.Controls.Add(this.BtnMovilListado);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.BtnChofer);
            this.Controls.Add(this.radButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Getion UpMobile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMovilListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChoferListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton BtnChofer;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton BtnMovilListado;
        private Telerik.WinControls.UI.RadButton BtnChoferListado;


    }
}
