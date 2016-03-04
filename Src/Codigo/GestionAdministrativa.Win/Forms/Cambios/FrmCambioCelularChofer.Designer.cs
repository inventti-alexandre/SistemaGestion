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
            this.PageCelular = new Telerik.WinControls.UI.RadPageViewPage();
            this.TxtCelularAnterior = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCelularNuevo = new Telerik.WinControls.UI.RadTextBox();
            this.BtnAgregarCelular = new Telerik.WinControls.UI.RadButton();
            this.ucBuscardorChoferMovil = new GestionAdministrativa.Win.Forms.Pagos.ucBuscardorChoferMovil();
            this.ucEstadoCuentaChofer = new GestionAdministrativa.Win.Forms.Pagos.ucEstadoCuentaChofer();
            this.btnCambioCel = new System.Windows.Forms.Button();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtAFavor = new Telerik.WinControls.UI.RadTextBox();
            this.txtMonto = new Telerik.WinControls.UI.RadTextBox();
            this.txtDias = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rad)).BeginInit();
            this.rad.SuspendLayout();
            this.PageMovil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.PageCelular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCelularAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCelularNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAFavor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias)).BeginInit();
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
            // PageCelular
            // 
            this.PageCelular.Controls.Add(this.radLabel3);
            this.PageCelular.Controls.Add(this.radLabel2);
            this.PageCelular.Controls.Add(this.radPanel1);
            this.PageCelular.Controls.Add(this.btnCambioCel);
            this.PageCelular.Controls.Add(this.TxtCelularAnterior);
            this.PageCelular.Controls.Add(this.TxtCelularNuevo);
            this.PageCelular.Controls.Add(this.BtnAgregarCelular);
            this.PageCelular.Location = new System.Drawing.Point(5, 36);
            this.PageCelular.Name = "PageCelular";
            this.PageCelular.Size = new System.Drawing.Size(1090, 273);
            this.PageCelular.Text = "De Celular";
            // 
            // TxtCelularAnterior
            // 
            this.TxtCelularAnterior.Enabled = false;
            this.TxtCelularAnterior.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelularAnterior.Location = new System.Drawing.Point(104, 56);
            this.TxtCelularAnterior.Name = "TxtCelularAnterior";
            this.TxtCelularAnterior.Size = new System.Drawing.Size(291, 28);
            this.TxtCelularAnterior.TabIndex = 14;
            this.TxtCelularAnterior.TabStop = false;
            this.TxtCelularAnterior.ThemeName = "TelerikMetro";
            // 
            // TxtCelularNuevo
            // 
            this.TxtCelularNuevo.Enabled = false;
            this.TxtCelularNuevo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelularNuevo.Location = new System.Drawing.Point(104, 115);
            this.TxtCelularNuevo.Name = "TxtCelularNuevo";
            this.TxtCelularNuevo.Size = new System.Drawing.Size(291, 28);
            this.TxtCelularNuevo.TabIndex = 12;
            this.TxtCelularNuevo.TabStop = false;
            this.TxtCelularNuevo.ThemeName = "TelerikMetro";
            // 
            // BtnAgregarCelular
            // 
            this.BtnAgregarCelular.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAgregarCelular.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCelular.Image = global::GestionAdministrativa.Win.Properties.Resources.Add_New_blue;
            this.BtnAgregarCelular.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAgregarCelular.Location = new System.Drawing.Point(401, 114);
            this.BtnAgregarCelular.Name = "BtnAgregarCelular";
            this.BtnAgregarCelular.Size = new System.Drawing.Size(29, 29);
            this.BtnAgregarCelular.TabIndex = 13;
            this.BtnAgregarCelular.ThemeName = "TelerikMetro";
            this.BtnAgregarCelular.Click += new System.EventHandler(this.BtnAgregarCelular_Click);
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
            // btnCambioCel
            // 
            this.btnCambioCel.BackColor = System.Drawing.Color.Yellow;
            this.btnCambioCel.FlatAppearance.BorderSize = 0;
            this.btnCambioCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioCel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioCel.Location = new System.Drawing.Point(262, 177);
            this.btnCambioCel.Name = "btnCambioCel";
            this.btnCambioCel.Size = new System.Drawing.Size(133, 38);
            this.btnCambioCel.TabIndex = 15;
            this.btnCambioCel.Text = "Guardar";
            this.btnCambioCel.UseVisualStyleBackColor = false;
            this.btnCambioCel.Click += new System.EventHandler(this.btnCambioCel_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.txtDias);
            this.radPanel1.Controls.Add(this.txtMonto);
            this.radPanel1.Controls.Add(this.txtAFavor);
            this.radPanel1.Controls.Add(this.radLabel7);
            this.radPanel1.Controls.Add(this.radLabel6);
            this.radPanel1.Controls.Add(this.radLabel5);
            this.radPanel1.Controls.Add(this.radLabel4);
            this.radPanel1.Location = new System.Drawing.Point(581, 45);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(240, 170);
            this.radPanel1.TabIndex = 16;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(22, 56);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 28);
            this.radLabel2.TabIndex = 17;
            this.radLabel2.Text = "Actual:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(22, 115);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(66, 28);
            this.radLabel3.TabIndex = 18;
            this.radLabel3.Text = "Nuevo:";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(0, 0);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(91, 28);
            this.radLabel4.TabIndex = 18;
            this.radLabel4.Text = "Diferencia";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(13, 45);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(47, 28);
            this.radLabel5.TabIndex = 19;
            this.radLabel5.Text = "Dias:";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(13, 79);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(68, 28);
            this.radLabel6.TabIndex = 20;
            this.radLabel6.Text = "Monto:";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(13, 113);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(74, 28);
            this.radLabel7.TabIndex = 21;
            this.radLabel7.Text = "A Favor:";
            // 
            // txtAFavor
            // 
            this.txtAFavor.Enabled = false;
            this.txtAFavor.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFavor.Location = new System.Drawing.Point(93, 113);
            this.txtAFavor.Name = "txtAFavor";
            this.txtAFavor.Size = new System.Drawing.Size(110, 28);
            this.txtAFavor.TabIndex = 22;
            this.txtAFavor.TabStop = false;
            this.txtAFavor.ThemeName = "TelerikMetro";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(93, 79);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(110, 28);
            this.txtMonto.TabIndex = 23;
            this.txtMonto.TabStop = false;
            this.txtMonto.ThemeName = "TelerikMetro";
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(93, 45);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(110, 28);
            this.txtDias.TabIndex = 24;
            this.txtDias.TabStop = false;
            this.txtDias.ThemeName = "TelerikMetro";
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
            this.PageCelular.ResumeLayout(false);
            this.PageCelular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCelularAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCelularNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAFavor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias)).EndInit();
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
        private Telerik.WinControls.UI.RadTextBox TxtCelularAnterior;
        private Telerik.WinControls.UI.RadTextBox TxtCelularNuevo;
        private Telerik.WinControls.UI.RadButton BtnAgregarCelular;
        private System.Windows.Forms.Button btnCambioCel;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadTextBox txtDias;
        private Telerik.WinControls.UI.RadTextBox txtMonto;
        private Telerik.WinControls.UI.RadTextBox txtAFavor;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}