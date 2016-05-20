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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
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
            gridViewTextBoxColumn1.FieldName = "Desde";
            gridViewTextBoxColumn1.HeaderText = "Desde";
            gridViewTextBoxColumn1.Name = "Desde";
            gridViewTextBoxColumn1.Width = 147;
            gridViewTextBoxColumn2.FieldName = "Hasta";
            gridViewTextBoxColumn2.HeaderText = "Hasta";
            gridViewTextBoxColumn2.Name = "Hasta";
            gridViewTextBoxColumn2.Width = 147;
            gridViewTextBoxColumn3.FieldName = "Movil.Numero";
            gridViewTextBoxColumn3.HeaderText = "Movil";
            gridViewTextBoxColumn3.Name = "Movil.Numero";
            gridViewTextBoxColumn3.Width = 124;
            gridViewTextBoxColumn4.FieldName = "Total";
            gridViewTextBoxColumn4.HeaderText = "Monto";
            gridViewTextBoxColumn4.Name = "Total";
            gridViewTextBoxColumn4.Width = 147;
            gridViewTextBoxColumn5.FieldName = "Taller";
            gridViewTextBoxColumn5.HeaderText = "Taller";
            gridViewTextBoxColumn5.Name = "Taller";
            gridViewTextBoxColumn5.Width = 148;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn1.MaxWidth = 25;
            gridViewCommandColumn1.MinWidth = 25;
            gridViewCommandColumn1.Name = "Delete";
            gridViewCommandColumn1.Width = 25;
            this.DgvListadoPagoBase.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPagoBase.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPagoBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvListadoPagoBase;
        private System.Windows.Forms.Button BtnAceptar;

    }
}
