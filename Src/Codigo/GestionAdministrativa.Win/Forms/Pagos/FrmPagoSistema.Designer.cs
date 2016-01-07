namespace GestionAdministrativa.Win.Forms.Pagos
{
    partial class FrmPagoSistema
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
            this.ucBuscardorChoferMovil1 = new GestionAdministrativa.Win.Forms.Pagos.ucBuscardorChoferMovil();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBuscardorChoferMovil1
            // 
            this.ucBuscardorChoferMovil1.Location = new System.Drawing.Point(3, 3);
            this.ucBuscardorChoferMovil1.Name = "ucBuscardorChoferMovil1";
            this.ucBuscardorChoferMovil1.Size = new System.Drawing.Size(362, 173);
            this.ucBuscardorChoferMovil1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.3167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.6833F));
            this.tableLayoutPanel1.Controls.Add(this.ucBuscardorChoferMovil1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.67797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.32204F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 590);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FrmPagoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmPagoSistema";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Registrar pago de sistema";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBuscardorChoferMovil ucBuscardorChoferMovil1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}