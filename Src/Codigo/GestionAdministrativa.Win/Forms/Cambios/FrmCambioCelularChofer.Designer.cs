namespace GestionAdministrativa.Win.Forms.Cambios
{
    partial class FrmCambioCelularChofer
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
            this.rad = new Telerik.WinControls.UI.RadPageView();
            this.PageMovil = new Telerik.WinControls.UI.RadPageViewPage();
            this.BtnCambiarMovil = new System.Windows.Forms.Button();
            this.ddlMoviles = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ucBuscardorChoferMovil = new GestionAdministrativa.Win.Forms.Pagos.ucBuscardorChoferMovil();
            this.ucEstadoCuentaChofer = new GestionAdministrativa.Win.Forms.Pagos.ucEstadoCuentaChofer();
            this.PageCelular = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.rad)).BeginInit();
            this.rad.SuspendLayout();
            this.PageMovil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rad
            // 
            this.rad.Controls.Add(this.PageMovil);
            this.rad.Controls.Add(this.PageCelular);
            this.rad.Location = new System.Drawing.Point(12, 237);
            this.rad.Name = "rad";
            this.rad.SelectedPage = this.PageCelular;
            this.rad.Size = new System.Drawing.Size(1100, 314);
            this.rad.TabIndex = 1;
            this.rad.Text = "radPageView1";
            this.rad.ThemeName = "TelerikMetro";
            // 
            // PageMovil
            // 
            this.PageMovil.Controls.Add(this.BtnCambiarMovil);
            this.PageMovil.Controls.Add(this.ddlMoviles);
            this.PageMovil.Controls.Add(this.radLabel1);
            this.PageMovil.Location = new System.Drawing.Point(5, 36);
            this.PageMovil.Name = "PageMovil";
            this.PageMovil.Size = new System.Drawing.Size(1090, 273);
            this.PageMovil.Text = "De Móvil";
            // 
            // BtnCambiarMovil
            // 
            this.BtnCambiarMovil.BackColor = System.Drawing.Color.Yellow;
            this.BtnCambiarMovil.FlatAppearance.BorderSize = 0;
            this.BtnCambiarMovil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarMovil.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarMovil.Location = new System.Drawing.Point(421, 30);
            this.BtnCambiarMovil.Name = "BtnCambiarMovil";
            this.BtnCambiarMovil.Size = new System.Drawing.Size(133, 38);
            this.BtnCambiarMovil.TabIndex = 2;
            this.BtnCambiarMovil.Text = "Cambiar";
            this.BtnCambiarMovil.UseVisualStyleBackColor = false;
            this.BtnCambiarMovil.Click += new System.EventHandler(this.BtnCambiarMovil_Click);
            // 
            // ddlMoviles
            // 
            this.ddlMoviles.DropDownAnimationEnabled = true;
            this.ddlMoviles.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMoviles.Location = new System.Drawing.Point(192, 39);
            this.ddlMoviles.MaxDropDownItems = 0;
            this.ddlMoviles.Name = "ddlMoviles";
            this.ddlMoviles.ShowImageInEditorArea = true;
            this.ddlMoviles.Size = new System.Drawing.Size(195, 29);
            this.ddlMoviles.TabIndex = 1;
            this.ddlMoviles.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(30, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(156, 28);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nuevo Móvil: ";
            // 
            // ucBuscardorChoferMovil
            // 
            this.ucBuscardorChoferMovil.DniChofer = 0;
            this.ucBuscardorChoferMovil.Location = new System.Drawing.Point(26, 21);
            this.ucBuscardorChoferMovil.MovilId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucBuscardorChoferMovil.Name = "ucBuscardorChoferMovil";
            this.ucBuscardorChoferMovil.Size = new System.Drawing.Size(443, 142);
            this.ucBuscardorChoferMovil.TabIndex = 2;
            // 
            // ucEstadoCuentaChofer
            // 
            this.ucEstadoCuentaChofer.Apelildo = "";
            this.ucEstadoCuentaChofer.DeudaBase = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ucEstadoCuentaChofer.DeudaSistema = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ucEstadoCuentaChofer.IdChofer = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucEstadoCuentaChofer.Location = new System.Drawing.Point(438, 12);
            this.ucEstadoCuentaChofer.MovilNumero = "";
            this.ucEstadoCuentaChofer.Name = "ucEstadoCuentaChofer";
            this.ucEstadoCuentaChofer.Nombre = "";
            this.ucEstadoCuentaChofer.Size = new System.Drawing.Size(674, 219);
            this.ucEstadoCuentaChofer.TabIndex = 3;
            this.ucEstadoCuentaChofer.Telefono = "";
            // 
            // PageCelular
            // 
            this.PageCelular.Location = new System.Drawing.Point(5, 36);
            this.PageCelular.Name = "PageCelular";
            this.PageCelular.Size = new System.Drawing.Size(1090, 273);
            this.PageCelular.Text = "De Celular";
            // 
            // FrmCambioCelularChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 563);
            this.Controls.Add(this.ucEstadoCuentaChofer);
            this.Controls.Add(this.ucBuscardorChoferMovil);
            this.Controls.Add(this.rad);
            this.Name = "FrmCambioCelularChofer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Cambios";
            this.Load += new System.EventHandler(this.FrmCambioCelularChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rad)).EndInit();
            this.rad.ResumeLayout(false);
            this.PageMovil.ResumeLayout(false);
            this.PageMovil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView rad;
        private Telerik.WinControls.UI.RadPageViewPage PageMovil;
        private Pagos.ucBuscardorChoferMovil ucBuscardorChoferMovil;
        private Pagos.ucEstadoCuentaChofer ucEstadoCuentaChofer;
        private System.Windows.Forms.Button BtnCambiarMovil;
        private Telerik.WinControls.UI.RadDropDownList ddlMoviles;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageViewPage PageCelular;
    }
}