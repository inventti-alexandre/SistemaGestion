namespace GestionAdministrativa.Win.Forms.Clientes
{
    partial class FrmClientesListado
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
            this.ucBuscadorCliente = new GestionAdministrativa.Win.Forms.Clientes.ucBuscadorCliente();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBuscadorCliente
            // 
            this.ucBuscadorCliente.Apellido = "";
            this.ucBuscadorCliente.ClienteId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucBuscadorCliente.DNI = 0;
            this.ucBuscadorCliente.Location = new System.Drawing.Point(12, 12);
            this.ucBuscadorCliente.Name = "ucBuscadorCliente";
            this.ucBuscadorCliente.Size = new System.Drawing.Size(845, 127);
            this.ucBuscadorCliente.TabIndex = 0;
            // 
            // FrmClientesListado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(982, 510);
            this.Controls.Add(this.ucBuscadorCliente);
            this.Name = "FrmClientesListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de clientes";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBuscadorCliente ucBuscadorCliente;
    }
}