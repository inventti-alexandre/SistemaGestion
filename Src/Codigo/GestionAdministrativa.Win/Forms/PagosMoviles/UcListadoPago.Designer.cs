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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.DgvListadoPagoBase = new Telerik.WinControls.UI.RadGridView();
            this.BtnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPagoBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPagoBase.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListadoPagoBase
            // 
            this.DgvListadoPagoBase.AutoSizeRows = true;
            this.DgvListadoPagoBase.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListadoPagoBase.Location = new System.Drawing.Point(3, 60);
            // 
            // DgvListadoPagoBase
            // 
            this.DgvListadoPagoBase.MasterTemplate.AllowAddNewRow = false;
            this.DgvListadoPagoBase.MasterTemplate.AllowColumnReorder = false;
            this.DgvListadoPagoBase.MasterTemplate.AllowDragToGroup = false;
            this.DgvListadoPagoBase.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn6.FieldName = "Desde";
            gridViewTextBoxColumn6.HeaderText = "Desde";
            gridViewTextBoxColumn6.Name = "Desde";
            gridViewTextBoxColumn6.Width = 147;
            gridViewTextBoxColumn7.FieldName = "Hasta";
            gridViewTextBoxColumn7.HeaderText = "Hasta";
            gridViewTextBoxColumn7.Name = "Hasta";
            gridViewTextBoxColumn7.Width = 147;
            gridViewTextBoxColumn8.FieldName = "Movil.Numero";
            gridViewTextBoxColumn8.HeaderText = "Movil";
            gridViewTextBoxColumn8.Name = "Movil.Numero";
            gridViewTextBoxColumn8.Width = 124;
            gridViewTextBoxColumn9.FieldName = "Total";
            gridViewTextBoxColumn9.HeaderText = "Monto";
            gridViewTextBoxColumn9.Name = "Total";
            gridViewTextBoxColumn9.Width = 147;
            gridViewTextBoxColumn10.FieldName = "Taller";
            gridViewTextBoxColumn10.HeaderText = "Taller";
            gridViewTextBoxColumn10.Name = "Taller";
            gridViewTextBoxColumn10.Width = 148;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.MaxWidth = 25;
            gridViewCommandColumn2.MinWidth = 25;
            gridViewCommandColumn2.Name = "Delete";
            gridViewCommandColumn2.Width = 25;
            this.DgvListadoPagoBase.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewCommandColumn2});
            this.DgvListadoPagoBase.Name = "DgvListadoPagoBase";
            this.DgvListadoPagoBase.ReadOnly = true;
            this.DgvListadoPagoBase.Size = new System.Drawing.Size(755, 167);
            this.DgvListadoPagoBase.TabIndex = 14;
            this.DgvListadoPagoBase.Text = "radGridView1";
            this.DgvListadoPagoBase.ThemeName = "TelerikMetro";
            this.DgvListadoPagoBase.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DgvListadoPagoBase_CommandCellClick);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(649, 13);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(109, 41);
            this.BtnAceptar.TabIndex = 13;
            this.BtnAceptar.Text = "Agregar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // UcListadoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvListadoPagoBase);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "UcListadoPago";
            this.Size = new System.Drawing.Size(768, 237);
            this.Load += new System.EventHandler(this.UcListadoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPagoBase.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPagoBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvListadoPagoBase;
        private System.Windows.Forms.Button BtnAceptar;

    }
}
