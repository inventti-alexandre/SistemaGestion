namespace GestionAdministrativa.Win.Forms.Pagos
{
    partial class FrmTipoPago
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtImporte = new Telerik.WinControls.UI.RadTextBox();
            this.ddlTipo = new Telerik.WinControls.UI.RadDropDownList();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(47, 36);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 28);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Tipo:";
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(125, 74);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(183, 28);
            this.txtImporte.TabIndex = 1;
            this.txtImporte.TabStop = false;
            this.txtImporte.ThemeName = "TelerikMetro";
            // 
            // ddlTipo
            // 
            this.ddlTipo.DropDownAnimationEnabled = true;
            this.ddlTipo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Efectivo";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Vales";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Taller (Descuento)";
            radListDataItem3.TextWrap = true;
            this.ddlTipo.Items.Add(radListDataItem1);
            this.ddlTipo.Items.Add(radListDataItem2);
            this.ddlTipo.Items.Add(radListDataItem3);
            this.ddlTipo.Location = new System.Drawing.Point(125, 39);
            this.ddlTipo.MaxDropDownItems = 0;
            this.ddlTipo.Name = "ddlTipo";
            this.ddlTipo.ShowImageInEditorArea = true;
            this.ddlTipo.Size = new System.Drawing.Size(183, 29);
            this.ddlTipo.TabIndex = 2;
            this.ddlTipo.ThemeName = "TelerikMetro";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Yellow;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(321, 122);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(123, 34);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // FrmTipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 168);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.ddlTipo);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.radLabel1);
            this.Name = "FrmTipoPago";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Agregar forma de pago";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtImporte;
        private Telerik.WinControls.UI.RadDropDownList ddlTipo;
        private System.Windows.Forms.Button BtnAgregar;
    }
}