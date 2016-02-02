namespace GestionAdministrativa.Win.Forms.Pagos
{
    partial class FrmPagoSistema
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
            this.ucBuscardorChoferMovil = new GestionAdministrativa.Win.Forms.Pagos.ucBuscardorChoferMovil();
            this.ucEstadoCuentaChofer1 = new GestionAdministrativa.Win.Forms.Pagos.ucEstadoCuentaChofer();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ucDetalleDeuda1 = new GestionAdministrativa.Win.Forms.Pagos.ucDetalleDeuda();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.ucDetallePagos = new GestionAdministrativa.Win.Forms.Pagos.ucDetallePagos();
            this.ucPagos1 = new GestionAdministrativa.Win.Forms.Pagos.ucPagos();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBuscardorChoferMovil
            // 
            this.ucBuscardorChoferMovil.DniChofer = 0;
            this.ucBuscardorChoferMovil.Location = new System.Drawing.Point(17, 5);
            this.ucBuscardorChoferMovil.MovilId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucBuscardorChoferMovil.Name = "ucBuscardorChoferMovil";
            this.ucBuscardorChoferMovil.Size = new System.Drawing.Size(464, 159);
            this.ucBuscardorChoferMovil.TabIndex = 0;
            // 
            // ucEstadoCuentaChofer1
            // 
            this.ucEstadoCuentaChofer1.Apelildo = "";
            this.ucEstadoCuentaChofer1.DeudaBase = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ucEstadoCuentaChofer1.DeudaSistema = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ucEstadoCuentaChofer1.IdChofer = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucEstadoCuentaChofer1.Location = new System.Drawing.Point(2, 46);
            this.ucEstadoCuentaChofer1.MovilNumero = "";
            this.ucEstadoCuentaChofer1.Name = "ucEstadoCuentaChofer1";
            this.ucEstadoCuentaChofer1.Nombre = "";
            this.ucEstadoCuentaChofer1.Size = new System.Drawing.Size(489, 211);
            this.ucEstadoCuentaChofer1.TabIndex = 1;
            this.ucEstadoCuentaChofer1.Telefono = "";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radLabel1);
            this.radPanel2.Controls.Add(this.ucEstadoCuentaChofer1);
            this.radPanel2.Location = new System.Drawing.Point(16, 192);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(501, 296);
            this.radPanel2.TabIndex = 3;
            this.radPanel2.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(17, 17);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(151, 25);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Detalle chofer";
            // 
            // radPanel1
            // 
            this.radPanel1.Location = new System.Drawing.Point(131, 534);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(330, 123);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // ucDetalleDeuda1
            // 
            this.ucDetalleDeuda1.Location = new System.Drawing.Point(18, 503);
            this.ucDetalleDeuda1.Name = "ucDetalleDeuda1";
            this.ucDetalleDeuda1.Size = new System.Drawing.Size(489, 220);
            this.ucDetalleDeuda1.TabIndex = 0;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.ucDetallePagos);
            this.radPanel3.Location = new System.Drawing.Point(527, 12);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(618, 174);
            this.radPanel3.TabIndex = 5;
            this.radPanel3.ThemeName = "TelerikMetro";
            // 
            // ucDetallePagos
            // 
            this.ucDetallePagos.FechaDesde = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.ucDetallePagos.FechaHasta = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.ucDetallePagos.Location = new System.Drawing.Point(4, 4);
            this.ucDetallePagos.Monto = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ucDetallePagos.Name = "ucDetallePagos";
            this.ucDetallePagos.Size = new System.Drawing.Size(602, 144);
            this.ucDetallePagos.TabIndex = 0;
            this.ucDetallePagos.Total = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // ucPagos1
            // 
            this.ucPagos1.Importe = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucPagos1.Location = new System.Drawing.Point(7, 9);
            this.ucPagos1.Name = "ucPagos1";
            this.ucPagos1.Size = new System.Drawing.Size(604, 389);
            this.ucPagos1.TabIndex = 6;
            this.ucPagos1.Tipo = "Vales";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.ucPagos1);
            this.radPanel4.Location = new System.Drawing.Point(527, 192);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(618, 401);
            this.radPanel4.TabIndex = 7;
            this.radPanel4.ThemeName = "TelerikMetro";
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.ucBuscardorChoferMovil);
            this.radPanel5.Location = new System.Drawing.Point(16, 12);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(501, 174);
            this.radPanel5.TabIndex = 8;
            this.radPanel5.ThemeName = "TelerikMetro";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(973, 629);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 42);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPagoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 730);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ucDetalleDeuda1);
            this.Controls.Add(this.radPanel5);
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel2);
            this.Name = "FrmPagoSistema";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Registrar pago de sistema";
            this.Load += new System.EventHandler(this.FrmPagoSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBuscardorChoferMovil ucBuscardorChoferMovil;
        private ucEstadoCuentaChofer ucEstadoCuentaChofer1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private ucDetalleDeuda ucDetalleDeuda1;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private ucDetallePagos ucDetallePagos;
        private ucPagos ucPagos1;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private System.Windows.Forms.Button btnGuardar;
    }
}