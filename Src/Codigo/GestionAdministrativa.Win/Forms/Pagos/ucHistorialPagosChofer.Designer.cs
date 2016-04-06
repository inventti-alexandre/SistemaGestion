namespace GestionAdministrativa.Win.Forms.Pagos
{
    partial class ucHistorialPagosChofer
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.dgvhistorial = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorial.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvhistorial
            // 
            this.dgvhistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhistorial.Location = new System.Drawing.Point(0, 0);
            // 
            // dgvhistorial
            // 
            this.dgvhistorial.MasterTemplate.AllowAddNewRow = false;
            this.dgvhistorial.MasterTemplate.AllowColumnReorder = false;
            this.dgvhistorial.MasterTemplate.AllowDragToGroup = false;
            this.dgvhistorial.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn10.FieldName = "FechaAlta";
            gridViewTextBoxColumn10.HeaderText = "Fecha";
            gridViewTextBoxColumn10.Name = "FechaAlta";
            gridViewTextBoxColumn10.Width = 115;
            gridViewTextBoxColumn11.FieldName = "Desde";
            gridViewTextBoxColumn11.HeaderText = "Desde";
            gridViewTextBoxColumn11.Name = "Desde";
            gridViewTextBoxColumn11.Width = 99;
            gridViewTextBoxColumn12.FieldName = "Hasta";
            gridViewTextBoxColumn12.HeaderText = "Hasta";
            gridViewTextBoxColumn12.Name = "Hasta";
            gridViewTextBoxColumn12.Width = 99;
            gridViewTextBoxColumn13.FieldName = "Monto";
            gridViewTextBoxColumn13.HeaderText = "Monto";
            gridViewTextBoxColumn13.Name = "Monto";
            gridViewTextBoxColumn13.Width = 99;
            gridViewTextBoxColumn14.FieldName = "Efectivo";
            gridViewTextBoxColumn14.HeaderText = "Efectivo";
            gridViewTextBoxColumn14.Name = "Efectivo";
            gridViewTextBoxColumn14.Width = 99;
            gridViewTextBoxColumn15.FieldName = "Vales";
            gridViewTextBoxColumn15.HeaderText = "Vales";
            gridViewTextBoxColumn15.Name = "Vales";
            gridViewTextBoxColumn15.Width = 99;
            gridViewTextBoxColumn16.FieldName = "Taller";
            gridViewTextBoxColumn16.HeaderText = "Taller";
            gridViewTextBoxColumn16.Name = "Taller";
            gridViewTextBoxColumn16.Width = 99;
            gridViewTextBoxColumn17.FieldName = "Descuento";
            gridViewTextBoxColumn17.HeaderText = "Descuento";
            gridViewTextBoxColumn17.Name = "Descuento";
            gridViewTextBoxColumn17.Width = 99;
            gridViewTextBoxColumn18.FieldName = "Senia";
            gridViewTextBoxColumn18.HeaderText = "Senia";
            gridViewTextBoxColumn18.Name = "Senia";
            gridViewTextBoxColumn18.Width = 141;
            this.dgvhistorial.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18});
            this.dgvhistorial.Name = "dgvhistorial";
            this.dgvhistorial.ReadOnly = true;
            this.dgvhistorial.Size = new System.Drawing.Size(963, 247);
            this.dgvhistorial.TabIndex = 0;
            this.dgvhistorial.Text = "radGridView1";
            this.dgvhistorial.ThemeName = "TelerikMetro";
            // 
            // ucHistorialPagosChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvhistorial);
            this.Name = "ucHistorialPagosChofer";
            this.Size = new System.Drawing.Size(963, 247);
            this.Load += new System.EventHandler(this.ucHistorialPagosChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorial.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvhistorial;

    }
}
