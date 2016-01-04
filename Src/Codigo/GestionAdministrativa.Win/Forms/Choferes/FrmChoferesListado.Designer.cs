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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.GridChoferes = new Telerik.WinControls.UI.RadGridView();
            this.ucFiltroChoferes = new GestionAdministrativa.Win.Forms.Choferes.ucFiltroChoferes();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridChoferes
            // 
            this.GridChoferes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridChoferes.Location = new System.Drawing.Point(13, 208);
            // 
            // GridChoferes
            // 
            this.GridChoferes.MasterTemplate.AllowColumnReorder = false;
            this.GridChoferes.MasterTemplate.AllowDragToGroup = false;
            this.GridChoferes.MasterTemplate.AutoGenerateColumns = false;
            this.GridChoferes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.Expression = "";
            gridViewTextBoxColumn1.FieldName = "Dni";
            gridViewTextBoxColumn1.HeaderText = "Dni";
            gridViewTextBoxColumn1.Name = "DNI";
            gridViewTextBoxColumn1.Width = 155;
            gridViewTextBoxColumn2.FieldName = "Apellido";
            gridViewTextBoxColumn2.HeaderText = "Apellido";
            gridViewTextBoxColumn2.Name = "Apellido";
            gridViewTextBoxColumn2.Width = 155;
            gridViewTextBoxColumn3.FieldName = "Nombre";
            gridViewTextBoxColumn3.HeaderText = "Nombre";
            gridViewTextBoxColumn3.Name = "Nombre";
            gridViewTextBoxColumn3.Width = 155;
            gridViewTextBoxColumn4.FieldName = "Telefono";
            gridViewTextBoxColumn4.HeaderText = "Telefono";
            gridViewTextBoxColumn4.Name = "Telefono";
            gridViewTextBoxColumn4.Width = 155;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "Email";
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 155;
            gridViewTextBoxColumn6.FieldName = "MovilNumero";
            gridViewTextBoxColumn6.HeaderText = "Movil";
            gridViewTextBoxColumn6.Name = "Movil";
            gridViewTextBoxColumn6.Width = 152;
            gridViewTextBoxColumn7.FieldName = "CelularObservacion";
            gridViewTextBoxColumn7.HeaderText = "Celular";
            gridViewTextBoxColumn7.Name = "CelularObservacion";
            gridViewTextBoxColumn7.Width = 88;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Edit";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Files;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "Detail";
            gridViewCommandColumn2.Width = 30;
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "Delete";
            gridViewCommandColumn3.Width = 30;
            this.GridChoferes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.GridChoferes.Name = "GridChoferes";
            this.GridChoferes.ReadOnly = true;
            this.GridChoferes.Size = new System.Drawing.Size(1118, 260);
            this.GridChoferes.TabIndex = 1;
            this.GridChoferes.Text = "Listado de Choferes";
            this.GridChoferes.ThemeName = "TelerikMetro";
            this.GridChoferes.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridChoferes_CommandCellClick);
            // 
            // ucFiltroChoferes
            // 
            this.ucFiltroChoferes.Denominacion = "";
            this.ucFiltroChoferes.DNI = 0;
            this.ucFiltroChoferes.Location = new System.Drawing.Point(27, 33);
            this.ucFiltroChoferes.Margin = new System.Windows.Forms.Padding(4);
            this.ucFiltroChoferes.MovilId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucFiltroChoferes.Name = "ucFiltroChoferes";
            this.ucFiltroChoferes.Size = new System.Drawing.Size(838, 168);
            this.ucFiltroChoferes.TabIndex = 2;
            this.ucFiltroChoferes.Titular = "";
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Location = new System.Drawing.Point(13, 13);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1118, 189);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // FrmChoferesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 482);
            this.Controls.Add(this.ucFiltroChoferes);
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
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GridChoferes;
        private ucFiltroChoferes ucFiltroChoferes;
        private Telerik.WinControls.UI.RadPanel radPanel1;
    }
}