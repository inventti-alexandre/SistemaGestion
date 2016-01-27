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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
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
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Movil";
            gridViewTextBoxColumn7.Name = "column1";
            gridViewTextBoxColumn7.Width = 156;
            gridViewTextBoxColumn8.FormatString = "";
            gridViewTextBoxColumn8.HeaderText = "Descripcion";
            gridViewTextBoxColumn8.Name = "column2";
            gridViewTextBoxColumn8.Width = 156;
            gridViewTextBoxColumn9.FormatString = "";
            gridViewTextBoxColumn9.HeaderText = "Monto";
            gridViewTextBoxColumn9.Name = "column3";
            gridViewTextBoxColumn9.Width = 157;
            this.radGridView1.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
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
            gridViewTextBoxColumn10.FieldName = "Desde";
            gridViewTextBoxColumn10.FormatString = "";
            gridViewTextBoxColumn10.HeaderText = "Desde";
            gridViewTextBoxColumn10.Name = "Desde";
            gridViewTextBoxColumn10.Width = 185;
            gridViewTextBoxColumn11.FieldName = "Hasta";
            gridViewTextBoxColumn11.FormatString = "";
            gridViewTextBoxColumn11.HeaderText = "Hasta";
            gridViewTextBoxColumn11.Name = "Hasta";
            gridViewTextBoxColumn11.Width = 185;
            gridViewTextBoxColumn12.FieldName = "Monto";
            gridViewTextBoxColumn12.FormatString = "";
            gridViewTextBoxColumn12.HeaderText = "Monto";
            gridViewTextBoxColumn12.Name = "Monto";
            gridViewTextBoxColumn12.Width = 187;
            this.GrillaAPagar.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.GrillaAPagar.Name = "GrillaAPagar";
            this.GrillaAPagar.ReadOnly = true;
            this.GrillaAPagar.Size = new System.Drawing.Size(577, 199);
            this.GrillaAPagar.TabIndex = 1;
            this.GrillaAPagar.Text = "radGridView2";
            this.GrillaAPagar.ThemeName = "TelerikMetro";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
