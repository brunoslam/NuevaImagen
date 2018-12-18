namespace NuevaImagen_Desktop
{
    partial class VerDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerDetalle));
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.idClienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idClienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIdButton = new System.Windows.Forms.ToolStripButton();
            this.iDAplicativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tintutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oxidanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAplicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nuevaImagenDataSet = new NuevaImagen_Desktop.NuevaImagenDataSet();
            this.aplicativoTableAdapter = new NuevaImagen_Desktop.NuevaImagenDataSetTableAdapters.AplicativoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevaImagenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(671, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(154, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(154, 60);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(303, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(154, 89);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(303, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(154, 115);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(303, 41);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NuevaImagen_Desktop.Properties.Resources._30d28506_8ddc_4cd6_9264_b8cc3f30133d_copia;
            this.pictureBox1.Location = new System.Drawing.Point(519, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(365, 162);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 34);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar Cliente";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(262, 162);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 34);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAplicativoDataGridViewTextBoxColumn,
            this.iDClienteDataGridViewTextBoxColumn,
            this.aplicativoDataGridViewTextBoxColumn,
            this.tintutaDataGridViewTextBoxColumn,
            this.numeroColorDataGridViewTextBoxColumn,
            this.oxidanteDataGridViewTextBoxColumn,
            this.fechaAplicacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aplicativoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 295);
            this.dataGridView1.TabIndex = 16;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idClienteToolStripLabel,
            this.idClienteToolStripTextBox,
            this.fillByIdButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(774, 25);
            this.fillBy1ToolStrip.TabIndex = 17;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // idClienteToolStripLabel
            // 
            this.idClienteToolStripLabel.Name = "idClienteToolStripLabel";
            this.idClienteToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.idClienteToolStripLabel.Text = "IdCliente:";
            // 
            // idClienteToolStripTextBox
            // 
            this.idClienteToolStripTextBox.Name = "idClienteToolStripTextBox";
            this.idClienteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByIdButton
            // 
            this.fillByIdButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByIdButton.Name = "fillBy1ToolStripButton";
            this.fillByIdButton.Size = new System.Drawing.Size(45, 22);
            this.fillByIdButton.Text = "FillBy1";
            this.fillByIdButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click_1);
            // 
            // iDAplicativoDataGridViewTextBoxColumn
            // 
            this.iDAplicativoDataGridViewTextBoxColumn.DataPropertyName = "ID_Aplicativo";
            this.iDAplicativoDataGridViewTextBoxColumn.HeaderText = "ID_Aplicativo";
            this.iDAplicativoDataGridViewTextBoxColumn.Name = "iDAplicativoDataGridViewTextBoxColumn";
            this.iDAplicativoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAplicativoDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // aplicativoDataGridViewTextBoxColumn
            // 
            this.aplicativoDataGridViewTextBoxColumn.DataPropertyName = "Aplicativo";
            this.aplicativoDataGridViewTextBoxColumn.HeaderText = "Aplicativo";
            this.aplicativoDataGridViewTextBoxColumn.Name = "aplicativoDataGridViewTextBoxColumn";
            this.aplicativoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tintutaDataGridViewTextBoxColumn
            // 
            this.tintutaDataGridViewTextBoxColumn.DataPropertyName = "Tintuta";
            this.tintutaDataGridViewTextBoxColumn.HeaderText = "Tintuta";
            this.tintutaDataGridViewTextBoxColumn.Name = "tintutaDataGridViewTextBoxColumn";
            this.tintutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroColorDataGridViewTextBoxColumn
            // 
            this.numeroColorDataGridViewTextBoxColumn.DataPropertyName = "Numero_Color";
            this.numeroColorDataGridViewTextBoxColumn.HeaderText = "Número Color";
            this.numeroColorDataGridViewTextBoxColumn.Name = "numeroColorDataGridViewTextBoxColumn";
            this.numeroColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oxidanteDataGridViewTextBoxColumn
            // 
            this.oxidanteDataGridViewTextBoxColumn.DataPropertyName = "Oxidante";
            this.oxidanteDataGridViewTextBoxColumn.HeaderText = "Oxidante";
            this.oxidanteDataGridViewTextBoxColumn.Name = "oxidanteDataGridViewTextBoxColumn";
            this.oxidanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAplicacionDataGridViewTextBoxColumn
            // 
            this.fechaAplicacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Aplicacion";
            this.fechaAplicacionDataGridViewTextBoxColumn.HeaderText = "Fecha Aplicación";
            this.fechaAplicacionDataGridViewTextBoxColumn.Name = "fechaAplicacionDataGridViewTextBoxColumn";
            this.fechaAplicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aplicativoBindingSource
            // 
            this.aplicativoBindingSource.DataMember = "Aplicativo";
            this.aplicativoBindingSource.DataSource = this.nuevaImagenDataSet;
            // 
            // nuevaImagenDataSet
            // 
            this.nuevaImagenDataSet.DataSetName = "NuevaImagenDataSet";
            this.nuevaImagenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aplicativoTableAdapter
            // 
            this.aplicativoTableAdapter.ClearBeforeFill = true;
            // 
            // VerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 517);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerDetalle";
            this.Text = "Ver Detalle";
            this.Load += new System.EventHandler(this.VerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevaImagenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NuevaImagenDataSet nuevaImagenDataSet;
        private System.Windows.Forms.BindingSource aplicativoBindingSource;
        private NuevaImagenDataSetTableAdapters.AplicativoTableAdapter aplicativoTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel idClienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idClienteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIdButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAplicativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tintutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oxidanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAplicacionDataGridViewTextBoxColumn;
    }
}