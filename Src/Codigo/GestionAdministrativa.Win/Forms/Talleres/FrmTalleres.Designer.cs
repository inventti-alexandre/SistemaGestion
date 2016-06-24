namespace GestionAdministrativa.Win.Forms.Talleres
{
    partial class FrmTalleres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PnlNuevoTipo = new System.Windows.Forms.Panel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.DtpFin = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.DtpDesde = new Telerik.WinControls.UI.RadDateTimePicker();
            this.DdlTipo = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.DdlMovil = new Telerik.WinControls.UI.RadDropDownList();
            this.EpvTalleres = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChkListBox = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.PnlNuevoTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvTalleres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAceptar);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Location = new System.Drawing.Point(274, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 46);
            this.panel1.TabIndex = 26;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(3, 3);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(103, 41);
            this.BtnAceptar.TabIndex = 21;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(110, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 41);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cerrar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // PnlNuevoTipo
            // 
            this.PnlNuevoTipo.Controls.Add(this.radLabel5);
            this.PnlNuevoTipo.Controls.Add(this.radLabel1);
            this.PnlNuevoTipo.Controls.Add(this.DtpFin);
            this.PnlNuevoTipo.Controls.Add(this.radLabel4);
            this.PnlNuevoTipo.Controls.Add(this.DtpDesde);
            this.PnlNuevoTipo.Controls.Add(this.DdlTipo);
            this.PnlNuevoTipo.Controls.Add(this.radLabel2);
            this.PnlNuevoTipo.Controls.Add(this.DdlMovil);
            this.PnlNuevoTipo.Location = new System.Drawing.Point(12, 26);
            this.PnlNuevoTipo.Name = "PnlNuevoTipo";
            this.PnlNuevoTipo.Size = new System.Drawing.Size(493, 157);
            this.PnlNuevoTipo.TabIndex = 24;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(3, 46);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(59, 25);
            this.radLabel5.TabIndex = 20;
            this.radLabel5.Text = "Tipo:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(3, 114);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 25);
            this.radLabel1.TabIndex = 29;
            this.radLabel1.Text = "Fin:";
            // 
            // DtpFin
            // 
            this.DtpFin.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(190, 114);
            this.DtpFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.NullableValue = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            this.DtpFin.NullDate = new System.DateTime(((long)(0)));
            this.DtpFin.Size = new System.Drawing.Size(292, 31);
            this.DtpFin.TabIndex = 28;
            this.DtpFin.TabStop = false;
            this.DtpFin.Text = "01/12/2015";
            this.DtpFin.ThemeName = "TelerikMetro";
            this.DtpFin.Value = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(3, 77);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(70, 25);
            this.radLabel4.TabIndex = 25;
            this.radLabel4.Text = "Desde:";
            // 
            // DtpDesde
            // 
            this.DtpDesde.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDesde.Location = new System.Drawing.Point(190, 77);
            this.DtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.NullableValue = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            this.DtpDesde.NullDate = new System.DateTime(((long)(0)));
            this.DtpDesde.Size = new System.Drawing.Size(292, 31);
            this.DtpDesde.TabIndex = 24;
            this.DtpDesde.TabStop = false;
            this.DtpDesde.Text = "01/12/2015";
            this.DtpDesde.ThemeName = "TelerikMetro";
            this.DtpDesde.Value = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            // 
            // DdlTipo
            // 
            this.DdlTipo.DropDownAnimationEnabled = true;
            this.DdlTipo.Location = new System.Drawing.Point(190, 40);
            this.DdlTipo.MaxDropDownItems = 0;
            this.DdlTipo.Name = "DdlTipo";
            this.DdlTipo.ShowImageInEditorArea = true;
            this.DdlTipo.Size = new System.Drawing.Size(292, 31);
            this.DdlTipo.TabIndex = 23;
            this.DdlTipo.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(3, 9);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(70, 25);
            this.radLabel2.TabIndex = 22;
            this.radLabel2.Text = "Movil:";
            // 
            // DdlMovil
            // 
            this.DdlMovil.DropDownAnimationEnabled = true;
            this.DdlMovil.Location = new System.Drawing.Point(190, 3);
            this.DdlMovil.MaxDropDownItems = 0;
            this.DdlMovil.Name = "DdlMovil";
            this.DdlMovil.ShowImageInEditorArea = true;
            this.DdlMovil.Size = new System.Drawing.Size(292, 31);
            this.DdlMovil.TabIndex = 21;
            this.DdlMovil.ThemeName = "TelerikMetro";
            // 
            // EpvTalleres
            // 
            this.EpvTalleres.ContainerControl = this;
            // 
            // ChkListBox
            // 
            this.ChkListBox.FormattingEnabled = true;
            this.ChkListBox.Location = new System.Drawing.Point(532, 23);
            this.ChkListBox.Name = "ChkListBox";
            this.ChkListBox.Size = new System.Drawing.Size(253, 160);
            this.ChkListBox.TabIndex = 27;
            // 
            // FrmTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 432);
            this.Controls.Add(this.ChkListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlNuevoTipo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTalleres";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmTalleres";
            this.Load += new System.EventHandler(this.FrmTalleres_Load);
            this.panel1.ResumeLayout(false);
            this.PnlNuevoTipo.ResumeLayout(false);
            this.PnlNuevoTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvTalleres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlNuevoTipo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadDropDownList DdlTipo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList DdlMovil;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFin;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker DtpDesde;
        private System.Windows.Forms.ErrorProvider EpvTalleres;
        private System.Windows.Forms.CheckedListBox ChkListBox;

    }
}
