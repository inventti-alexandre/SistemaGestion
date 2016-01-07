namespace GestionAdministrativa.Win.Forms.Pagos
{
    partial class ucBuscardorChoferMovil
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
            this.TxtMovil = new Telerik.WinControls.UI.RadTextBox();
            this.TxtChofer = new Telerik.WinControls.UI.RadTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(14, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Movil:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(14, 73);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 25);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Chofer:";
            // 
            // TxtMovil
            // 
            this.TxtMovil.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMovil.Location = new System.Drawing.Point(90, 29);
            this.TxtMovil.Name = "TxtMovil";
            this.TxtMovil.Size = new System.Drawing.Size(202, 28);
            this.TxtMovil.TabIndex = 2;
            this.TxtMovil.TabStop = false;
            this.TxtMovil.ThemeName = "TelerikMetro";
            // 
            // TxtChofer
            // 
            this.TxtChofer.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChofer.Location = new System.Drawing.Point(90, 70);
            this.TxtChofer.Name = "TxtChofer";
            this.TxtChofer.Size = new System.Drawing.Size(202, 28);
            this.TxtChofer.TabIndex = 3;
            this.TxtChofer.TabStop = false;
            this.TxtChofer.ThemeName = "TelerikMetro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(220, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(138, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // ucBuscardorChoferMovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TxtChofer);
            this.Controls.Add(this.TxtMovil);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "ucBuscardorChoferMovil";
            this.Size = new System.Drawing.Size(378, 173);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtChofer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtMovil;
        private Telerik.WinControls.UI.RadTextBox TxtChofer;
        private System.Windows.Forms.Button btnBuscar;
    }
}
