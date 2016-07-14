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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GridClientes = new Telerik.WinControls.UI.RadGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GridClientes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCrear, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.5144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.4856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 510);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GridClientes
            // 
            this.GridClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridClientes.Location = new System.Drawing.Point(3, 170);
            // 
            // GridClientes
            // 
            this.GridClientes.MasterTemplate.AllowAddNewRow = false;
            this.GridClientes.MasterTemplate.AllowColumnReorder = false;
            this.GridClientes.MasterTemplate.AllowDragToGroup = false;
            this.GridClientes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "NroCliente";
            gridViewTextBoxColumn1.HeaderText = "Numero";
            gridViewTextBoxColumn1.Name = "Numero";
            gridViewTextBoxColumn1.Width = 160;
            gridViewTextBoxColumn2.FieldName = "Apellido";
            gridViewTextBoxColumn2.HeaderText = "Apellido";
            gridViewTextBoxColumn2.Name = "Apellido";
            gridViewTextBoxColumn2.Width = 160;
            gridViewTextBoxColumn3.FieldName = "Nombre";
            gridViewTextBoxColumn3.HeaderText = "Nombre";
            gridViewTextBoxColumn3.Name = "Nombre";
            gridViewTextBoxColumn3.Width = 160;
            gridViewTextBoxColumn4.FieldName = "Telefono";
            gridViewTextBoxColumn4.HeaderText = "Telefono";
            gridViewTextBoxColumn4.Name = "Telefono";
            gridViewTextBoxColumn4.Width = 160;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "Email";
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 160;
            gridViewTextBoxColumn6.FieldName = "Domicilio";
            gridViewTextBoxColumn6.HeaderText = "Domicilio";
            gridViewTextBoxColumn6.Name = "Domicilio";
            gridViewTextBoxColumn6.Width = 159;
            this.GridClientes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.ReadOnly = true;
            this.GridClientes.Size = new System.Drawing.Size(976, 337);
            this.GridClientes.TabIndex = 1;
            this.GridClientes.Text = "radGridView1";
            this.GridClientes.ThemeName = "TelerikMetro";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Yellow;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(3, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(151, 36);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FrmClientesListado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(982, 510);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmClientesListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de clientes";
            this.Load += new System.EventHandler(this.FrmClientesListado_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBuscadorCliente ucBuscadorCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadGridView GridClientes;
        private System.Windows.Forms.Button btnCrear;
    }
}