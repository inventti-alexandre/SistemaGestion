namespace GestionAdministrativa.Win.Forms.Pagos
{
    partial class ucDetalleDeuda
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.radGridView1 = new Telerik.WinControls.UI.MasterGridViewTemplate();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.TxtTotalDeuda = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.GrillaAPagar = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalDeuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAPagar.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.AllowColumnReorder = false;
            this.radGridView1.AllowDragToGroup = false;
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Movil";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 156;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Descripcion";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 156;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Monto";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 157;
            this.radGridView1.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(410, 241);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(100, 28);
            this.radTextBox1.TabIndex = 3;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.ThemeName = "TelerikMetro";
            // 
            // TxtTotalDeuda
            // 
            this.TxtTotalDeuda.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalDeuda.Location = new System.Drawing.Point(488, 243);
            this.TxtTotalDeuda.Name = "TxtTotalDeuda";
            this.TxtTotalDeuda.Size = new System.Drawing.Size(100, 28);
            this.TxtTotalDeuda.TabIndex = 3;
            this.TxtTotalDeuda.TabStop = false;
            this.TxtTotalDeuda.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(412, 246);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 25);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Total:";
            // 
            // GrillaAPagar
            // 
            this.GrillaAPagar.Location = new System.Drawing.Point(11, 38);
            // 
            // GrillaAPagar
            // 
            this.GrillaAPagar.MasterTemplate.AllowAddNewRow = false;
            this.GrillaAPagar.MasterTemplate.AllowColumnReorder = false;
            this.GrillaAPagar.MasterTemplate.AllowDragToGroup = false;
            this.GrillaAPagar.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaAPagar.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn4.FieldName = "Desde";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Desde";
            gridViewTextBoxColumn4.Name = "Desde";
            gridViewTextBoxColumn4.Width = 155;
            gridViewTextBoxColumn5.FieldName = "Hasta";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Hasta";
            gridViewTextBoxColumn5.Name = "Hasta";
            gridViewTextBoxColumn5.Width = 155;
            gridViewTextBoxColumn6.FieldName = "Monto";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Monto";
            gridViewTextBoxColumn6.Name = "Monto";
            gridViewTextBoxColumn6.Width = 157;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.edit;
            gridViewCommandColumn1.Name = "Editar";
            gridViewCommandColumn1.Width = 45;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.delete;
            gridViewCommandColumn2.Name = "Eliminar";
            gridViewCommandColumn2.Width = 47;
            this.GrillaAPagar.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.GrillaAPagar.Name = "GrillaAPagar";
            this.GrillaAPagar.ReadOnly = true;
            this.GrillaAPagar.Size = new System.Drawing.Size(577, 199);
            this.GrillaAPagar.TabIndex = 1;
            this.GrillaAPagar.Text = "radGridView2";
            this.GrillaAPagar.ThemeName = "TelerikMetro";
            this.GrillaAPagar.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaAPagar_CommandCellClick);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(11, 10);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(151, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Detalle deuda:";
            // 
            // ucDetalleDeuda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.TxtTotalDeuda);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.GrillaAPagar);
            this.Controls.Add(this.radLabel1);
            this.Name = "ucDetalleDeuda";
            this.Size = new System.Drawing.Size(604, 285);
            this.Load += new System.EventHandler(this.ucDetalleDeuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalDeuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAPagar.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.MasterGridViewTemplate radGridView1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox TxtTotalDeuda;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadGridView GrillaAPagar;
        private Telerik.WinControls.UI.RadLabel radLabel1;


    }
}
