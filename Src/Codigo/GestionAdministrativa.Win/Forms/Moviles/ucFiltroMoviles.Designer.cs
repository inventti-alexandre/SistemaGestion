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
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(111, 3);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 24);
            this.TxtNumero.TabIndex = 0;
            this.TxtNumero.TabStop = false;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(37, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(59, 22);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Numero";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(37, 43);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(55, 22);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Patente";
            // 
            // TxtPatente
            // 
            this.TxtPatente.Location = new System.Drawing.Point(111, 41);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(100, 24);
            this.TxtPatente.TabIndex = 2;
            this.TxtPatente.TabStop = false;
            this.TxtPatente.TextChanged += new System.EventHandler(this.TxtPatente_TextChanged);
            // 
            // ChkActivo
            // 
            this.ChkActivo.Location = new System.Drawing.Point(111, 71);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(15, 15);
            this.ChkActivo.TabIndex = 4;
            this.ChkActivo.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.ChkActivo.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ChkActivo_ToggleStateChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(37, 71);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(46, 22);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Activo";
            // 
            // ucFiltroMoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TxtNumero);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucFiltroMoviles";
            this.Size = new System.Drawing.Size(385, 107);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
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
    }
}
