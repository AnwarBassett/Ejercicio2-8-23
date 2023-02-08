namespace balance_General
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
            this.txtCuentasActivo = new System.Windows.Forms.TextBox();
            this.txtValorActivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chDepreciacion = new System.Windows.Forms.CheckBox();
            this.txtValorPasivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCuentaPasivo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtTotalActivo = new System.Windows.Forms.TextBox();
            this.lblTNotas = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTotalPasivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Cuenta_Activos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valores_Activos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Pasivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valores_Pasivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbMensaje = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "balance general";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cuentas activos";
            // 
            // txtCuentasActivo
            // 
            this.txtCuentasActivo.Location = new System.Drawing.Point(96, 15);
            this.txtCuentasActivo.Name = "txtCuentasActivo";
            this.txtCuentasActivo.Size = new System.Drawing.Size(100, 20);
            this.txtCuentasActivo.TabIndex = 2;
            // 
            // txtValorActivo
            // 
            this.txtValorActivo.Location = new System.Drawing.Point(96, 39);
            this.txtValorActivo.Name = "txtValorActivo";
            this.txtValorActivo.Size = new System.Drawing.Size(100, 20);
            this.txtValorActivo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "valores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chDepreciacion);
            this.groupBox1.Controls.Add(this.txtValorPasivo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCuentaPasivo);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtValorActivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCuentasActivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chDepreciacion
            // 
            this.chDepreciacion.AutoSize = true;
            this.chDepreciacion.Location = new System.Drawing.Point(202, 17);
            this.chDepreciacion.Name = "chDepreciacion";
            this.chDepreciacion.Size = new System.Drawing.Size(191, 17);
            this.chDepreciacion.TabIndex = 16;
            this.chDepreciacion.Text = "Agregar Depresiacion o Estimacion";
            this.chDepreciacion.UseVisualStyleBackColor = true;
            // 
            // txtValorPasivo
            // 
            this.txtValorPasivo.Location = new System.Drawing.Point(96, 102);
            this.txtValorPasivo.Name = "txtValorPasivo";
            this.txtValorPasivo.Size = new System.Drawing.Size(100, 20);
            this.txtValorPasivo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "cuentas pasivos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "valores";
            // 
            // txtCuentaPasivo
            // 
            this.txtCuentaPasivo.Location = new System.Drawing.Point(96, 74);
            this.txtCuentaPasivo.Name = "txtCuentaPasivo";
            this.txtCuentaPasivo.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaPasivo.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(202, 42);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(120, 457);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTotalActivo
            // 
            this.txtTotalActivo.Enabled = false;
            this.txtTotalActivo.Location = new System.Drawing.Point(361, 459);
            this.txtTotalActivo.Name = "txtTotalActivo";
            this.txtTotalActivo.Size = new System.Drawing.Size(59, 20);
            this.txtTotalActivo.TabIndex = 26;
            // 
            // lblTNotas
            // 
            this.lblTNotas.AutoSize = true;
            this.lblTNotas.Location = new System.Drawing.Point(279, 462);
            this.lblTNotas.Name = "lblTNotas";
            this.lblTNotas.Size = new System.Drawing.Size(64, 13);
            this.lblTNotas.TabIndex = 25;
            this.lblTNotas.Text = "total activos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 457);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTotalPasivo
            // 
            this.txtTotalPasivo.Enabled = false;
            this.txtTotalPasivo.Location = new System.Drawing.Point(534, 459);
            this.txtTotalPasivo.Name = "txtTotalPasivo";
            this.txtTotalPasivo.Size = new System.Drawing.Size(59, 20);
            this.txtTotalPasivo.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "total pasivo";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(455, 497);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(59, 20);
            this.txtTotal.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Faltante o Resultante";
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta_Activos,
            this.Valores_Activos,
            this.Cuenta_Pasivo,
            this.Valores_Pasivos});
            this.Tabla.Location = new System.Drawing.Point(12, 188);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(641, 209);
            this.Tabla.TabIndex = 32;
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            // 
            // Cuenta_Activos
            // 
            this.Cuenta_Activos.HeaderText = "Cuenta_Activos";
            this.Cuenta_Activos.Name = "Cuenta_Activos";
            this.Cuenta_Activos.Width = 150;
            // 
            // Valores_Activos
            // 
            this.Valores_Activos.HeaderText = "Valores_Activos";
            this.Valores_Activos.Name = "Valores_Activos";
            this.Valores_Activos.Width = 150;
            // 
            // Cuenta_Pasivo
            // 
            this.Cuenta_Pasivo.HeaderText = "Cuenta_Pasivo";
            this.Cuenta_Pasivo.Name = "Cuenta_Pasivo";
            this.Cuenta_Pasivo.Width = 150;
            // 
            // Valores_Pasivos
            // 
            this.Valores_Pasivos.HeaderText = "Valores_Pasivos";
            this.Valores_Pasivos.Name = "Valores_Pasivos";
            this.Valores_Pasivos.Width = 150;
            // 
            // LbMensaje
            // 
            this.LbMensaje.AutoSize = true;
            this.LbMensaje.Location = new System.Drawing.Point(12, 417);
            this.LbMensaje.Name = "LbMensaje";
            this.LbMensaje.Size = new System.Drawing.Size(0, 13);
            this.LbMensaje.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 529);
            this.Controls.Add(this.LbMensaje);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalPasivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTotalActivo);
            this.Controls.Add(this.lblTNotas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuentasActivo;
        private System.Windows.Forms.TextBox txtValorActivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtTotalActivo;
        private System.Windows.Forms.Label lblTNotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtValorPasivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCuentaPasivo;
        private System.Windows.Forms.TextBox txtTotalPasivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Activos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valores_Activos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Pasivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valores_Pasivos;
        private System.Windows.Forms.Label LbMensaje;
        private System.Windows.Forms.CheckBox chDepreciacion;
    }
}

