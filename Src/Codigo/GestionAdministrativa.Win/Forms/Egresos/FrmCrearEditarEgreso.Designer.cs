namespace GestionAdministrativa.Win.Forms.Egresos
{
    partial class FrmCrearEditarEgreso
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
            this.BtnSave = new Telerik.WinControls.UI.RadButton();
            this.DdlProveedores = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.CkCajaAnterior = new Telerik.WinControls.UI.RadCheckBox();
            this.TxtImporte = new Telerik.WinControls.UI.RadTextBox();
            this.TxtConcepto = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.TxtFactura = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.EpvEgreso = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnAgregarProveedor = new Telerik.WinControls.UI.RadButton();
            this.dtpFecha = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkCajaAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(349, 318);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 36);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.ThemeName = "TelerikMetro";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DdlProveedores
            // 
            this.DdlProveedores.DropDownAnimationEnabled = true;
            this.DdlProveedores.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DdlProveedores.Location = new System.Drawing.Point(188, 69);
            this.DdlProveedores.MaxDropDownItems = 0;
            this.DdlProveedores.Name = "DdlProveedores";
            this.DdlProveedores.ShowImageInEditorArea = true;
            this.DdlProveedores.Size = new System.Drawing.Size(291, 29);
            this.DdlProveedores.TabIndex = 9;
            this.DdlProveedores.ThemeName = "TelerikMetro";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(72, 69);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(110, 25);
            this.radLabel6.TabIndex = 8;
            this.radLabel6.Text = "Proveedor:";
            // 
            // CkCajaAnterior
            // 
            this.CkCajaAnterior.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkCajaAnterior.Location = new System.Drawing.Point(324, 287);
            this.CkCajaAnterior.Name = "CkCajaAnterior";
            this.CkCajaAnterior.Size = new System.Drawing.Size(155, 25);
            this.CkCajaAnterior.TabIndex = 6;
            this.CkCajaAnterior.Text = "Caja Anterior";
            this.CkCajaAnterior.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.Location = new System.Drawing.Point(188, 253);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(291, 28);
            this.TxtImporte.TabIndex = 5;
            this.TxtImporte.TabStop = false;
            this.TxtImporte.ThemeName = "TelerikMetro";
            // 
            // TxtConcepto
            // 
            this.TxtConcepto.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConcepto.Location = new System.Drawing.Point(188, 138);
            this.TxtConcepto.Multiline = true;
            this.TxtConcepto.Name = "TxtConcepto";
            // 
            // 
            // 
            this.TxtConcepto.RootElement.StretchVertically = true;
            this.TxtConcepto.Size = new System.Drawing.Size(291, 97);
            this.TxtConcepto.TabIndex = 4;
            this.TxtConcepto.TabStop = false;
            this.TxtConcepto.ThemeName = "TelerikMetro";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(92, 253);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(90, 25);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Importe:";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(82, 138);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(100, 25);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Concepto:";
            // 
            // TxtFactura
            // 
            this.TxtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFactura.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFactura.Location = new System.Drawing.Point(188, 104);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.Size = new System.Drawing.Size(291, 28);
            this.TxtFactura.TabIndex = 3;
            this.TxtFactura.TabStop = false;
            this.TxtFactura.ThemeName = "TelerikMetro";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(51, 107);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(131, 25);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Nro Factura:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(112, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Fecha:";
            // 
            // EpvEgreso
            // 
            this.EpvEgreso.ContainerControl = this;
            // 
            // BtnAgregarProveedor
            // 
            this.BtnAgregarProveedor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAgregarProveedor.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProveedor.Image = global::GestionAdministrativa.Win.Properties.Resources.Add_New_blue;
            this.BtnAgregarProveedor.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAgregarProveedor.Location = new System.Drawing.Point(496, 69);
            this.BtnAgregarProveedor.Name = "BtnAgregarProveedor";
            this.BtnAgregarProveedor.Size = new System.Drawing.Size(29, 29);
            this.BtnAgregarProveedor.TabIndex = 12;
            this.BtnAgregarProveedor.ThemeName = "TelerikMetro";
            this.BtnAgregarProveedor.Click += new System.EventHandler(this.BtnAgregarProveedor_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(188, 34);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(((long)(0)));
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.NullableValue = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.dtpFecha.NullDate = new System.DateTime(((long)(0)));
            this.dtpFecha.Size = new System.Drawing.Size(291, 29);
            this.dtpFecha.TabIndex = 13;
            this.dtpFecha.TabStop = false;
            this.dtpFecha.Text = "07/01/2016";
            this.dtpFecha.ThemeName = "TelerikMetro";
            this.dtpFecha.Value = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            // 
            // FrmCrearEditarEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 581);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.BtnAgregarProveedor);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DdlProveedores);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.CkCajaAnterior);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.TxtConcepto);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.TxtFactura);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Name = "FrmCrearEditarEgreso";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Egresos";
            this.Load += new System.EventHandler(this.FrmCrearEditarEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkCajaAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtFactura;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtConcepto;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox TxtImporte;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadCheckBox CkCajaAnterior;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private System.Windows.Forms.ErrorProvider EpvEgreso;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDropDownList DdlProveedores;
        private Telerik.WinControls.UI.RadButton BtnSave;
        private Telerik.WinControls.UI.RadButton BtnAgregarProveedor;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFecha;
    }
}