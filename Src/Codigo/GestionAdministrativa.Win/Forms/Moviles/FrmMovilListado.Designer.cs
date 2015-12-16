namespace GestionAdministrativa.Win.Forms.Moviles
{
    partial class FrmMovilListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn31 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn32 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.DgvMovil = new Telerik.WinControls.UI.RadGridView();
            this.ucFiltroMoviles = new GestionAdministrativa.Win.Forms.Moviles.ucFiltroMoviles();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrearCliente = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovil.MasterTemplate)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearCliente)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMovil
            // 
            this.DgvMovil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMovil.Location = new System.Drawing.Point(3, 3);
            // 
            // DgvMovil
            // 
            this.DgvMovil.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn31.FieldName = "Numero";
            gridViewTextBoxColumn31.FormatString = "";
            gridViewTextBoxColumn31.HeaderText = "Numero";
            gridViewTextBoxColumn31.Name = "Numero";
            gridViewTextBoxColumn31.Width = 457;
            gridViewTextBoxColumn32.FieldName = "Patente";
            gridViewTextBoxColumn32.FormatString = "";
            gridViewTextBoxColumn32.HeaderText = "Patente";
            gridViewTextBoxColumn32.Name = "Patente";
            gridViewTextBoxColumn32.Width = 457;
            gridViewTextBoxColumn33.FieldName = "FechaAlta";
            gridViewTextBoxColumn33.FormatString = "";
            gridViewTextBoxColumn33.HeaderText = "Fecha Alta";
            gridViewTextBoxColumn33.Name = "FechaAlta";
            gridViewTextBoxColumn33.Width = 457;
            this.DgvMovil.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn31,
            gridViewTextBoxColumn32,
            gridViewTextBoxColumn33});
            this.DgvMovil.MasterTemplate.EnableGrouping = false;
            this.DgvMovil.Name = "DgvMovil";
            this.DgvMovil.Size = new System.Drawing.Size(1391, 536);
            this.DgvMovil.TabIndex = 0;
            this.DgvMovil.Text = "Listado de Moviles";
            this.DgvMovil.ThemeName = "TelerikMetro";
            // 
            // ucFiltroMoviles
            // 
            this.ucFiltroMoviles.Activo = true;
            this.ucFiltroMoviles.Location = new System.Drawing.Point(8, 53);
            this.ucFiltroMoviles.Margin = new System.Windows.Forms.Padding(4);
            this.ucFiltroMoviles.Name = "ucFiltroMoviles";
            this.ucFiltroMoviles.Patente = "";
            this.ucFiltroMoviles.Size = new System.Drawing.Size(937, 100);
            this.ucFiltroMoviles.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearCliente, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1381, 41);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCrearCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCliente.Location = new System.Drawing.Point(4, 4);
            this.BtnCrearCliente.Margin = new System.Windows.Forms.Padding(4, 4, 53, 4);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(100, 33);
            this.BtnCrearCliente.TabIndex = 14;
            this.BtnCrearCliente.Text = "Crear";
            this.BtnCrearCliente.ThemeName = "TelerikMetroBlue";
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgvMovil, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1397, 542);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // FrmMovilListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 714);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ucFiltroMoviles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMovilListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de móviles";
            this.Load += new System.EventHandler(this.FrmMovilListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovil.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovil)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearCliente)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvMovil;
        private ucFiltroMoviles ucFiltroMoviles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton BtnCrearCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
