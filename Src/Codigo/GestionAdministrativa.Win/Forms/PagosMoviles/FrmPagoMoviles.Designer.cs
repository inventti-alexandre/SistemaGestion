namespace GestionAdministrativa.Win.Forms.PagosMoviles
{
    partial class FrmPagoMoviles
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
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.EpvMovil = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucListadoPago1 = new GestionAdministrativa.Win.Forms.PagosMoviles.UcListadoPago();
            this.ucPagos = new GestionAdministrativa.Win.Forms.Pagos.ucPagos();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(287, 491);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(103, 28);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetro";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(211, 494);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(70, 25);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Total:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(312, 27);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 41);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(446, 27);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(109, 41);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Guardar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // EpvMovil
            // 
            this.EpvMovil.ContainerControl = this;
            // 
            // ucListadoPago1
            // 
            this.ucListadoPago1.Location = new System.Drawing.Point(12, 12);
            this.ucListadoPago1.Name = "ucListadoPago1";
            this.ucListadoPago1.Size = new System.Drawing.Size(765, 414);
            this.ucListadoPago1.TabIndex = 11;
            // 
            // ucPagos
            // 
            this.ucPagos.Importe = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucPagos.Location = new System.Drawing.Point(3, 29);
            this.ucPagos.Name = "ucPagos";
            this.ucPagos.Size = new System.Drawing.Size(594, 339);
            this.ucPagos.TabIndex = 13;
            this.ucPagos.Tipo = "Vales";
            this.ucPagos.Total = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.BtnAceptar);
            this.radPanel3.Controls.Add(this.BtnCancelar);
            this.radPanel3.Location = new System.Drawing.Point(797, 471);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(630, 81);
            this.radPanel3.TabIndex = 17;
            this.radPanel3.Text = "radPanel3";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radLabel3);
            this.panel1.Controls.Add(this.TxtTotal);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 549);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ucPagos);
            this.panel2.Location = new System.Drawing.Point(798, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 452);
            this.panel2.TabIndex = 19;
            // 
            // FrmPagoMoviles
            // 
            this.AcceptButton = this.BtnAceptar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(1439, 627);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.ucListadoPago1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPagoMoviles";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Nuevo Pago";
            this.Load += new System.EventHandler(this.FrmCrearEditarMovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtTotal;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ErrorProvider EpvMovil;
        private UcListadoPago ucListadoPago1;
        private Pagos.ucPagos ucPagos;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        
    }
}
