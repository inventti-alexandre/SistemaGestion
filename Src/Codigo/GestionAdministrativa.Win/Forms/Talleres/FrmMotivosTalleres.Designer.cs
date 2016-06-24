namespace GestionAdministrativa.Win.Forms.Talleres
{
    partial class FrmMotivosTalleres
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.DgvMotivosTalleres = new Telerik.WinControls.UI.RadGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtMotivo = new Telerik.WinControls.UI.RadTextBox();
            this.PnlNuevoTipo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMotivosTalleres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMotivosTalleres.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMotivo)).BeginInit();
            this.PnlNuevoTipo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMotivosTalleres
            // 
            this.DgvMotivosTalleres.AutoSizeRows = true;
            this.DgvMotivosTalleres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMotivosTalleres.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMotivosTalleres.Location = new System.Drawing.Point(0, 0);
            // 
            // DgvMotivosTalleres
            // 
            this.DgvMotivosTalleres.MasterTemplate.AllowAddNewRow = false;
            this.DgvMotivosTalleres.MasterTemplate.AllowColumnReorder = false;
            this.DgvMotivosTalleres.MasterTemplate.AllowDragToGroup = false;
            this.DgvMotivosTalleres.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn2.FieldName = "Motivo";
            gridViewTextBoxColumn2.HeaderText = "Motivo";
            gridViewTextBoxColumn2.Name = "Motivo";
            gridViewTextBoxColumn2.Width = 715;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.MaxWidth = 25;
            gridViewCommandColumn2.MinWidth = 25;
            gridViewCommandColumn2.Name = "Delete";
            gridViewCommandColumn2.Width = 25;
            this.DgvMotivosTalleres.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewCommandColumn2});
            this.DgvMotivosTalleres.Name = "DgvMotivosTalleres";
            this.DgvMotivosTalleres.ReadOnly = true;
            this.DgvMotivosTalleres.Size = new System.Drawing.Size(761, 302);
            this.DgvMotivosTalleres.TabIndex = 22;
            this.DgvMotivosTalleres.Text = "radGridView1";
            this.DgvMotivosTalleres.ThemeName = "TelerikMetro";
            this.DgvMotivosTalleres.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DgvTiposTalleres_CommandCellClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAgregar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(647, 44);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(103, 41);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(3, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 41);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cerrar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(3, 13);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(70, 25);
            this.radLabel3.TabIndex = 17;
            this.radLabel3.Text = "Motivo";
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMotivo.Location = new System.Drawing.Point(79, 10);
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(671, 28);
            this.TxtMotivo.TabIndex = 16;
            this.TxtMotivo.TabStop = false;
            this.TxtMotivo.ThemeName = "TelerikMetro";
            // 
            // PnlNuevoTipo
            // 
            this.PnlNuevoTipo.Controls.Add(this.radLabel3);
            this.PnlNuevoTipo.Controls.Add(this.TxtMotivo);
            this.PnlNuevoTipo.Controls.Add(this.BtnAgregar);
            this.PnlNuevoTipo.Location = new System.Drawing.Point(15, 12);
            this.PnlNuevoTipo.Name = "PnlNuevoTipo";
            this.PnlNuevoTipo.Size = new System.Drawing.Size(758, 92);
            this.PnlNuevoTipo.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvMotivosTalleres);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 302);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Location = new System.Drawing.Point(653, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 46);
            this.panel2.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMotivosTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(780, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlNuevoTipo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMotivosTalleres";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Motivos Talleres";
            this.Load += new System.EventHandler(this.FrmMotivosTalleres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMotivosTalleres.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMotivosTalleres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMotivo)).EndInit();
            this.PnlNuevoTipo.ResumeLayout(false);
            this.PnlNuevoTipo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvMotivosTalleres;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtMotivo;
        private System.Windows.Forms.Panel PnlNuevoTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
