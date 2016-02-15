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
            this.BtnCelulares = new Telerik.WinControls.UI.RadButton();
            this.Menu = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.btnPagos = new Telerik.WinControls.UI.RadButton();
            this.BtnAbrirCaja = new Telerik.WinControls.UI.RadButton();
            this.BtnCerrarCaja = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMovilListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChoferListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCelulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAbrirCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.AutoSize = true;
            this.radButton1.BackColor = System.Drawing.Color.White;
            this.radButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = global::GestionAdministrativa.Win.Properties.Resources.Car01;
            this.radButton1.Location = new System.Drawing.Point(315, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(132, 132);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Moviles";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton1.ThemeName = "TelerikMetro";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // BtnChofer
            // 
            this.BtnChofer.Location = new System.Drawing.Point(981, 247);
            this.BtnChofer.Name = "BtnChofer";
            this.BtnChofer.Size = new System.Drawing.Size(130, 24);
            this.BtnChofer.TabIndex = 1;
            this.BtnChofer.Text = "Chofer";
            this.BtnChofer.ThemeName = "TelerikMetro";
            this.BtnChofer.Click += new System.EventHandler(this.BtnChofer_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(981, 157);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(130, 24);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Movil";
            this.radButton2.ThemeName = "TelerikMetro";
            // 
            // BtnMovilListado
            // 
            this.BtnMovilListado.Location = new System.Drawing.Point(981, 206);
            this.BtnMovilListado.Name = "BtnMovilListado";
            this.BtnMovilListado.Size = new System.Drawing.Size(130, 24);
            this.BtnMovilListado.TabIndex = 2;
            this.BtnMovilListado.Text = "Movil Listado";
            this.BtnMovilListado.ThemeName = "TelerikMetro";
            this.BtnMovilListado.Click += new System.EventHandler(this.BtnMovilListado_Click);
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
            this.BtnCelulares.Location = new System.Drawing.Point(453, 12);
            this.BtnCelulares.Name = "BtnCelulares";
            this.BtnCelulares.Size = new System.Drawing.Size(132, 132);
            this.BtnCelulares.TabIndex = 4;
            this.BtnCelulares.Text = "Celulares";
            this.BtnCelulares.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCelulares.ThemeName = "TelerikMetro";
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
            this.btnPagos.Location = new System.Drawing.Point(177, 157);
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
            this.BtnAbrirCaja.Location = new System.Drawing.Point(315, 157);
            this.BtnAbrirCaja.Name = "BtnAbrirCaja";
            this.BtnAbrirCaja.Size = new System.Drawing.Size(132, 132);
            this.BtnAbrirCaja.TabIndex = 7;
            this.BtnAbrirCaja.Text = "Abrir Caja";
            this.BtnAbrirCaja.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbrirCaja.ThemeName = "TelerikMetro";
            this.BtnAbrirCaja.Click += new System.EventHandler(this.BtnCaja_Click);
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.AutoSize = true;
            this.BtnCerrarCaja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarCaja.Image = global::GestionAdministrativa.Win.Properties.Resources.caja;
            this.BtnCerrarCaja.Location = new System.Drawing.Point(453, 157);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(136, 132);
            this.BtnCerrarCaja.TabIndex = 8;
            this.BtnCerrarCaja.Text = "Cerrar Caja";
            this.BtnCerrarCaja.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCerrarCaja.ThemeName = "TelerikMetro";
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 652);
            this.Controls.Add(this.BtnCerrarCaja);
            this.Controls.Add(this.BtnAbrirCaja);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.BtnCelulares);
            this.Controls.Add(this.Menu);
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
            this.Text = "Gestión UpMobile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMovilListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnChoferListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCelulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAbrirCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton BtnChofer;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton BtnMovilListado;
        private Telerik.WinControls.UI.RadButton BtnChoferListado;
        private Telerik.WinControls.UI.RadButton BtnCelulares;
        private Telerik.WinControls.UI.RadMenu Menu;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadButton btnPagos;
        private Telerik.WinControls.UI.RadButton BtnAbrirCaja;
        private Telerik.WinControls.UI.RadButton BtnCerrarCaja;


    }
}
