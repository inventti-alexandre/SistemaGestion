namespace GestionAdministrativa.Win.Forms.PagosMoviles
{
    partial class FrmMovilesPago
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ucListadoPago = new GestionAdministrativa.Win.Forms.PagosMoviles.UcListadoPago();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.ucPagos = new GestionAdministrativa.Win.Forms.Pagos.ucPagos();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ucListadoPago);
            this.radPanel1.Location = new System.Drawing.Point(12, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(777, 432);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.Text = "radPanel1";
            // 
            // ucListadoPago
            // 
            this.ucListadoPago.Location = new System.Drawing.Point(3, 3);
            this.ucListadoPago.Name = "ucListadoPago";
            this.ucListadoPago.Size = new System.Drawing.Size(768, 418);
            this.ucListadoPago.TabIndex = 0;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.ucPagos);
            this.radPanel2.Location = new System.Drawing.Point(796, 12);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(702, 432);
            this.radPanel2.TabIndex = 1;
            // 
            // ucPagos
            // 
            this.ucPagos.Importe = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucPagos.Location = new System.Drawing.Point(43, 64);
            this.ucPagos.Name = "ucPagos";
            this.ucPagos.Size = new System.Drawing.Size(604, 339);
            this.ucPagos.TabIndex = 0;
            this.ucPagos.Tipo = "Vales";
            this.ucPagos.Total = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // FrmMovilesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 614);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmMovilesPago";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmMovilesPago";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private UcListadoPago ucListadoPago;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Pagos.ucPagos ucPagos;
    }
}