namespace GestionAdministrativa.Win.Forms.Choferes
{
    partial class FrmChoferesListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn5 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn6 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.GridChoferes = new Telerik.WinControls.UI.RadGridView();
            this.ucFiltroChoferes = new GestionAdministrativa.Win.Forms.Choferes.ucFiltroChoferes();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridChoferes
            // 
            this.GridChoferes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridChoferes.Location = new System.Drawing.Point(13, 231);
            // 
            // GridChoferes
            // 
            this.GridChoferes.MasterTemplate.AllowColumnReorder = false;
            this.GridChoferes.MasterTemplate.AllowDragToGroup = false;
            this.GridChoferes.MasterTemplate.AutoGenerateColumns = false;
            this.GridChoferes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn8.Expression = "";
            gridViewTextBoxColumn8.FieldName = "Dni";
            gridViewTextBoxColumn8.HeaderText = "Dni";
            gridViewTextBoxColumn8.Name = "DNI";
            gridViewTextBoxColumn8.Width = 188;
            gridViewTextBoxColumn9.FieldName = "Apellido";
            gridViewTextBoxColumn9.HeaderText = "Apellido";
            gridViewTextBoxColumn9.Name = "Apellido";
            gridViewTextBoxColumn9.Width = 188;
            gridViewTextBoxColumn10.FieldName = "Nombre";
            gridViewTextBoxColumn10.HeaderText = "Nombre";
            gridViewTextBoxColumn10.Name = "Nombre";
            gridViewTextBoxColumn10.Width = 188;
            gridViewTextBoxColumn11.FieldName = "Telefono";
            gridViewTextBoxColumn11.HeaderText = "Telefono";
            gridViewTextBoxColumn11.Name = "Telefono";
            gridViewTextBoxColumn11.Width = 188;
            gridViewTextBoxColumn12.FieldName = "Email";
            gridViewTextBoxColumn12.HeaderText = "Email";
            gridViewTextBoxColumn12.Name = "Email";
            gridViewTextBoxColumn12.Width = 188;
            gridViewTextBoxColumn13.FieldName = "MovilNumero";
            gridViewTextBoxColumn13.HeaderText = "Movil";
            gridViewTextBoxColumn13.Name = "Movil";
            gridViewTextBoxColumn13.Width = 185;
            gridViewTextBoxColumn14.FieldName = "CelularObservacion";
            gridViewTextBoxColumn14.HeaderText = "Celular";
            gridViewTextBoxColumn14.Name = "CelularObservacion";
            gridViewTextBoxColumn14.Width = 109;
            gridViewCommandColumn4.HeaderText = "";
            gridViewCommandColumn4.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn4.MaxWidth = 30;
            gridViewCommandColumn4.MinWidth = 30;
            gridViewCommandColumn4.Name = "Edit";
            gridViewCommandColumn4.Width = 30;
            gridViewCommandColumn5.HeaderText = "";
            gridViewCommandColumn5.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Files;
            gridViewCommandColumn5.MaxWidth = 30;
            gridViewCommandColumn5.MinWidth = 30;
            gridViewCommandColumn5.Name = "Detail";
            gridViewCommandColumn5.Width = 30;
            gridViewCommandColumn6.HeaderText = "";
            gridViewCommandColumn6.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn6.MaxWidth = 30;
            gridViewCommandColumn6.MinWidth = 30;
            gridViewCommandColumn6.Name = "Delete";
            gridViewCommandColumn6.Width = 30;
            this.GridChoferes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewCommandColumn4,
            gridViewCommandColumn5,
            gridViewCommandColumn6});
            this.GridChoferes.Name = "GridChoferes";
            this.GridChoferes.ReadOnly = true;
            this.GridChoferes.Size = new System.Drawing.Size(1337, 413);
            this.GridChoferes.TabIndex = 1;
            this.GridChoferes.Text = "Listado de Choferes";
            this.GridChoferes.ThemeName = "TelerikMetro";
            this.GridChoferes.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridChoferes_CommandCellClick);
            // 
            // ucFiltroChoferes
            // 
            this.ucFiltroChoferes.Denominacion = "";
            this.ucFiltroChoferes.DNI = 0;
            this.ucFiltroChoferes.Location = new System.Drawing.Point(4, 4);
            this.ucFiltroChoferes.Margin = new System.Windows.Forms.Padding(4);
            this.ucFiltroChoferes.MovilId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucFiltroChoferes.Name = "ucFiltroChoferes";
            this.ucFiltroChoferes.Size = new System.Drawing.Size(838, 147);
            this.ucFiltroChoferes.TabIndex = 2;
            this.ucFiltroChoferes.Titular = "";
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Controls.Add(this.ucFiltroChoferes);
            this.radPanel1.Location = new System.Drawing.Point(13, 64);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1337, 155);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(12, 12);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(132, 41);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Crear";
            this.BtnCancelar.ThemeName = "TelerikMetro";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmChoferesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 658);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.GridChoferes);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmChoferesListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de Choferes";
            this.Load += new System.EventHandler(this.FrmChoferesListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GridChoferes;
        private ucFiltroChoferes ucFiltroChoferes;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
    }
}