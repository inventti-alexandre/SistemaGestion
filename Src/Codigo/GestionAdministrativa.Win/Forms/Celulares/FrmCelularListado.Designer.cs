namespace GestionAdministrativa.Win.Forms.Celulares
{
    partial class FrmCelularListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.DgvMovil = new Telerik.WinControls.UI.RadGridView();
           // this.ucFiltroMoviles = new GestionAdministrativa.Win.Forms.Moviles.ucFiltroMoviles();
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
            this.DgvMovil.AutoSizeRows = true;
            this.DgvMovil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMovil.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMovil.Location = new System.Drawing.Point(3, 3);
            // 
            // DgvMovil
            // 
            this.DgvMovil.MasterTemplate.AllowAddNewRow = false;
            this.DgvMovil.MasterTemplate.AllowEditRow = false;
            this.DgvMovil.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.AllowHide = false;
            gridViewTextBoxColumn1.AllowReorder = false;
            gridViewTextBoxColumn1.AllowResize = false;
            gridViewTextBoxColumn1.AllowSort = false;
            gridViewTextBoxColumn1.FieldName = "Numero";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Numero";
            gridViewTextBoxColumn1.Name = "Numero";
            gridViewTextBoxColumn1.Width = 75;
            gridViewTextBoxColumn2.FieldName = "Patente";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Patente";
            gridViewTextBoxColumn2.Name = "Patente";
            gridViewTextBoxColumn2.Width = 743;
            gridViewDateTimeColumn1.FieldName = "FechaAlta";
            gridViewDateTimeColumn1.FormatString = "";
            gridViewDateTimeColumn1.HeaderText = "Fecha Alta";
            gridViewDateTimeColumn1.Name = "FechaAlta";
            gridViewDateTimeColumn1.Width = 451;
            gridViewCommandColumn1.AllowHide = false;
            gridViewCommandColumn1.AllowReorder = false;
            gridViewCommandColumn1.AllowResize = false;
            gridViewCommandColumn1.AllowSort = false;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.View_Details;
            gridViewCommandColumn1.MinWidth = 35;
            gridViewCommandColumn1.Name = "ColumnaDetalle";
            gridViewCommandColumn1.Width = 35;
            gridViewCommandColumn2.AllowHide = false;
            gridViewCommandColumn2.AllowReorder = false;
            gridViewCommandColumn2.AllowResize = false;
            gridViewCommandColumn2.AllowSort = false;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn2.MinWidth = 35;
            gridViewCommandColumn2.Name = "ColumnaEditar";
            gridViewCommandColumn2.Width = 35;
            gridViewCommandColumn3.AllowHide = false;
            gridViewCommandColumn3.AllowReorder = false;
            gridViewCommandColumn3.AllowResize = false;
            gridViewCommandColumn3.AllowSort = false;
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.Image = global::GestionAdministrativa.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.MinWidth = 35;
            gridViewCommandColumn3.Name = "ColumnaEliminar";
            gridViewCommandColumn3.RowSpan = 35;
            gridViewCommandColumn3.Width = 35;
            this.DgvMovil.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.DgvMovil.MasterTemplate.EnableGrouping = false;
            this.DgvMovil.Name = "DgvMovil";
            this.DgvMovil.Size = new System.Drawing.Size(1391, 493);
            this.DgvMovil.TabIndex = 0;
            this.DgvMovil.Text = "Listado de Moviles";
            this.DgvMovil.ThemeName = "TelerikMetro";
            this.DgvMovil.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DgvMovil_CommandCellClick);
            // 
            // ucFiltroMoviles
            // 
            //this.ucFiltroMoviles.Activo = true;
            //this.ucFiltroMoviles.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.ucFiltroMoviles.Location = new System.Drawing.Point(8, 53);
            //this.ucFiltroMoviles.Margin = new System.Windows.Forms.Padding(4);
            //this.ucFiltroMoviles.Name = "ucFiltroMoviles";
            //this.ucFiltroMoviles.Numero = 0;
            //this.ucFiltroMoviles.Patente = "";
            //this.ucFiltroMoviles.Size = new System.Drawing.Size(937, 155);
            //this.ucFiltroMoviles.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearCliente, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnCrearCliente.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCliente.Location = new System.Drawing.Point(4, 4);
            this.BtnCrearCliente.Margin = new System.Windows.Forms.Padding(4, 4, 53, 4);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(100, 33);
            this.BtnCrearCliente.TabIndex = 14;
            this.BtnCrearCliente.Text = "Crear";
            this.BtnCrearCliente.ThemeName = "TelerikMetro";
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgvMovil, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 215);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1397, 499);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // FrmMovilListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 714);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            //this.Controls.Add(this.ucFiltroMoviles);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        //private ucFiltroMoviles ucFiltroMoviles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton BtnCrearCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
