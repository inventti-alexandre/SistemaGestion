﻿namespace GestionAdministrativa.Win.Forms.PagosMoviles
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
            this.TxtNumero = new Telerik.WinControls.UI.RadTextBox();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.DtpFechaAlta = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.EpvMovil = new System.Windows.Forms.ErrorProvider(this.components);
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ChkActivo = new Telerik.WinControls.UI.RadCheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNumero
            // 
            this.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumero.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(150, 54);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(292, 28);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.TabStop = false;
            this.TxtNumero.ThemeName = "TelerikMetro";
            // 
            // TxtTotal
            // 
            this.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTotal.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(1002, 237);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(292, 28);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetro";
            // 
            // DtpFechaAlta
            // 
            this.DtpFechaAlta.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaAlta.Location = new System.Drawing.Point(150, 17);
            this.DtpFechaAlta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaAlta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpFechaAlta.Name = "DtpFechaAlta";
            this.DtpFechaAlta.NullableValue = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            this.DtpFechaAlta.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaAlta.Size = new System.Drawing.Size(292, 31);
            this.DtpFechaAlta.TabIndex = 4;
            this.DtpFechaAlta.TabStop = false;
            this.DtpFechaAlta.Text = "01/12/2015";
            this.DtpFechaAlta.ThemeName = "TelerikMetro";
            this.DtpFechaAlta.Value = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(24, 17);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(121, 25);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Fecha Alta:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(24, 54);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 25);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Numero:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(877, 237);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(70, 25);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Total:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(1457, 601);
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
            this.BtnAceptar.Location = new System.Drawing.Point(1342, 601);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(109, 41);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // EpvMovil
            // 
            this.EpvMovil.ContainerControl = this;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(26, 122);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(80, 25);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Activo:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChkActivo.Location = new System.Drawing.Point(150, 125);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(15, 15);
            this.ChkActivo.TabIndex = 9;
            this.ChkActivo.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(742, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmPagoMoviles
            // 
            this.AcceptButton = this.BtnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(1680, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.DtpFechaAlta);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtNumero);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPagoMoviles";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Nuevo Pago";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCrearEditarMovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtNumero;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaAlta;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ErrorProvider EpvMovil;
        private Telerik.WinControls.UI.RadCheckBox ChkActivo;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.Button button1;
    }
}
