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
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.ucListadoPago1 = new GestionAdministrativa.Win.Forms.PagosMoviles.UcListadoPago();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ucPagos = new GestionAdministrativa.Win.Forms.Pagos.ucPagos();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.TxtTotal);
            this.radPanel1.Controls.Add(this.ucListadoPago1);
            this.radPanel1.Location = new System.Drawing.Point(12, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(777, 471);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.Text = "radPanel1";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(586, 415);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(70, 25);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "Total:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(662, 412);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(103, 28);
            this.TxtTotal.TabIndex = 7;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetro";
            // 
            // ucListadoPago1
            // 
            this.ucListadoPago1.Location = new System.Drawing.Point(3, 3);
            this.ucListadoPago1.Name = "ucListadoPago1";
            this.ucListadoPago1.Size = new System.Drawing.Size(768, 418);
            this.ucListadoPago1.TabIndex = 0;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.BtnAceptar);
            this.radPanel2.Controls.Add(this.ucPagos);
            this.radPanel2.Controls.Add(this.BtnCancelar);
            this.radPanel2.Location = new System.Drawing.Point(796, 12);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(702, 471);
            this.radPanel2.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(500, 412);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(109, 41);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Guardar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click_1);
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
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(366, 412);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 41);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmMovilesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 537);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmMovilesPago";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmMovilesPago";
            this.Load += new System.EventHandler(this.FrmMovilesPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private UcListadoPago ucListadoPago1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Pagos.ucPagos ucPagos;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
    }
}