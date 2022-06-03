
namespace FormTareaV
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.txt_nombrec = new System.Windows.Forms.TextBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_Detalles = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tdebito = new System.Windows.Forms.TextBox();
            this.txt_tcredito = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.col_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_deb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto:";
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Location = new System.Drawing.Point(34, 108);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(46, 20);
            this.txt_cuenta.TabIndex = 4;
            // 
            // txt_nombrec
            // 
            this.txt_nombrec.Location = new System.Drawing.Point(86, 108);
            this.txt_nombrec.Name = "txt_nombrec";
            this.txt_nombrec.Size = new System.Drawing.Size(200, 20);
            this.txt_nombrec.TabIndex = 5;
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(419, 108);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 7;
            this.txt_monto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_monto_KeyDown);
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "",
            "Débito",
            "Crédito"});
            this.cmb_tipo.Location = new System.Drawing.Point(292, 107);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo.TabIndex = 8;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(525, 105);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_Detalles
            // 
            this.dgv_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cuenta,
            this.col_nombrec,
            this.col_deb,
            this.col_credito});
            this.dgv_Detalles.Location = new System.Drawing.Point(35, 144);
            this.dgv_Detalles.Name = "dgv_Detalles";
            this.dgv_Detalles.ReadOnly = true;
            this.dgv_Detalles.RowHeadersWidth = 40;
            this.dgv_Detalles.Size = new System.Drawing.Size(604, 207);
            this.dgv_Detalles.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Crédito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Débito:";
            // 
            // txt_tdebito
            // 
            this.txt_tdebito.Enabled = false;
            this.txt_tdebito.Location = new System.Drawing.Point(419, 379);
            this.txt_tdebito.Name = "txt_tdebito";
            this.txt_tdebito.Size = new System.Drawing.Size(100, 20);
            this.txt_tdebito.TabIndex = 13;
            this.txt_tdebito.Text = "0";
            // 
            // txt_tcredito
            // 
            this.txt_tcredito.Enabled = false;
            this.txt_tcredito.Location = new System.Drawing.Point(539, 379);
            this.txt_tcredito.Name = "txt_tcredito";
            this.txt_tcredito.Size = new System.Drawing.Size(100, 20);
            this.txt_tcredito.TabIndex = 14;
            this.txt_tcredito.Text = "0";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(606, 105);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(66, 23);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // col_cuenta
            // 
            this.col_cuenta.HeaderText = "Cuenta";
            this.col_cuenta.Name = "col_cuenta";
            this.col_cuenta.ReadOnly = true;
            this.col_cuenta.Width = 140;
            // 
            // col_nombrec
            // 
            this.col_nombrec.HeaderText = "Nombre Cuenta";
            this.col_nombrec.Name = "col_nombrec";
            this.col_nombrec.ReadOnly = true;
            this.col_nombrec.Width = 140;
            // 
            // col_deb
            // 
            this.col_deb.HeaderText = "Débito";
            this.col_deb.Name = "col_deb";
            this.col_deb.ReadOnly = true;
            this.col_deb.Width = 140;
            // 
            // col_credito
            // 
            this.col_credito.HeaderText = "Crédito";
            this.col_credito.Name = "col_credito";
            this.col_credito.ReadOnly = true;
            this.col_credito.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_tcredito);
            this.Controls.Add(this.txt_tdebito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Detalles);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_nombrec);
            this.Controls.Add(this.txt_cuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Entrada de Diario - DataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.TextBox txt_nombrec;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_Detalles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tdebito;
        private System.Windows.Forms.TextBox txt_tcredito;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_deb;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_credito;
    }
}

