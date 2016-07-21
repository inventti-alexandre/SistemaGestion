namespace GestionAdministrativa.Win.Forms.CuentasCorrientes
{
    partial class FrmIngresoVales
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ddlMovilPaga = new Telerik.WinControls.UI.RadDropDownList();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.BtnAgregarVale = new Telerik.WinControls.UI.RadButton();
            this.LblCliente = new Telerik.WinControls.UI.RadLabel();
            this.TxtMonto = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ddlCliente = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.ddlMovilVale = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.gridVales = new Telerik.WinControls.UI.RadGridView();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.TxtNroVale = new Telerik.WinControls.UI.RadTextBox();
            this.DtpFechaVale = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMovilPaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarVale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMovilVale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVales.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroVale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaVale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(26, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(251, 27);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Movil que presenta el/los vales:";
            // 
            // ddlMovilPaga
            // 
            this.ddlMovilPaga.DropDownAnimationEnabled = true;
            this.ddlMovilPaga.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMovilPaga.Location = new System.Drawing.Point(283, 12);
            this.ddlMovilPaga.MaxDropDownItems = 0;
            this.ddlMovilPaga.Name = "ddlMovilPaga";
            this.ddlMovilPaga.ShowImageInEditorArea = true;
            this.ddlMovilPaga.Size = new System.Drawing.Size(211, 30);
            this.ddlMovilPaga.TabIndex = 2;
            this.ddlMovilPaga.ThemeName = "TelerikMetro";
            this.ddlMovilPaga.SelectedValueChanged += new System.EventHandler(this.ddlMovilPaga_SelectedValueChanged);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.ddlMovilPaga);
            this.radPanel1.Location = new System.Drawing.Point(31, 21);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(959, 54);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.DtpFechaVale);
            this.radPanel2.Controls.Add(this.TxtNroVale);
            this.radPanel2.Controls.Add(this.radLabel7);
            this.radPanel2.Controls.Add(this.radLabel6);
            this.radPanel2.Controls.Add(this.BtnAgregarVale);
            this.radPanel2.Controls.Add(this.LblCliente);
            this.radPanel2.Controls.Add(this.TxtMonto);
            this.radPanel2.Controls.Add(this.radLabel4);
            this.radPanel2.Controls.Add(this.ddlCliente);
            this.radPanel2.Controls.Add(this.radLabel3);
            this.radPanel2.Controls.Add(this.ddlMovilVale);
            this.radPanel2.Controls.Add(this.radLabel2);
            this.radPanel2.Location = new System.Drawing.Point(31, 101);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(959, 167);
            this.radPanel2.TabIndex = 4;
            this.radPanel2.ThemeName = "TelerikMetro";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(312, 96);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(95, 27);
            this.radLabel7.TabIndex = 11;
            this.radLabel7.Text = "Fecha Vale:";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(26, 23);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(114, 27);
            this.radLabel6.TabIndex = 10;
            this.radLabel6.Text = "Numero Vale:";
            // 
            // BtnAgregarVale
            // 
            this.BtnAgregarVale.Image = global::GestionAdministrativa.Win.Properties.Resources.Add_New_blue;
            this.BtnAgregarVale.Location = new System.Drawing.Point(842, 93);
            this.BtnAgregarVale.Name = "BtnAgregarVale";
            this.BtnAgregarVale.Size = new System.Drawing.Size(23, 24);
            this.BtnAgregarVale.TabIndex = 9;
            this.BtnAgregarVale.ThemeName = "TelerikMetro";
            this.BtnAgregarVale.Click += new System.EventHandler(this.BtnAgregarVale_Click);
            // 
            // LblCliente
            // 
            this.LblCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(97, 129);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(65, 27);
            this.LblCliente.TabIndex = 8;
            this.LblCliente.Text = "Cliente:";
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(727, 93);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(100, 26);
            this.TxtMonto.TabIndex = 7;
            this.TxtMonto.TabStop = false;
            this.TxtMonto.ThemeName = "TelerikMetro";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(640, 93);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(69, 27);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = " Monto:";
            // 
            // ddlCliente
            // 
            this.ddlCliente.DropDownAnimationEnabled = true;
            this.ddlCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCliente.Location = new System.Drawing.Point(97, 93);
            this.ddlCliente.MaxDropDownItems = 0;
            this.ddlCliente.Name = "ddlCliente";
            this.ddlCliente.ShowImageInEditorArea = true;
            this.ddlCliente.Size = new System.Drawing.Size(93, 30);
            this.ddlCliente.TabIndex = 5;
            this.ddlCliente.ThemeName = "TelerikMetro";
            this.ddlCliente.SelectedValueChanged += new System.EventHandler(this.ddlCliente_SelectedValueChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(26, 93);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(65, 27);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Cliente:";
            // 
            // ddlMovilVale
            // 
            this.ddlMovilVale.DropDownAnimationEnabled = true;
            this.ddlMovilVale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMovilVale.Location = new System.Drawing.Point(423, 20);
            this.ddlMovilVale.MaxDropDownItems = 0;
            this.ddlMovilVale.Name = "ddlMovilVale";
            this.ddlMovilVale.ShowImageInEditorArea = true;
            this.ddlMovilVale.Size = new System.Drawing.Size(93, 30);
            this.ddlMovilVale.TabIndex = 3;
            this.ddlMovilVale.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(362, 23);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(55, 27);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Movil:";
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.gridVales);
            this.radPanel3.Location = new System.Drawing.Point(31, 338);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(777, 281);
            this.radPanel3.TabIndex = 5;
            this.radPanel3.ThemeName = "TelerikMetro";
            // 
            // gridVales
            // 
            this.gridVales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVales.Location = new System.Drawing.Point(0, 0);
            // 
            // gridVales
            // 
            this.gridVales.MasterTemplate.AllowAddNewRow = false;
            this.gridVales.MasterTemplate.AllowColumnReorder = false;
            this.gridVales.MasterTemplate.AllowDragToGroup = false;
            this.gridVales.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "MovilVale";
            gridViewTextBoxColumn1.HeaderText = "Movil";
            gridViewTextBoxColumn1.Name = "Movil";
            gridViewTextBoxColumn1.Width = 190;
            gridViewTextBoxColumn2.FieldName = "Client";
            gridViewTextBoxColumn2.HeaderText = "Cliente";
            gridViewTextBoxColumn2.Name = "Cliente";
            gridViewTextBoxColumn2.Width = 361;
            gridViewTextBoxColumn3.FieldName = "Monto";
            gridViewTextBoxColumn3.HeaderText = "Monto";
            gridViewTextBoxColumn3.Name = "Monto";
            gridViewTextBoxColumn3.Width = 177;
            gridViewCommandColumn1.HeaderImage = global::GestionAdministrativa.Win.Properties.Resources.delete;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.delete;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Eliminar";
            gridViewCommandColumn1.Width = 30;
            this.gridVales.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1});
            this.gridVales.Name = "gridVales";
            this.gridVales.ReadOnly = true;
            this.gridVales.Size = new System.Drawing.Size(777, 281);
            this.gridVales.TabIndex = 0;
            this.gridVales.ThemeName = "TelerikMetro";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(394, 645);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(54, 31);
            this.radLabel5.TabIndex = 6;
            this.radLabel5.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(467, 646);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 33);
            this.TxtTotal.TabIndex = 7;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetro";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(645, 640);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(163, 40);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.ThemeName = "TelerikMetro";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // TxtNroVale
            // 
            this.TxtNroVale.Location = new System.Drawing.Point(146, 20);
            this.TxtNroVale.Name = "TxtNroVale";
            this.TxtNroVale.Size = new System.Drawing.Size(158, 26);
            this.TxtNroVale.TabIndex = 12;
            this.TxtNroVale.TabStop = false;
            this.TxtNroVale.ThemeName = "TelerikMetro";
            // 
            // DtpFechaVale
            // 
            this.DtpFechaVale.CustomFormat = "MM";
            this.DtpFechaVale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaVale.Location = new System.Drawing.Point(423, 96);
            this.DtpFechaVale.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaVale.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaVale.Name = "DtpFechaVale";
            this.DtpFechaVale.NullableValue = new System.DateTime(2016, 7, 21, 10, 59, 37, 595);
            this.DtpFechaVale.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaVale.Size = new System.Drawing.Size(150, 29);
            this.DtpFechaVale.TabIndex = 13;
            this.DtpFechaVale.TabStop = false;
            this.DtpFechaVale.Text = "07";
            this.DtpFechaVale.ThemeName = "TelerikMetro";
            this.DtpFechaVale.Value = new System.DateTime(2016, 7, 21, 10, 59, 37, 595);
            // 
            // FrmIngresoVales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1022, 733);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmIngresoVales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ingreso de Vales";
            this.Load += new System.EventHandler(this.FrmIngresoVales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMovilPaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarVale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMovilVale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVales.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroVale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaVale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList ddlMovilPaga;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadDropDownList ddlMovilVale;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtMonto;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList ddlCliente;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadGridView gridVales;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadLabel LblCliente;
        private Telerik.WinControls.UI.RadButton BtnAgregarVale;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaVale;
        private Telerik.WinControls.UI.RadTextBox TxtNroVale;
    }
}