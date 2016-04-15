namespace GestionAdministrativa.Win.Forms.Choferes.Comentarios
{
    partial class ucComentarios
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.gridComentarios = new Telerik.WinControls.UI.RadGridView();
            this.txtComentario = new Telerik.WinControls.UI.RadTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComentarios.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario)).BeginInit();
            this.SuspendLayout();
            // 
            // gridComentarios
            // 
            this.gridComentarios.AutoSizeRows = true;
            this.gridComentarios.Location = new System.Drawing.Point(15, 16);
            // 
            // gridComentarios
            // 
            this.gridComentarios.MasterTemplate.AllowAddNewRow = false;
            this.gridComentarios.MasterTemplate.AllowColumnReorder = false;
            this.gridComentarios.MasterTemplate.AllowDragToGroup = false;
            this.gridComentarios.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaAlta";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Fecha";
            gridViewTextBoxColumn1.Name = "Fecha";
            gridViewTextBoxColumn1.Width = 227;
            gridViewTextBoxColumn2.FieldName = "Comentario.comentario1";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Comentario";
            gridViewTextBoxColumn2.Multiline = true;
            gridViewTextBoxColumn2.Name = "comentario1";
            gridViewTextBoxColumn2.Width = 405;
            gridViewTextBoxColumn2.WrapText = true;
            this.gridComentarios.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gridComentarios.Name = "gridComentarios";
            this.gridComentarios.ReadOnly = true;
            this.gridComentarios.Size = new System.Drawing.Size(653, 411);
            this.gridComentarios.TabIndex = 0;
            this.gridComentarios.Text = "radGridView1";
            this.gridComentarios.ThemeName = "TelerikMetro";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(15, 451);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            // 
            // 
            // 
            this.txtComentario.RootElement.StretchVertically = true;
            this.txtComentario.Size = new System.Drawing.Size(653, 95);
            this.txtComentario.TabIndex = 1;
            this.txtComentario.TabStop = false;
            this.txtComentario.ThemeName = "TelerikMetro";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(446, 567);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(222, 46);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar comentario";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ucComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.gridComentarios);
            this.Name = "ucComentarios";
            this.Size = new System.Drawing.Size(694, 675);
            ((System.ComponentModel.ISupportInitialize)(this.gridComentarios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridComentarios;
        private Telerik.WinControls.UI.RadTextBox txtComentario;
        private System.Windows.Forms.Button btnGuardar;
    }
}
