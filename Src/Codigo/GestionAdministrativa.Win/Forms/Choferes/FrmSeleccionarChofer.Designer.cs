namespace GestionAdministrativa.Win.Forms.Choferes
{
    partial class FrmSeleccionarChofer
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.GridChoferes = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridChoferes
            // 
            this.GridChoferes.Location = new System.Drawing.Point(12, 45);
            // 
            // GridChoferes
            // 
            this.GridChoferes.MasterTemplate.AllowAddNewRow = false;
            this.GridChoferes.MasterTemplate.AllowColumnReorder = false;
            this.GridChoferes.MasterTemplate.AllowDragToGroup = false;
            this.GridChoferes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Dni";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Dni";
            gridViewTextBoxColumn1.Name = "Dni";
            gridViewTextBoxColumn1.Width = 196;
            gridViewTextBoxColumn2.FieldName = "Apellido";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Apellido";
            gridViewTextBoxColumn2.Name = "Apellido";
            gridViewTextBoxColumn2.Width = 196;
            gridViewTextBoxColumn3.FieldName = "Nombre";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Nombre";
            gridViewTextBoxColumn3.Name = "Nombre";
            gridViewTextBoxColumn3.Width = 143;
            gridViewCommandColumn1.DefaultText = "Seleccionar";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.MinWidth = 100;
            gridViewCommandColumn1.Name = "Seleccionar";
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 100;
            this.GridChoferes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1});
            this.GridChoferes.Name = "GridChoferes";
            this.GridChoferes.Size = new System.Drawing.Size(654, 452);
            this.GridChoferes.TabIndex = 0;
            this.GridChoferes.Text = "radGridView1";
            this.GridChoferes.ThemeName = "TelerikMetro";
            this.GridChoferes.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridChoferes_CommandCellClick);
            this.GridChoferes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GridChoferes_KeyUp);
            // 
            // FrmSeleccionarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 571);
            this.Controls.Add(this.GridChoferes);
            this.Name = "FrmSeleccionarChofer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Seleccionar Chofer";
            this.Load += new System.EventHandler(this.FrmSeleccionarChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GridChoferes;
    }
}