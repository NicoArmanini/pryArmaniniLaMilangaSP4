namespace pryArmaniniLaMilangaSP4
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnMozoDelDia = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMozo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblBebidaSA = new System.Windows.Forms.Label();
            this.lblBebidaCA = new System.Windows.Forms.Label();
            this.lblPostres = new System.Windows.Forms.Label();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.txtMozo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtComidas = new System.Windows.Forms.TextBox();
            this.txtBebidasSA = new System.Windows.Forms.TextBox();
            this.txtBebidasCA = new System.Windows.Forms.TextBox();
            this.txtPostres = new System.Windows.Forms.TextBox();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTabla.Location = new System.Drawing.Point(32, 25);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(689, 274);
            this.dgvTabla.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mozo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Comidas";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bebidas sin Alcohol";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bebidas con Alcohol";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Postres";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 90;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(772, 25);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(145, 45);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnMozoDelDia
            // 
            this.btnMozoDelDia.Enabled = false;
            this.btnMozoDelDia.Location = new System.Drawing.Point(32, 337);
            this.btnMozoDelDia.Name = "btnMozoDelDia";
            this.btnMozoDelDia.Size = new System.Drawing.Size(116, 38);
            this.btnMozoDelDia.TabIndex = 2;
            this.btnMozoDelDia.Text = "Mozo del Dia";
            this.btnMozoDelDia.UseVisualStyleBackColor = true;
            this.btnMozoDelDia.Click += new System.EventHandler(this.btnMozoDelDia_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Enabled = false;
            this.btnTotal.Location = new System.Drawing.Point(32, 421);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(116, 39);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(799, 479);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 31);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Location = new System.Drawing.Point(177, 330);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(40, 16);
            this.lblMozo.TabIndex = 5;
            this.lblMozo.Text = "Mozo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(332, 330);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(177, 419);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(61, 16);
            this.lblComidas.TabIndex = 7;
            this.lblComidas.Text = "Comidas";
            // 
            // lblBebidaSA
            // 
            this.lblBebidaSA.AutoSize = true;
            this.lblBebidaSA.Location = new System.Drawing.Point(281, 419);
            this.lblBebidaSA.Name = "lblBebidaSA";
            this.lblBebidaSA.Size = new System.Drawing.Size(126, 16);
            this.lblBebidaSA.TabIndex = 8;
            this.lblBebidaSA.Text = "Bebidas sin Alcohol";
            // 
            // lblBebidaCA
            // 
            this.lblBebidaCA.AutoSize = true;
            this.lblBebidaCA.Location = new System.Drawing.Point(424, 419);
            this.lblBebidaCA.Name = "lblBebidaCA";
            this.lblBebidaCA.Size = new System.Drawing.Size(131, 16);
            this.lblBebidaCA.TabIndex = 9;
            this.lblBebidaCA.Text = "Bebidas con Alcohol";
            // 
            // lblPostres
            // 
            this.lblPostres.AutoSize = true;
            this.lblPostres.Location = new System.Drawing.Point(580, 419);
            this.lblPostres.Name = "lblPostres";
            this.lblPostres.Size = new System.Drawing.Size(53, 16);
            this.lblPostres.TabIndex = 10;
            this.lblPostres.Text = "Postres";
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Location = new System.Drawing.Point(683, 419);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(70, 16);
            this.lblTotalFinal.TabIndex = 11;
            this.lblTotalFinal.Text = "Total Final";
            // 
            // txtMozo
            // 
            this.txtMozo.Location = new System.Drawing.Point(171, 349);
            this.txtMozo.Name = "txtMozo";
            this.txtMozo.ReadOnly = true;
            this.txtMozo.Size = new System.Drawing.Size(132, 22);
            this.txtMozo.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(335, 349);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(117, 22);
            this.txtTotal.TabIndex = 13;
            // 
            // txtComidas
            // 
            this.txtComidas.Location = new System.Drawing.Point(171, 438);
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.ReadOnly = true;
            this.txtComidas.Size = new System.Drawing.Size(97, 22);
            this.txtComidas.TabIndex = 14;
            // 
            // txtBebidasSA
            // 
            this.txtBebidasSA.Location = new System.Drawing.Point(284, 439);
            this.txtBebidasSA.Name = "txtBebidasSA";
            this.txtBebidasSA.ReadOnly = true;
            this.txtBebidasSA.Size = new System.Drawing.Size(123, 22);
            this.txtBebidasSA.TabIndex = 15;
            // 
            // txtBebidasCA
            // 
            this.txtBebidasCA.Location = new System.Drawing.Point(427, 439);
            this.txtBebidasCA.Name = "txtBebidasCA";
            this.txtBebidasCA.ReadOnly = true;
            this.txtBebidasCA.Size = new System.Drawing.Size(140, 22);
            this.txtBebidasCA.TabIndex = 16;
            // 
            // txtPostres
            // 
            this.txtPostres.Location = new System.Drawing.Point(583, 438);
            this.txtPostres.Name = "txtPostres";
            this.txtPostres.ReadOnly = true;
            this.txtPostres.Size = new System.Drawing.Size(88, 22);
            this.txtPostres.TabIndex = 17;
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Location = new System.Drawing.Point(686, 439);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.ReadOnly = true;
            this.txtTotalFinal.Size = new System.Drawing.Size(97, 22);
            this.txtTotalFinal.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(928, 522);
            this.Controls.Add(this.txtTotalFinal);
            this.Controls.Add(this.txtPostres);
            this.Controls.Add(this.txtBebidasCA);
            this.Controls.Add(this.txtBebidasSA);
            this.Controls.Add(this.txtComidas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtMozo);
            this.Controls.Add(this.lblTotalFinal);
            this.Controls.Add(this.lblPostres);
            this.Controls.Add(this.lblBebidaCA);
            this.Controls.Add(this.lblBebidaSA);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMozo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMozoDelDia);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dgvTabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Bar - LaMilanga";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnMozoDelDia;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblBebidaSA;
        private System.Windows.Forms.Label lblBebidaCA;
        private System.Windows.Forms.Label lblPostres;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.TextBox txtMozo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtComidas;
        private System.Windows.Forms.TextBox txtBebidasSA;
        private System.Windows.Forms.TextBox txtBebidasCA;
        private System.Windows.Forms.TextBox txtPostres;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

