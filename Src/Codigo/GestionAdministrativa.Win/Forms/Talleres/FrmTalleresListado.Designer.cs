namespace GestionAdministrativa.Win.Forms.Talleres
{
    partial class FrmTalleresListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.DgvTalleresMoviles = new Telerik.WinControls.UI.RadGridView();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.TxtMovil = new Telerik.WinControls.UI.RadTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTalleresMoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTalleresMoviles.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMovil)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTalleresMoviles
            // 
            this.DgvTalleresMoviles.Location = new System.Drawing.Point(12, 122);
            // 
            // DgvTalleresMoviles
            // 
            this.DgvTalleresMoviles.MasterTemplate.AllowAddNewRow = false;
            this.DgvTalleresMoviles.MasterTemplate.AllowDeleteRow = false;
            this.DgvTalleresMoviles.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn5.FieldName = "MovilNumero";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Movil";
            gridViewTextBoxColumn5.Name = "Movil";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 70;
            gridViewTextBoxColumn6.FieldName = "FechaDesde";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Fecha Desde";
            gridViewTextBoxColumn6.Name = "FechaDesde";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.FieldName = "FechaHasta";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Fecha Hasta";
            gridViewTextBoxColumn7.Name = "FechaHasta";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 150;
            gridViewCheckBoxColumn3.FieldName = "Activo";
            gridViewCheckBoxColumn3.HeaderText = "Activo";
            gridViewCheckBoxColumn3.Name = "Activo";
            gridViewCheckBoxColumn3.ReadOnly = true;
            gridViewCheckBoxColumn3.Width = 80;
            gridViewCheckBoxColumn4.FieldName = "Acreditado";
            gridViewCheckBoxColumn4.HeaderText = "Acreditado";
            gridViewCheckBoxColumn4.Name = "Acreditado";
            gridViewCheckBoxColumn4.ReadOnly = true;
            gridViewCheckBoxColumn4.Width = 80;
            gridViewTextBoxColumn8.FieldName = "Observaciones";
            gridViewTextBoxColumn8.HeaderText = "Observaciones";
            gridViewTextBoxColumn8.MinWidth = 350;
            gridViewTextBoxColumn8.Name = "Observaciones";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 350;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.Reload_16x16;
            gridViewCommandColumn2.MaxWidth = 25;
            gridViewCommandColumn2.MinWidth = 25;
            gridViewCommandColumn2.Name = "Fin";
            gridViewCommandColumn2.RowSpan = 16;
            gridViewCommandColumn2.Width = 25;
            this.DgvTalleresMoviles.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCheckBoxColumn3,
            gridViewCheckBoxColumn4,
            gridViewTextBoxColumn8,
            gridViewCommandColumn2});
            this.DgvTalleresMoviles.Name = "DgvTalleresMoviles";
            this.DgvTalleresMoviles.Size = new System.Drawing.Size(1254, 558);
            this.DgvTalleresMoviles.TabIndex = 0;
            this.DgvTalleresMoviles.Text = "radGridView1";
            this.DgvTalleresMoviles.ThemeName = "TelerikMetro";
            this.DgvTalleresMoviles.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DgvTalleresMoviles_CommandCellClick);
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.Yellow;
            this.BtnCrear.FlatAppearance.BorderSize = 0;
            this.BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrear.Location = new System.Drawing.Point(12, 34);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(153, 41);
            this.BtnCrear.TabIndex = 11;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // TxtMovil
            // 
            this.TxtMovil.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMovil.Location = new System.Drawing.Point(79, 4);
            this.TxtMovil.Name = "TxtMovil";
            this.TxtMovil.Size = new System.Drawing.Size(357, 28);
            this.TxtMovil.TabIndex = 17;
            this.TxtMovil.TabStop = false;
            this.TxtMovil.ThemeName = "TelerikMetro";
            this.TxtMovil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMovil_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Controls.Add(this.TxtMovil);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 35);
            this.panel1.TabIndex = 18;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(3, 7);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 25);
            this.radLabel2.TabIndex = 23;
            this.radLabel2.Text = "Movil:";
            // 
            // FrmTalleresListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.DgvTalleresMoviles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTalleresListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmTalleresListado";
            this.Load += new System.EventHandler(this.FrmTalleresListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTalleresMoviles.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTalleresMoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMovil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvTalleresMoviles;
        private System.Windows.Forms.Button BtnCrear;
        private Telerik.WinControls.UI.RadTextBox TxtMovil;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
