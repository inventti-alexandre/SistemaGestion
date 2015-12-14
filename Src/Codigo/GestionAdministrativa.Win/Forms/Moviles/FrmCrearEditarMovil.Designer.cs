namespace GestionAdministrativa.Win.Forms.Moviles
{
    partial class FrmCrearEditarMovil
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
            this.TxtPatente = new Telerik.WinControls.UI.RadTextBox();
            this.DtpFechaAlta = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.EpvMovil = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Aaargh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(150, 49);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(292, 31);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.TabStop = false;
            this.TxtNumero.ThemeName = "TelerikMetro";
            // 
            // TxtPatente
            // 
            this.TxtPatente.Font = new System.Drawing.Font("Aaargh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatente.Location = new System.Drawing.Point(150, 83);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(292, 31);
            this.TxtPatente.TabIndex = 3;
            this.TxtPatente.TabStop = false;
            this.TxtPatente.ThemeName = "TelerikMetro";
            // 
            // DtpFechaAlta
            // 
            this.DtpFechaAlta.Font = new System.Drawing.Font("Aaargh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaAlta.Location = new System.Drawing.Point(150, 17);
            this.DtpFechaAlta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaAlta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpFechaAlta.Name = "DtpFechaAlta";
            this.DtpFechaAlta.NullableValue = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            this.DtpFechaAlta.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaAlta.Size = new System.Drawing.Size(292, 30);
            this.DtpFechaAlta.TabIndex = 4;
            this.DtpFechaAlta.TabStop = false;
            this.DtpFechaAlta.Text = "01/12/2015";
            this.DtpFechaAlta.ThemeName = "ControlDefault";
            this.DtpFechaAlta.Value = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Aaargh", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(24, 17);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(115, 28);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Fecha Alta:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Aaargh", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(24, 49);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(89, 28);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Numero:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Aaargh", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(25, 83);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(87, 28);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Patente:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(328, 136);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 41);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(213, 136);
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
            // FrmCrearEditarMovil
            // 
            this.AcceptButton = this.BtnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(575, 241);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.DtpFechaAlta);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.TxtNumero);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCrearEditarMovil";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Crear Movil";
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtNumero;
        private Telerik.WinControls.UI.RadTextBox TxtPatente;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaAlta;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ErrorProvider EpvMovil;
    }
}
