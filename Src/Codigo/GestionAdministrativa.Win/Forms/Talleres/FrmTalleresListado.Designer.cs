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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.DgvTalleresMoviles = new Telerik.WinControls.UI.RadGridView();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.TxtMovil = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.BtnDevolver = new System.Windows.Forms.Button();
            this.ucFiltroMoviles = new GestionAdministrativa.Win.Forms.Moviles.ucFiltroMoviles();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTalleresMoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTalleresMoviles.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTalleresMoviles
            // 
            this.DgvTalleresMoviles.Location = new System.Drawing.Point(12, 290);
            // 
            // DgvTalleresMoviles
            // 
            this.DgvTalleresMoviles.MasterTemplate.AllowAddNewRow = false;
            this.DgvTalleresMoviles.MasterTemplate.AllowDeleteRow = false;
            this.DgvTalleresMoviles.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.FieldName = "MovilNumero";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Movil";
            gridViewTextBoxColumn1.Name = "Movil";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 70;
            gridViewTextBoxColumn2.FieldName = "FechaDesde";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Fecha Desde";
            gridViewTextBoxColumn2.Name = "FechaDesde";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.FieldName = "FechaHasta";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Fecha Hasta";
            gridViewTextBoxColumn3.Name = "FechaHasta";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 150;
            gridViewCheckBoxColumn1.FieldName = "Activo";
            gridViewCheckBoxColumn1.HeaderText = "Activo";
            gridViewCheckBoxColumn1.Name = "Activo";
            gridViewCheckBoxColumn1.ReadOnly = true;
            gridViewCheckBoxColumn1.Width = 80;
            gridViewTextBoxColumn4.FieldName = "Observaciones";
            gridViewTextBoxColumn4.HeaderText = "Observaciones";
            gridViewTextBoxColumn4.MinWidth = 350;
            gridViewTextBoxColumn4.Name = "Observaciones";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 350;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.Reload_16x16;
            gridViewCommandColumn1.MaxWidth = 25;
            gridViewCommandColumn1.MinWidth = 25;
            gridViewCommandColumn1.Name = "Fin";
            gridViewCommandColumn1.RowSpan = 16;
            gridViewCommandColumn1.Width = 25;
            this.DgvTalleresMoviles.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1});
            this.DgvTalleresMoviles.Name = "DgvTalleresMoviles";
            this.DgvTalleresMoviles.Size = new System.Drawing.Size(1254, 487);
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
            this.BtnCrear.Location = new System.Drawing.Point(12, -6);
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
            this.TxtMovil.Location = new System.Drawing.Point(894, 0);
            this.TxtMovil.Name = "TxtMovil";
            this.TxtMovil.Size = new System.Drawing.Size(357, 28);
            this.TxtMovil.TabIndex = 17;
            this.TxtMovil.TabStop = false;
            this.TxtMovil.ThemeName = "TelerikMetro";
            this.TxtMovil.TextChanged += new System.EventHandler(this.TxtMovil_TextChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(818, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 25);
            this.radLabel2.TabIndex = 23;
            this.radLabel2.Text = "Movil:";
            // 
            // BtnDevolver
            // 
            this.BtnDevolver.BackColor = System.Drawing.Color.Yellow;
            this.BtnDevolver.FlatAppearance.BorderSize = 0;
            this.BtnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDevolver.Location = new System.Drawing.Point(612, 0);
            this.BtnDevolver.Name = "BtnDevolver";
            this.BtnDevolver.Size = new System.Drawing.Size(184, 28);
            this.BtnDevolver.TabIndex = 19;
            this.BtnDevolver.Text = "Devolver cartel";
            this.BtnDevolver.UseVisualStyleBackColor = false;
            this.BtnDevolver.Click += new System.EventHandler(this.BtnDevolver_Click);
            // 
            // ucFiltroMoviles
            // 
            this.ucFiltroMoviles.Activo = true;
            this.ucFiltroMoviles.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucFiltroMoviles.Location = new System.Drawing.Point(13, 42);
            this.ucFiltroMoviles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ucFiltroMoviles.Name = "ucFiltroMoviles";
            this.ucFiltroMoviles.Numero = 0;
            this.ucFiltroMoviles.Patente = "";
            this.ucFiltroMoviles.Size = new System.Drawing.Size(819, 164);
            this.ucFiltroMoviles.TabIndex = 24;
            // 
            // FrmTalleresListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 778);
            this.ControlBox = false;
            this.Controls.Add(this.ucFiltroMoviles);
            this.Controls.Add(this.BtnDevolver);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.TxtMovil);
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
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvTalleresMoviles;
        private System.Windows.Forms.Button BtnCrear;
        private Telerik.WinControls.UI.RadTextBox TxtMovil;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.Button BtnDevolver;
        private Moviles.ucFiltroMoviles ucFiltroMoviles;
    }
}
