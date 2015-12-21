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
            this.ucFiltroChoferes = new GestionAdministrativa.Win.Forms.Choferes.ucFiltroChoferes();
            this.GridChoferes = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucFiltroChoferes
            // 
            this.ucFiltroChoferes.Denominacion = "";
            this.ucFiltroChoferes.DNI = 0;
            this.ucFiltroChoferes.Location = new System.Drawing.Point(13, 13);
            this.ucFiltroChoferes.Margin = new System.Windows.Forms.Padding(4);
            this.ucFiltroChoferes.Name = "ucFiltroChoferes";
            this.ucFiltroChoferes.Size = new System.Drawing.Size(831, 168);
            this.ucFiltroChoferes.TabIndex = 0;
            this.ucFiltroChoferes.Titular = "";
            // 
            // GridChoferes
            // 
            this.GridChoferes.Location = new System.Drawing.Point(13, 208);
            this.GridChoferes.Name = "GridChoferes";
            this.GridChoferes.Size = new System.Drawing.Size(1118, 260);
            this.GridChoferes.TabIndex = 1;
            this.GridChoferes.Text = "radGridView1";
            // 
            // FrmChoferesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 537);
            this.Controls.Add(this.GridChoferes);
            this.Controls.Add(this.ucFiltroChoferes);
            this.Name = "FrmChoferesListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de Choferes";
            this.Load += new System.EventHandler(this.FrmChoferesListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucFiltroChoferes ucFiltroChoferes;
        private Telerik.WinControls.UI.RadGridView GridChoferes;
    }
}