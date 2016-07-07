namespace GestionAdministrativa.Win.Forms.Clientes
{
    partial class ucBuscadorCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtApellido = new Telerik.WinControls.UI.RadTextBox();
            this.TxtDni = new Telerik.WinControls.UI.RadTextBox();
            this.ddlCliente = new Telerik.WinControls.UI.RadDropDownList();
            this.BtnLimpiar = new Telerik.WinControls.UI.RadButton();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(64, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(105, 28);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nro Cliente:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(125, 48);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(44, 28);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "DNI:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(89, 82);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(80, 28);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(175, 82);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(212, 29);
            this.TxtApellido.TabIndex = 3;
            this.TxtApellido.TabStop = false;
            this.TxtApellido.ThemeName = "TelerikMetro";
            this.TxtApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtApellido_KeyUp);
            // 
            // TxtDni
            // 
            this.TxtDni.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDni.Location = new System.Drawing.Point(175, 47);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(212, 29);
            this.TxtDni.TabIndex = 4;
            this.TxtDni.TabStop = false;
            this.TxtDni.ThemeName = "TelerikMetro";
            this.TxtDni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDni_KeyUp);
            // 
            // ddlCliente
            // 
            this.ddlCliente.DropDownAnimationEnabled = true;
            this.ddlCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCliente.Location = new System.Drawing.Point(175, 14);
            this.ddlCliente.MaxDropDownItems = 0;
            this.ddlCliente.Name = "ddlCliente";
            this.ddlCliente.ShowImageInEditorArea = true;
            this.ddlCliente.Size = new System.Drawing.Size(212, 27);
            this.ddlCliente.TabIndex = 5;
            this.ddlCliente.ThemeName = "TelerikMetro";
            this.ddlCliente.SelectedValueChanged += new System.EventHandler(this.ddlCliente_SelectedValueChanged);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(403, 71);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(206, 39);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar Filtros";
            this.BtnLimpiar.ThemeName = "TelerikMetro";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(628, 71);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(156, 39);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetro";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ucBuscadorCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.ddlCliente);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "ucBuscadorCliente";
            this.Size = new System.Drawing.Size(845, 127);
            this.Load += new System.EventHandler(this.ucBuscadorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtApellido;
        private Telerik.WinControls.UI.RadTextBox TxtDni;
        private Telerik.WinControls.UI.RadDropDownList ddlCliente;
        private Telerik.WinControls.UI.RadButton BtnLimpiar;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
    }
}
