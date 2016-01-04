namespace GestionAdministrativa.Win.Forms.Moviles
{
    partial class FrmDetalleEliminarMovil
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.EpvMovil = new System.Windows.Forms.ErrorProvider(this.components);
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ChkActivo = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatente)).BeginInit();
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
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(150, 49);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(292, 28);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.TabStop = false;
            this.TxtNumero.ThemeName = "TelerikMetro";
            // 
            // TxtPatente
            // 
            this.TxtPatente.Enabled = false;
            this.TxtPatente.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatente.Location = new System.Drawing.Point(150, 83);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(292, 28);
            this.TxtPatente.TabIndex = 3;
            this.TxtPatente.TabStop = false;
            this.TxtPatente.ThemeName = "TelerikMetro";
            // 
            // DtpFechaAlta
            // 
            this.DtpFechaAlta.Enabled = false;
            this.DtpFechaAlta.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaAlta.Location = new System.Drawing.Point(150, 17);
            this.DtpFechaAlta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaAlta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpFechaAlta.Name = "DtpFechaAlta";
            this.DtpFechaAlta.NullableValue = new System.DateTime(2015, 12, 1, 19, 30, 46, 0);
            this.DtpFechaAlta.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaAlta.Size = new System.Drawing.Size(292, 27);
            this.DtpFechaAlta.TabIndex = 4;
            this.DtpFechaAlta.TabStop = false;
            this.DtpFechaAlta.Text = "01/12/2015";
            this.DtpFechaAlta.ThemeName = "ControlDefault";
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
            this.radLabel2.Location = new System.Drawing.Point(24, 49);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 25);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Numero:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(25, 83);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(90, 25);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Patente:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(476, 186);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 41);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cerrar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEliminar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(361, 186);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(109, 41);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // EpvMovil
            // 
            this.EpvMovil.ContainerControl = this;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(26, 117);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(80, 25);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Activo:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.Enabled = false;
            this.ChkActivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChkActivo.Location = new System.Drawing.Point(150, 120);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(15, 15);
            this.ChkActivo.TabIndex = 9;
            this.ChkActivo.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // FrmDetalleEliminarMovil
            // 
            this.AcceptButton = this.BtnEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(602, 239);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.DtpFechaAlta);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.TxtNumero);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetalleEliminarMovil";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Crear Movil";
            this.Load += new System.EventHandler(this.FrmCrearEditarMovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatente)).EndInit();
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
        private Telerik.WinControls.UI.RadTextBox TxtPatente;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaAlta;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ErrorProvider EpvMovil;
        private Telerik.WinControls.UI.RadCheckBox ChkActivo;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}
