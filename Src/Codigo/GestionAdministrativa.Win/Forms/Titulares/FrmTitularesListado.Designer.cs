namespace GestionAdministrativa.Win.Forms.Titulares
{
    partial class FrmTitularesListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.ucFiltroTitulares = new GestionAdministrativa.Win.Forms.Titulares.ucFiltroTitulares();
            this.GridTitulares = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulares.MasterTemplate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucFiltroTitulares
            // 
            this.ucFiltroTitulares.Apellido = "";
            this.ucFiltroTitulares.DNI = 0;
            this.ucFiltroTitulares.Location = new System.Drawing.Point(3, 58);
            this.ucFiltroTitulares.Name = "ucFiltroTitulares";
            this.ucFiltroTitulares.Size = new System.Drawing.Size(823, 102);
            this.ucFiltroTitulares.TabIndex = 0;
            // 
            // GridTitulares
            // 
            this.GridTitulares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTitulares.Location = new System.Drawing.Point(3, 166);
            // 
            // GridTitulares
            // 
            this.GridTitulares.MasterTemplate.AllowAddNewRow = false;
            this.GridTitulares.MasterTemplate.AllowColumnReorder = false;
            this.GridTitulares.MasterTemplate.AllowDragToGroup = false;
            this.GridTitulares.MasterTemplate.AutoGenerateColumns = false;
            this.GridTitulares.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "DNI";
            gridViewTextBoxColumn1.HeaderText = "DNI";
            gridViewTextBoxColumn1.Name = "DNI";
            gridViewTextBoxColumn1.Width = 182;
            gridViewTextBoxColumn2.FieldName = "Apellido";
            gridViewTextBoxColumn2.HeaderText = "Apellido";
            gridViewTextBoxColumn2.Name = "Apellido";
            gridViewTextBoxColumn2.Width = 182;
            gridViewTextBoxColumn3.FieldName = "Nombre";
            gridViewTextBoxColumn3.HeaderText = "Nombre";
            gridViewTextBoxColumn3.Name = "Nombre";
            gridViewTextBoxColumn3.Width = 182;
            gridViewTextBoxColumn4.FieldName = "Telefono";
            gridViewTextBoxColumn4.HeaderText = "Telefono";
            gridViewTextBoxColumn4.Name = "Telefono";
            gridViewTextBoxColumn4.Width = 182;
            gridViewTextBoxColumn5.FieldName = "Mail";
            gridViewTextBoxColumn5.HeaderText = "Email";
            gridViewTextBoxColumn5.Name = "Mail";
            gridViewTextBoxColumn5.Width = 181;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::GestionAdministrativa.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.Name = "Detail";
            gridViewCommandColumn1.Width = 46;
            this.GridTitulares.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
            this.GridTitulares.Name = "GridTitulares";
            this.GridTitulares.ReadOnly = true;
            this.GridTitulares.Size = new System.Drawing.Size(972, 419);
            this.GridTitulares.TabIndex = 1;
            this.GridTitulares.Text = "radGridView1";
            this.GridTitulares.ThemeName = "TelerikMetro";
            this.GridTitulares.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridTitulares_CommandCellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnCrear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucFiltroTitulares, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GridTitulares, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.01361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.9864F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 588);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.Yellow;
            this.BtnCrear.FlatAppearance.BorderSize = 0;
            this.BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrear.Location = new System.Drawing.Point(3, 3);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(153, 41);
            this.BtnCrear.TabIndex = 11;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // FrmTitularesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmTitularesListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de titulares";
            this.Load += new System.EventHandler(this.FrmTitularesListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulares.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulares)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucFiltroTitulares ucFiltroTitulares;
        private Telerik.WinControls.UI.RadGridView GridTitulares;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnCrear;
    }
}