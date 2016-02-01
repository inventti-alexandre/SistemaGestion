namespace GestionAdministrativa.Win.Forms.Pagos
{
    partial class ucPagos
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.gridPagos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(432, 201);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(149, 30);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(317, 201);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(108, 28);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Total Pagos:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(453, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 34);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // gridPagos
            // 
            this.gridPagos.Location = new System.Drawing.Point(14, 44);
            // 
            // gridPagos
            // 
            this.gridPagos.MasterTemplate.AllowAddNewRow = false;
            this.gridPagos.MasterTemplate.AllowColumnReorder = false;
            this.gridPagos.MasterTemplate.AllowDragToGroup = false;
            this.gridPagos.MasterTemplate.AutoGenerateColumns = false;
            this.gridPagos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TipoPago";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Tipo";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 250;
            gridViewTextBoxColumn2.FieldName = "Importe";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Monto";
            gridViewTextBoxColumn2.Name = "column3";
            gridViewTextBoxColumn2.Width = 267;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.delete;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Eliminar";
            gridViewCommandColumn1.Width = 30;
            this.gridPagos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1});
            this.gridPagos.Name = "gridPagos";
            this.gridPagos.ReadOnly = true;
            this.gridPagos.Size = new System.Drawing.Size(567, 150);
            this.gridPagos.TabIndex = 0;
            this.gridPagos.Text = "radGridView1";
            this.gridPagos.ThemeName = "TelerikMetro";
            this.gridPagos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gridPagos_CommandCellClick);
            // 
            // ucPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.gridPagos);
            this.Name = "ucPagos";
            this.Size = new System.Drawing.Size(604, 243);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridPagos;
        private System.Windows.Forms.Button BtnAgregar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
    }
}
