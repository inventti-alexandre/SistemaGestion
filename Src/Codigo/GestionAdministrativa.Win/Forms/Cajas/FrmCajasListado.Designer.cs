namespace GestionAdministrativa.Win.Forms.Cajas
{
    partial class FrmCajasListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn5 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn6 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.GridChoferes = new Telerik.WinControls.UI.MasterGridViewTemplate();
            this.GridCajas = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCajas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridChoferes
            // 
            this.GridChoferes.AllowColumnReorder = false;
            this.GridChoferes.AllowDragToGroup = false;
            this.GridChoferes.AutoGenerateColumns = false;
            this.GridChoferes.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FCierre";
            gridViewTextBoxColumn1.HeaderText = "Fecha Hora Cierre";
            gridViewTextBoxColumn1.Name = "FCierre";
            gridViewTextBoxColumn1.Width = 314;
            gridViewTextBoxColumn2.FieldName = "Ingresos";
            gridViewTextBoxColumn2.HeaderText = "Ingresos";
            gridViewTextBoxColumn2.Name = "Ingresos";
            gridViewTextBoxColumn2.Width = 207;
            gridViewTextBoxColumn3.FieldName = "Egresos";
            gridViewTextBoxColumn3.HeaderText = "Egresos";
            gridViewTextBoxColumn3.Name = "Egresos";
            gridViewTextBoxColumn3.Width = 207;
            gridViewTextBoxColumn4.FieldName = "Efectivo";
            gridViewTextBoxColumn4.HeaderText = "Efectivo";
            gridViewTextBoxColumn4.Name = "Efectivo";
            gridViewTextBoxColumn4.Width = 178;
            gridViewTextBoxColumn5.FieldName = "Vales";
            gridViewTextBoxColumn5.HeaderText = "Vales";
            gridViewTextBoxColumn5.Name = "Vales";
            gridViewTextBoxColumn5.Width = 207;
            gridViewTextBoxColumn6.FieldName = "Aprobada";
            gridViewTextBoxColumn6.HeaderText = "Aprobada";
            gridViewTextBoxColumn6.Name = "Aprobada";
            gridViewTextBoxColumn6.Width = 115;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Edit";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Files;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "Detail";
            gridViewCommandColumn2.Width = 30;
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "Delete";
            gridViewCommandColumn3.Width = 30;
            this.GridChoferes.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            // 
            // GridCajas
            // 
            this.GridCajas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCajas.Location = new System.Drawing.Point(18, 258);
            // 
            // GridCajas
            // 
            this.GridCajas.MasterTemplate.AllowColumnReorder = false;
            this.GridCajas.MasterTemplate.AllowDragToGroup = false;
            this.GridCajas.MasterTemplate.AutoGenerateColumns = false;
            this.GridCajas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.FieldName = "Fecha";
            gridViewTextBoxColumn7.HeaderText = "Fecha";
            gridViewTextBoxColumn7.Name = "Fecha";
            gridViewTextBoxColumn7.Width = 749;
            gridViewTextBoxColumn8.FieldName = "Ingresos";
            gridViewTextBoxColumn8.HeaderText = "Ingresos";
            gridViewTextBoxColumn8.Name = "Ingresos";
            gridViewTextBoxColumn8.Width = 189;
            gridViewTextBoxColumn9.FieldName = "Egresos";
            gridViewTextBoxColumn9.HeaderText = "Egresos";
            gridViewTextBoxColumn9.Name = "Egresos";
            gridViewTextBoxColumn9.Width = 189;
            gridViewTextBoxColumn10.FieldName = "Aprobada";
            gridViewTextBoxColumn10.HeaderText = "Aprobada";
            gridViewTextBoxColumn10.Name = "Aprobada";
            gridViewTextBoxColumn10.Width = 99;
            gridViewCommandColumn4.HeaderText = "";
            gridViewCommandColumn4.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn4.MaxWidth = 30;
            gridViewCommandColumn4.MinWidth = 30;
            gridViewCommandColumn4.Name = "Edit";
            gridViewCommandColumn4.Width = 30;
            gridViewCommandColumn5.HeaderText = "";
            gridViewCommandColumn5.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Files;
            gridViewCommandColumn5.MaxWidth = 30;
            gridViewCommandColumn5.MinWidth = 30;
            gridViewCommandColumn5.Name = "Detail";
            gridViewCommandColumn5.Width = 30;
            gridViewCommandColumn6.HeaderText = "";
            gridViewCommandColumn6.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn6.MaxWidth = 30;
            gridViewCommandColumn6.MinWidth = 30;
            gridViewCommandColumn6.Name = "Delete";
            gridViewCommandColumn6.Width = 30;
            this.GridCajas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewCommandColumn4,
            gridViewCommandColumn5,
            gridViewCommandColumn6});
            this.GridCajas.Name = "GridCajas";
            this.GridCajas.ReadOnly = true;
            this.GridCajas.Size = new System.Drawing.Size(1332, 388);
            this.GridCajas.TabIndex = 2;
            this.GridCajas.Text = "Listado de Choferes";
            this.GridCajas.ThemeName = "TelerikMetro";
            // 
            // FrmCajasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 658);
            this.Controls.Add(this.GridCajas);
            this.Name = "FrmCajasListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de Cajas";
            this.Load += new System.EventHandler(this.FrmChoferesListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCajas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.MasterGridViewTemplate GridChoferes;
        private Telerik.WinControls.UI.RadGridView GridCajas;

    }
}