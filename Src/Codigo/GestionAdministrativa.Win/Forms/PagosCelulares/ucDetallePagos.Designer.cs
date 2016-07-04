namespace GestionAdministrativa.Win.Forms.Pagos
{
    partial class ucDetallePagos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtMonto = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.dtpHasta = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpDesde = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Yellow;
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(440, 57);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(145, 35);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Agregar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Visible = false;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(80, 61);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(131, 33);
            this.TxtTotal.TabIndex = 10;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTotal.ThemeName = "TelerikMetro";
            this.TxtTotal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTotal_KeyUp);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(4, 64);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(77, 28);
            this.radLabel6.TabIndex = 9;
            this.radLabel6.Text = "TOTAL:";
            this.radLabel6.ThemeName = "TelerikMetro";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(509, 13);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(97, 28);
            this.txtMonto.TabIndex = 8;
            this.txtMonto.TabStop = false;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.ThemeName = "TelerikMetro";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(423, 16);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(80, 25);
            this.radLabel5.TabIndex = 7;
            this.radLabel5.Text = "Diario:";
            this.radLabel5.ThemeName = "TelerikMetro";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(284, 12);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(((long)(0)));
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.NullableValue = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.dtpHasta.NullDate = new System.DateTime(((long)(0)));
            this.dtpHasta.Size = new System.Drawing.Size(133, 29);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.TabStop = false;
            this.dtpHasta.Text = "7/1/2016";
            this.dtpHasta.ThemeName = "TelerikMetro";
            this.dtpHasta.Value = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(80, 12);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(((long)(0)));
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.NullableValue = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.dtpDesde.NullDate = new System.DateTime(((long)(0)));
            this.dtpDesde.Size = new System.Drawing.Size(110, 29);
            this.dtpDesde.TabIndex = 2;
            this.dtpDesde.TabStop = false;
            this.dtpDesde.Text = "7/1/2016";
            this.dtpDesde.ThemeName = "TelerikMetro";
            this.dtpDesde.Value = new System.DateTime(2016, 1, 7, 11, 46, 3, 884);
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(208, 16);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 25);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Hasta:";
            this.radLabel2.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(4, 16);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Desde:";
            this.radLabel1.ThemeName = "TelerikMetro";
            // 
            // ucDetallePagos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "ucDetallePagos";
            this.Size = new System.Drawing.Size(615, 104);
            this.Load += new System.EventHandler(this.ucDetallePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDesde;
        private Telerik.WinControls.UI.RadDateTimePicker dtpHasta;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox txtMonto;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
        private System.Windows.Forms.Button BtnAceptar;
    }
}
