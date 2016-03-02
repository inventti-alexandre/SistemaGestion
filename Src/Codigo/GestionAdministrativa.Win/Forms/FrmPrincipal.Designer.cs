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
            this.BtnChoferListado = new Telerik.WinControls.UI.RadButton();
            this.BtnCelulares = new Telerik.WinControls.UI.RadButton();
            this.Menu = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.btnPagos = new Telerik.WinControls.UI.RadButton();
            this.BtnAbrirCaja = new Telerik.WinControls.UI.RadButton();
            this.BtnCajas = new Telerik.WinControls.UI.RadButton();
            this.btnCajaResumida = new Telerik.WinControls.UI.RadButton();
            this.btnCambioCelularMovil = new Telerik.WinControls.UI.RadButton();
            this.lblUsuario = new Telerik.WinControls.UI.RadLabel();
            this.btnInformeCaja = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChoferListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCelulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAbrirCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCajaResumida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambioCelularMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInformeCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.AutoSize = true;
            this.radButton1.BackColor = System.Drawing.Color.White;
            this.radButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = global::GestionAdministrativa.Win.Properties.Resources.Car01;
            this.radButton1.Location = new System.Drawing.Point(330, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(132, 132);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Moviles";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton1.ThemeName = "TelerikMetro";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // BtnChoferListado
            // 
            this.BtnChoferListado.AutoSize = true;
            this.BtnChoferListado.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChoferListado.ForeColor = System.Drawing.Color.White;
            this.BtnChoferListado.Image = global::GestionAdministrativa.Win.Properties.Resources.chofer01;
            this.BtnChoferListado.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnChoferListado.Location = new System.Drawing.Point(177, 12);
            this.BtnChoferListado.Name = "BtnChoferListado";
            this.BtnChoferListado.Size = new System.Drawing.Size(132, 132);
            this.BtnChoferListado.TabIndex = 3;
            this.BtnChoferListado.Text = "Choferes";
            this.BtnChoferListado.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnChoferListado.ThemeName = "TelerikMetro";
            this.BtnChoferListado.Click += new System.EventHandler(this.BtnChoferListado_Click);
            // 
            // BtnCelulares
            // 
            this.BtnCelulares.AutoSize = true;
            this.BtnCelulares.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCelulares.Image = global::GestionAdministrativa.Win.Properties.Resources.Cell01;
            this.BtnCelulares.Location = new System.Drawing.Point(630, 12);
            this.BtnCelulares.Name = "BtnCelulares";
            this.BtnCelulares.Size = new System.Drawing.Size(132, 132);
            this.BtnCelulares.TabIndex = 4;
            this.BtnCelulares.Text = "Celulares";
            this.BtnCelulares.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCelulares.ThemeName = "TelerikMetro";
            this.BtnCelulares.Visible = false;
            this.BtnCelulares.Click += new System.EventHandler(this.BtnCelulares_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.DarkGray;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.DropDownAnimationEnabled = true;
            this.Menu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Menu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            // 
            // 
            // 
            this.Menu.RootElement.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.Menu.Size = new System.Drawing.Size(38, 652);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "radMenu1";
            this.Menu.ThemeName = "TelerikMetro";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Menu 01";
            this.radMenuItem1.AccessibleName = "Menu 01";
            this.radMenuItem1.AngleTransform = 90F;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Menu 01";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Menu 02";
            this.radMenuItem2.AccessibleName = "Menu 02";
            this.radMenuItem2.AngleTransform = 90F;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Menu 02";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnPagos
            // 
            this.btnPagos.AutoSize = true;
            this.btnPagos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Image = global::GestionAdministrativa.Win.Properties.Resources.pago01;
            this.btnPagos.Location = new System.Drawing.Point(177, 166);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(132, 132);
            this.btnPagos.TabIndex = 6;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagos.ThemeName = "TelerikMetro";
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // BtnAbrirCaja
            // 
            this.BtnAbrirCaja.AutoSize = true;
            this.BtnAbrirCaja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirCaja.Image = global::GestionAdministrativa.Win.Properties.Resources.caja;
            this.BtnAbrirCaja.Location = new System.Drawing.Point(1109, 12);
            this.BtnAbrirCaja.Name = "BtnAbrirCaja";
            this.BtnAbrirCaja.Size = new System.Drawing.Size(132, 132);
            this.BtnAbrirCaja.TabIndex = 7;
            this.BtnAbrirCaja.Text = "Abrir Caja";
            this.BtnAbrirCaja.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbrirCaja.ThemeName = "TelerikMetro";
            this.BtnAbrirCaja.Click += new System.EventHandler(this.BtnCaja_Click);
            // 
            // BtnCajas
            // 
            this.BtnCajas.AutoSize = true;
            this.BtnCajas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCajas.Image = global::GestionAdministrativa.Win.Properties.Resources.balance;
            this.BtnCajas.Location = new System.Drawing.Point(177, 317);
            this.BtnCajas.Name = "BtnCajas";
            this.BtnCajas.Size = new System.Drawing.Size(132, 132);
            this.BtnCajas.TabIndex = 8;
            this.BtnCajas.Text = "Cajas";
            this.BtnCajas.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCajas.ThemeName = "TelerikMetro";
            this.BtnCajas.Click += new System.EventHandler(this.BtnCajas_Click);
            // 
            // btnCajaResumida
            // 
            this.btnCajaResumida.AutoSize = true;
            this.btnCajaResumida.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajaResumida.Image = global::GestionAdministrativa.Win.Properties.Resources.infCaja;
            this.btnCajaResumida.Location = new System.Drawing.Point(483, 166);
            this.btnCajaResumida.Name = "btnCajaResumida";
            this.btnCajaResumida.Size = new System.Drawing.Size(158, 132);
            this.btnCajaResumida.TabIndex = 9;
            this.btnCajaResumida.Text = "Caja Resumida";
            this.btnCajaResumida.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCajaResumida.ThemeName = "TelerikMetro";
            this.btnCajaResumida.Click += new System.EventHandler(this.btnCajaResumida_Click);
            // 
            // btnCambioCelularMovil
            // 
            this.btnCambioCelularMovil.AutoSize = true;
            this.btnCambioCelularMovil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioCelularMovil.Image = global::GestionAdministrativa.Win.Properties.Resources.celChange;
            this.btnCambioCelularMovil.Location = new System.Drawing.Point(483, 12);
            this.btnCambioCelularMovil.Name = "btnCambioCelularMovil";
            this.btnCambioCelularMovil.Size = new System.Drawing.Size(132, 132);
            this.btnCambioCelularMovil.TabIndex = 10;
            this.btnCambioCelularMovil.Text = "Cambios";
            this.btnCambioCelularMovil.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambioCelularMovil.ThemeName = "TelerikMetro";
            this.btnCambioCelularMovil.Click += new System.EventHandler(this.btnCambioCelularMovil_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(177, 591);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(111, 28);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // btnInformeCaja
            // 
            this.btnInformeCaja.AutoSize = true;
            this.btnInformeCaja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformeCaja.Image = global::GestionAdministrativa.Win.Properties.Resources.infCaja;
            this.btnInformeCaja.Location = new System.Drawing.Point(330, 166);
            this.btnInformeCaja.Name = "btnInformeCaja";
            this.btnInformeCaja.Size = new System.Drawing.Size(147, 132);
            this.btnInformeCaja.TabIndex = 10;
            this.btnInformeCaja.Text = "Informe Caja";
            this.btnInformeCaja.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInformeCaja.ThemeName = "TelerikMetro";
            this.btnInformeCaja.Click += new System.EventHandler(this.btnInformeCaja_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 652);
            this.Controls.Add(this.btnInformeCaja);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCambioCelularMovil);
            this.Controls.Add(this.btnCajaResumida);
            this.Controls.Add(this.BtnCajas);
            this.Controls.Add(this.BtnAbrirCaja);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.BtnCelulares);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.BtnChoferListado);
            this.Controls.Add(this.radButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Gestión UpMobile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChoferListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCelulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAbrirCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCajaResumida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambioCelularMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInformeCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton BtnChoferListado;
        private Telerik.WinControls.UI.RadButton BtnCelulares;
        private Telerik.WinControls.UI.RadMenu Menu;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadButton btnPagos;
        private Telerik.WinControls.UI.RadButton BtnAbrirCaja;
        private Telerik.WinControls.UI.RadButton BtnCajas;
        private Telerik.WinControls.UI.RadButton btnCajaResumida;
        private Telerik.WinControls.UI.RadButton btnCambioCelularMovil;
        private Telerik.WinControls.UI.RadLabel lblUsuario;
        private Telerik.WinControls.UI.RadButton btnInformeCaja;


    }
}
