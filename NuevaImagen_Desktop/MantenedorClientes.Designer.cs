namespace NuevaImagen_Desktop
{
    partial class MantenedorClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tintutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oxidanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicativoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tintutaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroColorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oxidanteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAplicativo = new System.Windows.Forms.ComboBox();
            this.txtOxidante = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.dtpFechaAplicacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.nuevaImagenDataSet = new NuevaImagen_Desktop.NuevaImagenDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NuevaImagen_Desktop.NuevaImagenDataSetTableAdapters.ClienteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTintura = new System.Windows.Forms.TextBox();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevaImagenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombre.Location = new System.Drawing.Point(168, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(168, 58);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(250, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(168, 96);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(250, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(168, 134);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(250, 74);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripción";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresar.Location = new System.Drawing.Point(560, 167);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(161, 41);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar Aplicativo";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // aplicativoDataGridViewTextBoxColumn
            // 
            this.aplicativoDataGridViewTextBoxColumn.DataPropertyName = "Aplicativo";
            this.aplicativoDataGridViewTextBoxColumn.HeaderText = "Aplicativo";
            this.aplicativoDataGridViewTextBoxColumn.Name = "aplicativoDataGridViewTextBoxColumn";
            // 
            // tintutaDataGridViewTextBoxColumn
            // 
            this.tintutaDataGridViewTextBoxColumn.DataPropertyName = "Tintuta";
            this.tintutaDataGridViewTextBoxColumn.HeaderText = "Tintuta";
            this.tintutaDataGridViewTextBoxColumn.Name = "tintutaDataGridViewTextBoxColumn";
            // 
            // numeroColorDataGridViewTextBoxColumn
            // 
            this.numeroColorDataGridViewTextBoxColumn.DataPropertyName = "Numero_Color";
            this.numeroColorDataGridViewTextBoxColumn.HeaderText = "Numero_Color";
            this.numeroColorDataGridViewTextBoxColumn.Name = "numeroColorDataGridViewTextBoxColumn";
            // 
            // oxidanteDataGridViewTextBoxColumn
            // 
            this.oxidanteDataGridViewTextBoxColumn.DataPropertyName = "Oxidante";
            this.oxidanteDataGridViewTextBoxColumn.HeaderText = "Oxidante";
            this.oxidanteDataGridViewTextBoxColumn.Name = "oxidanteDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // aplicativoDataGridViewTextBoxColumn1
            // 
            this.aplicativoDataGridViewTextBoxColumn1.DataPropertyName = "Aplicativo";
            this.aplicativoDataGridViewTextBoxColumn1.HeaderText = "Aplicativo";
            this.aplicativoDataGridViewTextBoxColumn1.Name = "aplicativoDataGridViewTextBoxColumn1";
            // 
            // tintutaDataGridViewTextBoxColumn1
            // 
            this.tintutaDataGridViewTextBoxColumn1.DataPropertyName = "Tintuta";
            this.tintutaDataGridViewTextBoxColumn1.HeaderText = "Tintuta";
            this.tintutaDataGridViewTextBoxColumn1.Name = "tintutaDataGridViewTextBoxColumn1";
            // 
            // numeroColorDataGridViewTextBoxColumn1
            // 
            this.numeroColorDataGridViewTextBoxColumn1.DataPropertyName = "Numero_Color";
            this.numeroColorDataGridViewTextBoxColumn1.HeaderText = "Numero_Color";
            this.numeroColorDataGridViewTextBoxColumn1.Name = "numeroColorDataGridViewTextBoxColumn1";
            // 
            // oxidanteDataGridViewTextBoxColumn1
            // 
            this.oxidanteDataGridViewTextBoxColumn1.DataPropertyName = "Oxidante";
            this.oxidanteDataGridViewTextBoxColumn1.HeaderText = "Oxidante";
            this.oxidanteDataGridViewTextBoxColumn1.Name = "oxidanteDataGridViewTextBoxColumn1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Aplicativo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Oxidante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Color";
            // 
            // cmbAplicativo
            // 
            this.cmbAplicativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAplicativo.FormattingEnabled = true;
            this.cmbAplicativo.Items.AddRange(new object[] {
            "Bisos",
            "Mechas",
            "Tinturas",
            "Baño de Color"});
            this.cmbAplicativo.Location = new System.Drawing.Point(537, 16);
            this.cmbAplicativo.Name = "cmbAplicativo";
            this.cmbAplicativo.Size = new System.Drawing.Size(197, 21);
            this.cmbAplicativo.TabIndex = 15;
            // 
            // txtOxidante
            // 
            this.txtOxidante.Location = new System.Drawing.Point(537, 75);
            this.txtOxidante.Name = "txtOxidante";
            this.txtOxidante.Size = new System.Drawing.Size(197, 20);
            this.txtOxidante.TabIndex = 16;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(537, 104);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(197, 20);
            this.txtColor.TabIndex = 17;
            // 
            // dtpFechaAplicacion
            // 
            this.dtpFechaAplicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAplicacion.Location = new System.Drawing.Point(537, 138);
            this.dtpFechaAplicacion.Name = "dtpFechaAplicacion";
            this.dtpFechaAplicacion.RightToLeftLayout = true;
            this.dtpFechaAplicacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAplicacion.TabIndex = 19;
            this.dtpFechaAplicacion.Value = new System.DateTime(2016, 6, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha Aplicación";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NuevaImagen_Desktop.Properties.Resources._30d28506_8ddc_4cd6_9264_b8cc3f30133d_copia;
            this.pictureBox1.Location = new System.Drawing.Point(788, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(614, 211);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 13);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "lblError";
            this.lblError.Visible = false;
            // 
            // nuevaImagenDataSet
            // 
            this.nuevaImagenDataSet.DataSetName = "NuevaImagenDataSet";
            this.nuevaImagenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.nuevaImagenDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.descripcionClienteDataGridViewTextBoxColumn,
            this.VerDetalle});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 245);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tintura";
            // 
            // txtTintura
            // 
            this.txtTintura.Location = new System.Drawing.Point(537, 43);
            this.txtTintura.Name = "txtTintura";
            this.txtTintura.Size = new System.Drawing.Size(197, 20);
            this.txtTintura.TabIndex = 16;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionClienteDataGridViewTextBoxColumn
            // 
            this.descripcionClienteDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCliente";
            this.descripcionClienteDataGridViewTextBoxColumn.HeaderText = "Descripción Cliente";
            this.descripcionClienteDataGridViewTextBoxColumn.Name = "descripcionClienteDataGridViewTextBoxColumn";
            this.descripcionClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VerDetalle
            // 
            this.VerDetalle.HeaderText = "Ver Detalle";
            this.VerDetalle.Name = "VerDetalle";
            this.VerDetalle.ReadOnly = true;
            this.VerDetalle.Text = "Ver Detalle";
            this.VerDetalle.UseColumnTextForButtonValue = true;
            // 
            // MantenedorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 509);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaAplicacion);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtTintura);
            this.Controls.Add(this.txtOxidante);
            this.Controls.Add(this.cmbAplicativo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenedorClientes";
            this.Text = "Nueva Imagen";
            this.Load += new System.EventHandler(this.MantenedorClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevaImagenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tintutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oxidanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicativoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tintutaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oxidanteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAplicativo;
        private System.Windows.Forms.TextBox txtOxidante;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.DateTimePicker dtpFechaAplicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private NuevaImagenDataSet nuevaImagenDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private NuevaImagenDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTintura;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn VerDetalle;
    }
}

