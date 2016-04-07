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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
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
            gridViewTextBoxColumn1.FieldName = "FechaAlta";
            gridViewTextBoxColumn1.HeaderText = "Fecha";
            gridViewTextBoxColumn1.Name = "FechaAlta";
            gridViewTextBoxColumn1.Width = 109;
            gridViewTextBoxColumn2.FieldName = "Desde";
            gridViewTextBoxColumn2.HeaderText = "Desde";
            gridViewTextBoxColumn2.Name = "Desde";
            gridViewTextBoxColumn2.Width = 94;
            gridViewTextBoxColumn3.FieldName = "Hasta";
            gridViewTextBoxColumn3.HeaderText = "Hasta";
            gridViewTextBoxColumn3.Name = "Hasta";
            gridViewTextBoxColumn3.Width = 94;
            gridViewTextBoxColumn4.FieldName = "Numero";
            gridViewTextBoxColumn4.HeaderText = "Movil";
            gridViewTextBoxColumn4.Name = "Numero";
            gridViewTextBoxColumn4.Width = 79;
            gridViewTextBoxColumn5.FieldName = "Monto";
            gridViewTextBoxColumn5.HeaderText = "Monto";
            gridViewTextBoxColumn5.Name = "Monto";
            gridViewTextBoxColumn5.Width = 94;
            gridViewTextBoxColumn6.FieldName = "Efectivo";
            gridViewTextBoxColumn6.HeaderText = "Efectivo";
            gridViewTextBoxColumn6.Name = "Efectivo";
            gridViewTextBoxColumn6.Width = 94;
            gridViewTextBoxColumn7.FieldName = "Vales";
            gridViewTextBoxColumn7.HeaderText = "Vales";
            gridViewTextBoxColumn7.Name = "Vales";
            gridViewTextBoxColumn7.Width = 94;
            gridViewTextBoxColumn8.FieldName = "Taller";
            gridViewTextBoxColumn8.HeaderText = "Taller";
            gridViewTextBoxColumn8.Name = "Taller";
            gridViewTextBoxColumn8.Width = 94;
            gridViewTextBoxColumn9.FieldName = "Descuento";
            gridViewTextBoxColumn9.HeaderText = "Descuento";
            gridViewTextBoxColumn9.Name = "Descuento";
            gridViewTextBoxColumn9.Width = 94;
            gridViewTextBoxColumn10.FieldName = "Senia";
            gridViewTextBoxColumn10.HeaderText = "Senia";
            gridViewTextBoxColumn10.Name = "Senia";
            gridViewTextBoxColumn10.Width = 104;
            this.dgvhistorial.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.dgvhistorial.Name = "dgvhistorial";
            this.dgvhistorial.ReadOnly = true;
            this.dgvhistorial.Size = new System.Drawing.Size(963, 200);
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
            this.Size = new System.Drawing.Size(963, 200);
            this.Load += new System.EventHandler(this.ucHistorialPagosChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorial.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvhistorial;

    }
}
