namespace GestionAdministrativa.Win.Forms.Titulares
{
    partial class FrmCrearEditarTitular
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
            this.TxtDni = new Telerik.WinControls.UI.RadTextBox();
            this.TxtMail = new Telerik.WinControls.UI.RadTextBox();
            this.TxtApellido = new Telerik.WinControls.UI.RadTextBox();
            this.TxtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.TxtTelefono = new Telerik.WinControls.UI.RadTextBox();
            this.TxtDomicilio = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(127, 59);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(100, 24);
            this.TxtDni.TabIndex = 0;
            this.TxtDni.TabStop = false;
            this.TxtDni.Text = "radTextBox1";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(261, 233);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(100, 24);
            this.TxtMail.TabIndex = 1;
            this.TxtMail.TabStop = false;
            this.TxtMail.Text = "radTextBox2";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(186, 121);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 24);
            this.TxtApellido.TabIndex = 1;
            this.TxtApellido.TabStop = false;
            this.TxtApellido.Text = "radTextBox3";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(149, 192);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 24);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.Text = "radTextBox4";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(149, 265);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 24);
            this.TxtTelefono.TabIndex = 1;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.Text = "radTextBox5";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(276, 297);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(100, 24);
            this.TxtDomicilio.TabIndex = 3;
            this.TxtDomicilio.TabStop = false;
            this.TxtDomicilio.Text = "radTextBox6";
            // 
            // FrmCrearEditarTitular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 491);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtDni);
            this.Name = "FrmCrearEditarTitular";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "CrearEditarTitular";
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtDni;
        private Telerik.WinControls.UI.RadTextBox TxtMail;
        private Telerik.WinControls.UI.RadTextBox TxtApellido;
        private Telerik.WinControls.UI.RadTextBox TxtNombre;
        private Telerik.WinControls.UI.RadTextBox TxtTelefono;
        private Telerik.WinControls.UI.RadTextBox TxtDomicilio;
    }
}