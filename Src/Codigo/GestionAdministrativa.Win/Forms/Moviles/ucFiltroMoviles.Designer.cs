namespace GestionAdministrativa.Win.Forms.Moviles
{
    partial class ucFiltroMoviles
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
            this.TxtNumero = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPatente = new Telerik.WinControls.UI.RadTextBox();
            this.ChkActivo = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnLimpiar = new Telerik.WinControls.UI.RadButton();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(160, 4);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(125, 27);
            this.TxtNumero.TabIndex = 0;
            this.TxtNumero.TabStop = false;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(46, 7);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 25);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Numero";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(46, 40);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 25);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Patente";
            // 
            // TxtPatente
            // 
            this.TxtPatente.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatente.Location = new System.Drawing.Point(160, 37);
            this.TxtPatente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(125, 27);
            this.TxtPatente.TabIndex = 2;
            this.TxtPatente.TabStop = false;
            this.TxtPatente.TextChanged += new System.EventHandler(this.TxtPatente_TextChanged);
            // 
            // ChkActivo
            // 
            this.ChkActivo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivo.Location = new System.Drawing.Point(160, 79);
            this.ChkActivo.Margin = new System.Windows.Forms.Padding(4);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(15, 15);
            this.ChkActivo.TabIndex = 4;
            this.ChkActivo.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.ChkActivo.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ChkActivo_ToggleStateChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(46, 69);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(70, 25);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Activo";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(357, 53);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(205, 41);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar Filtros";
            this.BtnLimpiar.ThemeName = "TelerikMetro";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(594, 53);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(205, 41);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetro";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ucFiltroMoviles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TxtNumero);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ucFiltroMoviles";
            this.Size = new System.Drawing.Size(819, 112);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtNumero;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtPatente;
        private Telerik.WinControls.UI.RadCheckBox ChkActivo;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton BtnLimpiar;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
    }
}
