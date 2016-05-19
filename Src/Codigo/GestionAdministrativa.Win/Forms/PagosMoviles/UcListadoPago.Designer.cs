namespace GestionAdministrativa.Win.Forms.PagosMoviles
{
    partial class UcListadoPago
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.DgvListadoMoviles = new Telerik.WinControls.UI.RadGridView();
            this.BtnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoMoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoMoviles.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListadoMoviles
            // 
            this.DgvListadoMoviles.AutoSizeRows = true;
            this.DgvListadoMoviles.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListadoMoviles.Location = new System.Drawing.Point(3, 60);
            // 
            // DgvListadoMoviles
            // 
            this.DgvListadoMoviles.MasterTemplate.AllowAddNewRow = false;
            this.DgvListadoMoviles.MasterTemplate.AllowColumnReorder = false;
            this.DgvListadoMoviles.MasterTemplate.AllowDragToGroup = false;
            this.DgvListadoMoviles.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn11.FieldName = "FechaAlta";
            gridViewTextBoxColumn11.HeaderText = "Fecha";
            gridViewTextBoxColumn11.Name = "FechaAlta";
            gridViewTextBoxColumn11.Width = 84;
            gridViewTextBoxColumn12.FieldName = "Desde";
            gridViewTextBoxColumn12.HeaderText = "Desde";
            gridViewTextBoxColumn12.Name = "Desde";
            gridViewTextBoxColumn12.Width = 71;
            gridViewTextBoxColumn13.FieldName = "Hasta";
            gridViewTextBoxColumn13.HeaderText = "Hasta";
            gridViewTextBoxColumn13.Name = "Hasta";
            gridViewTextBoxColumn13.Width = 71;
            gridViewTextBoxColumn14.FieldName = "Numero";
            gridViewTextBoxColumn14.HeaderText = "Movil";
            gridViewTextBoxColumn14.Name = "Numero";
            gridViewTextBoxColumn14.Width = 60;
            gridViewTextBoxColumn15.FieldName = "Monto";
            gridViewTextBoxColumn15.HeaderText = "Monto";
            gridViewTextBoxColumn15.Name = "Monto";
            gridViewTextBoxColumn15.Width = 71;
            gridViewTextBoxColumn16.FieldName = "Efectivo";
            gridViewTextBoxColumn16.HeaderText = "Efectivo";
            gridViewTextBoxColumn16.Name = "Efectivo";
            gridViewTextBoxColumn16.Width = 71;
            gridViewTextBoxColumn17.FieldName = "Vales";
            gridViewTextBoxColumn17.HeaderText = "Vales";
            gridViewTextBoxColumn17.Name = "Vales";
            gridViewTextBoxColumn17.Width = 71;
            gridViewTextBoxColumn18.FieldName = "Taller";
            gridViewTextBoxColumn18.HeaderText = "Taller";
            gridViewTextBoxColumn18.Name = "Taller";
            gridViewTextBoxColumn18.Width = 71;
            gridViewTextBoxColumn19.FieldName = "Descuento";
            gridViewTextBoxColumn19.HeaderText = "Descuento";
            gridViewTextBoxColumn19.Name = "Descuento";
            gridViewTextBoxColumn19.Width = 71;
            gridViewTextBoxColumn20.FieldName = "Senia";
            gridViewTextBoxColumn20.HeaderText = "Senia";
            gridViewTextBoxColumn20.Name = "Senia";
            gridViewTextBoxColumn20.Width = 101;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.IsVisible = false;
            gridViewCommandColumn2.MaxWidth = 25;
            gridViewCommandColumn2.MinWidth = 25;
            gridViewCommandColumn2.Name = "Delete";
            gridViewCommandColumn2.Width = 25;
            this.DgvListadoMoviles.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewCommandColumn2});
            this.DgvListadoMoviles.Name = "DgvListadoMoviles";
            this.DgvListadoMoviles.ReadOnly = true;
            this.DgvListadoMoviles.Size = new System.Drawing.Size(755, 167);
            this.DgvListadoMoviles.TabIndex = 14;
            this.DgvListadoMoviles.Text = "radGridView1";
            this.DgvListadoMoviles.ThemeName = "TelerikMetro";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(649, 13);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(109, 41);
            this.BtnAceptar.TabIndex = 13;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // UcListadoMovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvListadoMoviles);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "UcListadoMovil";
            this.Size = new System.Drawing.Size(768, 237);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoMoviles.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoMoviles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvListadoMoviles;
        private System.Windows.Forms.Button BtnAceptar;

    }
}
