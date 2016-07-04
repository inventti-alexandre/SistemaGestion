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
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.ucPagos1 = new GestionAdministrativa.Win.Forms.Pagos.ucPagos();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ucDetallePagos = new GestionAdministrativa.Win.Forms.Pagos.ucDetallePagos();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.ucHistorialPagosChofer1 = new GestionAdministrativa.Win.Forms.Pagos.ucHistorialPagosChofer();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ucComentarios = new GestionAdministrativa.Win.Forms.Choferes.Comentarios.ucComentarios();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBuscardorChoferMovil
            // 
            this.ucBuscardorChoferMovil.DniChofer = 0;
            this.ucBuscardorChoferMovil.Location = new System.Drawing.Point(11, 3);
            this.ucBuscardorChoferMovil.MovilId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucBuscardorChoferMovil.Name = "ucBuscardorChoferMovil";
            this.ucBuscardorChoferMovil.Size = new System.Drawing.Size(464, 134);
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
            this.ucEstadoCuentaChofer1.Location = new System.Drawing.Point(6, 54);
            this.ucEstadoCuentaChofer1.MovilNumero = "";
            this.ucEstadoCuentaChofer1.Name = "ucEstadoCuentaChofer1";
            this.ucEstadoCuentaChofer1.Nombre = "";
            this.ucEstadoCuentaChofer1.Size = new System.Drawing.Size(1012, 103);
            this.ucEstadoCuentaChofer1.TabIndex = 1;
            this.ucEstadoCuentaChofer1.Telefono = "";
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.ucPagos1);
            this.radPanel3.Controls.Add(this.btnGuardar);
            this.radPanel3.Controls.Add(this.ucDetallePagos);
            this.radPanel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel3.Location = new System.Drawing.Point(12, 147);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(635, 516);
            this.radPanel3.TabIndex = 2;
            this.radPanel3.Text = "A PAGAR";
            this.radPanel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // ucPagos1
            // 
            this.ucPagos1.Importe = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucPagos1.Location = new System.Drawing.Point(3, 126);
            this.ucPagos1.Name = "ucPagos1";
            this.ucPagos1.Size = new System.Drawing.Size(615, 275);
            this.ucPagos1.TabIndex = 6;
            this.ucPagos1.Tipo = "Vales";
            this.ucPagos1.Total = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(389, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(196, 42);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar Pago";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ucDetallePagos
            // 
            this.ucDetallePagos.FechaDesde = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.ucDetallePagos.FechaHasta = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.ucDetallePagos.Location = new System.Drawing.Point(3, 18);
            this.ucDetallePagos.Monto = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ucDetallePagos.Name = "ucDetallePagos";
            this.ucDetallePagos.Size = new System.Drawing.Size(626, 109);
            this.ucDetallePagos.TabIndex = 0;
            this.ucDetallePagos.Total = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ucDetallePagos.Load += new System.EventHandler(this.ucDetallePagos_Load);
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.ucBuscardorChoferMovil);
            this.radPanel5.Location = new System.Drawing.Point(12, 2);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(635, 139);
            this.radPanel5.TabIndex = 1;
            // 
            // ucHistorialPagosChofer1
            // 
            this.ucHistorialPagosChofer1.Location = new System.Drawing.Point(20, 145);
            this.ucHistorialPagosChofer1.Name = "ucHistorialPagosChofer1";
            this.ucHistorialPagosChofer1.Size = new System.Drawing.Size(854, 232);
            this.ucHistorialPagosChofer1.TabIndex = 10;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(17, 163);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(192, 25);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "Historial de Pagos";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.ucEstadoCuentaChofer1);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.ucComentarios);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.ucHistorialPagosChofer1);
            this.radPanel1.Location = new System.Drawing.Point(653, 2);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1039, 691);
            this.radPanel1.TabIndex = 11;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(17, 14);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(233, 25);
            this.radLabel3.TabIndex = 14;
            this.radLabel3.Text = "Información del chofer";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(230, 163);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(121, 25);
            this.radLabel2.TabIndex = 13;
            this.radLabel2.Text = "Comentarios";
            // 
            // ucComentarios
            // 
            this.ucComentarios.Comentario = "";
            this.ucComentarios.Location = new System.Drawing.Point(7, 364);
            this.ucComentarios.Name = "ucComentarios";
            this.ucComentarios.Size = new System.Drawing.Size(1020, 320);
            this.ucComentarios.TabIndex = 12;
            // 
            // FrmPagoSistema
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1736, 720);
            this.ControlBox = false;
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel5);
            this.Controls.Add(this.radPanel3);
            this.Name = "FrmPagoSistema";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Registrar pago de sistema";
            this.Load += new System.EventHandler(this.FrmPagoSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBuscardorChoferMovil ucBuscardorChoferMovil;
        private ucEstadoCuentaChofer ucEstadoCuentaChofer1;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private ucDetallePagos ucDetallePagos;
        private ucPagos ucPagos1;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private System.Windows.Forms.Button btnGuardar;
        private ucHistorialPagosChofer ucHistorialPagosChofer1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Choferes.Comentarios.ucComentarios ucComentarios;
    }
}