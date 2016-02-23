namespace GestionAdministrativa.Win.Forms.Choferes
{
    partial class FrmCrearEditarChofer
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
            this.TxtCelular = new Telerik.WinControls.UI.RadTextBox();
            this.BtnAgregarCelular = new Telerik.WinControls.UI.RadButton();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.BtnSave = new Telerik.WinControls.UI.RadButton();
            this.DdlMoviles = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.CkActivo = new Telerik.WinControls.UI.RadCheckBox();
            this.TxtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.TxtTelefono = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.TxtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.TxtApellido = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtDni = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.EpvChofer = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnAgregarMovil = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlMoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvChofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCelular
            // 
            this.TxtCelular.Enabled = false;
            this.TxtCelular.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.Location = new System.Drawing.Point(188, 287);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(291, 28);
            this.TxtCelular.TabIndex = 6;
            this.TxtCelular.TabStop = false;
            this.TxtCelular.ThemeName = "TelerikMetro";
            // 
            // BtnAgregarCelular
            // 
            this.BtnAgregarCelular.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAgregarCelular.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCelular.Image = global::GestionAdministrativa.Win.Properties.Resources.Add_New_blue;
            this.BtnAgregarCelular.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAgregarCelular.Location = new System.Drawing.Point(496, 290);
            this.BtnAgregarCelular.Name = "BtnAgregarCelular";
            this.BtnAgregarCelular.Size = new System.Drawing.Size(29, 29);
            this.BtnAgregarCelular.TabIndex = 11;
            this.BtnAgregarCelular.ThemeName = "TelerikMetro";
            this.BtnAgregarCelular.Click += new System.EventHandler(this.BtnAgregarCelular_Click);
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(92, 290);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(90, 25);
            this.radLabel7.TabIndex = 11;
            this.radLabel7.Text = "Celular:";
            // 
            // BtnSave
            // 
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(355, 360);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 36);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.ThemeName = "TelerikMetro";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DdlMoviles
            // 
            this.DdlMoviles.DropDownAnimationEnabled = true;
            this.DdlMoviles.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DdlMoviles.Location = new System.Drawing.Point(188, 248);
            this.DdlMoviles.MaxDropDownItems = 0;
            this.DdlMoviles.Name = "DdlMoviles";
            this.DdlMoviles.ShowImageInEditorArea = true;
            this.DdlMoviles.Size = new System.Drawing.Size(291, 29);
            this.DdlMoviles.TabIndex = 9;
            this.DdlMoviles.ThemeName = "TelerikMetro";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(92, 248);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(70, 25);
            this.radLabel6.TabIndex = 8;
            this.radLabel6.Text = "Movil:";
            // 
            // CkActivo
            // 
            this.CkActivo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkActivo.Location = new System.Drawing.Point(401, 329);
            this.CkActivo.Name = "CkActivo";
            this.CkActivo.Size = new System.Drawing.Size(84, 25);
            this.CkActivo.TabIndex = 6;
            this.CkActivo.Text = "Activo";
            this.CkActivo.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(188, 204);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(291, 28);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.ThemeName = "TelerikMetro";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(188, 164);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(291, 28);
            this.TxtTelefono.TabIndex = 4;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.ThemeName = "TelerikMetro";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(92, 204);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(70, 25);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Email:";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(92, 164);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(100, 25);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Telefono:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(188, 125);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(291, 28);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.ThemeName = "TelerikMetro";
            // 
            // TxtApellido
            // 
            this.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellido.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(188, 79);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(291, 28);
            this.TxtApellido.TabIndex = 2;
            this.TxtApellido.TabStop = false;
            this.TxtApellido.ThemeName = "TelerikMetro";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(92, 125);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(80, 25);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Nombre:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(92, 79);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(100, 25);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Apellido:";
            // 
            // TxtDni
            // 
            this.TxtDni.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDni.Location = new System.Drawing.Point(188, 35);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(291, 28);
            this.TxtDni.TabIndex = 1;
            this.TxtDni.TabStop = false;
            this.TxtDni.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(92, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "DNI:";
            // 
            // EpvChofer
            // 
            this.EpvChofer.ContainerControl = this;
            // 
            // BtnAgregarMovil
            // 
            this.BtnAgregarMovil.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAgregarMovil.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarMovil.Image = global::GestionAdministrativa.Win.Properties.Resources.Add_New_blue;
            this.BtnAgregarMovil.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAgregarMovil.Location = new System.Drawing.Point(496, 248);
            this.BtnAgregarMovil.Name = "BtnAgregarMovil";
            this.BtnAgregarMovil.Size = new System.Drawing.Size(29, 29);
            this.BtnAgregarMovil.TabIndex = 12;
            this.BtnAgregarMovil.ThemeName = "TelerikMetro";
            this.BtnAgregarMovil.Click += new System.EventHandler(this.BtnAgregarMovil_Click);
            // 
            // FrmCrearEditarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 538);
            this.Controls.Add(this.BtnAgregarMovil);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.BtnAgregarCelular);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DdlMoviles);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.CkActivo);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.radLabel1);
            this.Name = "FrmCrearEditarChofer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Chofer";
            this.Load += new System.EventHandler(this.FrmCrearEditarChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlMoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvChofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtDni;
        private Telerik.WinControls.UI.RadTextBox TxtApellido;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtNombre;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtTelefono;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox TxtEmail;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadCheckBox CkActivo;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private System.Windows.Forms.ErrorProvider EpvChofer;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDropDownList DdlMoviles;
        private Telerik.WinControls.UI.RadButton BtnSave;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadButton BtnAgregarCelular;
        private Telerik.WinControls.UI.RadTextBox TxtCelular;
        private Telerik.WinControls.UI.RadButton BtnAgregarMovil;
    }
}