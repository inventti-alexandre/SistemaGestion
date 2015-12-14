namespace GestionAdministrativa.Win.Forms.Moviles
{
    partial class FrmMovilListado
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
            this.DgvMovil = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovil.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMovil
            // 
            this.DgvMovil.Location = new System.Drawing.Point(12, 83);
            // 
            // DgvMovil
            // 
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Numero";
            gridViewTextBoxColumn1.Name = "Numero";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Patente";
            gridViewTextBoxColumn2.Name = "Patente";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Fecha Alta";
            gridViewTextBoxColumn3.Name = "FechaAlta";
            this.DgvMovil.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.DgvMovil.Name = "DgvMovil";
            this.DgvMovil.Size = new System.Drawing.Size(1373, 619);
            this.DgvMovil.TabIndex = 0;
            this.DgvMovil.Text = "Listado de Moviles";
            // 
            // FrmMovilListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 714);
            this.Controls.Add(this.DgvMovil);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMovilListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmMovilListado";
            this.Load += new System.EventHandler(this.FrmMovilListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovil.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvMovil;
    }
}
