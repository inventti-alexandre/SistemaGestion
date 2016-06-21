namespace GestionAdministrativa.Win.Forms.Talleres
{
    partial class FrmTiposTalleres
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.DgvTiposTalleres = new Telerik.WinControls.UI.RadGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPorcentaje = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtDescripcion = new Telerik.WinControls.UI.RadTextBox();
            this.PnlNuevoTipo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposTalleres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposTalleres.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion)).BeginInit();
            this.PnlNuevoTipo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTiposTalleres
            // 
            this.DgvTiposTalleres.AutoSizeRows = true;
            this.DgvTiposTalleres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTiposTalleres.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvTiposTalleres.Location = new System.Drawing.Point(0, 0);
            // 
            // DgvTiposTalleres
            // 
            this.DgvTiposTalleres.MasterTemplate.AllowAddNewRow = false;
            this.DgvTiposTalleres.MasterTemplate.AllowColumnReorder = false;
            this.DgvTiposTalleres.MasterTemplate.AllowDragToGroup = false;
            this.DgvTiposTalleres.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn3.FieldName = "Descripcion";
            gridViewTextBoxColumn3.HeaderText = "Descripcion";
            gridViewTextBoxColumn3.Name = "Descripcion";
            gridViewTextBoxColumn3.Width = 498;
            gridViewTextBoxColumn4.FieldName = "Porcentaje";
            gridViewTextBoxColumn4.HeaderText = "Porcentaje";
            gridViewTextBoxColumn4.Name = "Porcentaje";
            gridViewTextBoxColumn4.Width = 218;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.MaxWidth = 25;
            gridViewCommandColumn2.MinWidth = 25;
            gridViewCommandColumn2.Name = "Delete";
            gridViewCommandColumn2.Width = 25;
            this.DgvTiposTalleres.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn2});
            this.DgvTiposTalleres.Name = "DgvTiposTalleres";
            this.DgvTiposTalleres.ReadOnly = true;
            this.DgvTiposTalleres.Size = new System.Drawing.Size(761, 302);
            this.DgvTiposTalleres.TabIndex = 22;
            this.DgvTiposTalleres.Text = "radGridView1";
            this.DgvTiposTalleres.ThemeName = "TelerikMetro";
            this.DgvTiposTalleres.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DgvTiposTalleres_CommandCellClick);
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
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(494, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(121, 25);
            this.radLabel1.TabIndex = 19;
            this.radLabel1.Text = "Porcentaje:";
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPorcentaje.Location = new System.Drawing.Point(621, 10);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(129, 28);
            this.TxtPorcentaje.TabIndex = 18;
            this.TxtPorcentaje.TabStop = false;
            this.TxtPorcentaje.ThemeName = "TelerikMetro";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(3, 13);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(121, 25);
            this.radLabel3.TabIndex = 17;
            this.radLabel3.Text = "Descripción";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(130, 10);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(357, 28);
            this.TxtDescripcion.TabIndex = 16;
            this.TxtDescripcion.TabStop = false;
            this.TxtDescripcion.ThemeName = "TelerikMetro";
            // 
            // PnlNuevoTipo
            // 
            this.PnlNuevoTipo.Controls.Add(this.radLabel3);
            this.PnlNuevoTipo.Controls.Add(this.TxtDescripcion);
            this.PnlNuevoTipo.Controls.Add(this.BtnAgregar);
            this.PnlNuevoTipo.Controls.Add(this.TxtPorcentaje);
            this.PnlNuevoTipo.Controls.Add(this.radLabel1);
            this.PnlNuevoTipo.Location = new System.Drawing.Point(15, 12);
            this.PnlNuevoTipo.Name = "PnlNuevoTipo";
            this.PnlNuevoTipo.Size = new System.Drawing.Size(758, 92);
            this.PnlNuevoTipo.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvTiposTalleres);
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
            // FrmTiposTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(780, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlNuevoTipo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTiposTalleres";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Tipos Talleres";
            this.Load += new System.EventHandler(this.FrmTiposTalleres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposTalleres.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposTalleres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion)).EndInit();
            this.PnlNuevoTipo.ResumeLayout(false);
            this.PnlNuevoTipo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvTiposTalleres;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtPorcentaje;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtDescripcion;
        private System.Windows.Forms.Panel PnlNuevoTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
