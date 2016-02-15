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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.GridChoferes = new Telerik.WinControls.UI.MasterGridViewTemplate();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Location = new System.Drawing.Point(3, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1332, 166);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.ThemeName = "TelerikMetro";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 393F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1338, 620);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // FrmCajasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 658);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCajasListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de Choferes";
            this.Load += new System.EventHandler(this.FrmChoferesListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.MasterGridViewTemplate GridChoferes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}