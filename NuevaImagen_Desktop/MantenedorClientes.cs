using NuevaImagen_Desktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevaImagen_Desktop
{
    public partial class MantenedorClientes : Form
    {
        public MantenedorClientes()
        {
            InitializeComponent();


        }

        private void MantenedorClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'nuevaImagenDataSet.Aplicativo' Puede moverla o quitarla según sea necesario.
            //this.aplicativoTableAdapter.Fill(this.nuevaImagenDataSet.Aplicativo);
            // TODO: esta línea de código carga datos en la tabla 'nuevaImagenDataSet.Cliente' Puede moverla o quitarla según sea necesario.

            //this.clienteTableAdapter.Fill(this.nuevaImagenDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'nuevaImagenDataSet.Aplicativo' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.nuevaImagenDataSet.Cliente);

            //AUTOCOMPLETE
            txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            txtNombre.AutoCompleteCustomSource = DataCollection;
        }

        private void getData(AutoCompleteStringCollection dataCollection)
        {
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            
            //connetionString = "Data Source=LS-DEV\\SQLEXPRESS;Initial Catalog=NuevaImagen;User ID=sa;password=nuevaimagen";
            connetionString = "Data Source=.;Initial Catalog=NuevaImagen;Integrated Security=True";
            string sql = "SELECT Nombre FROM Cliente";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //Ver Detalle
                if(e.ColumnIndex == 5)
                {
                    int idCliente = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    VerDetalle verdetalle = new VerDetalle(idCliente);
                    this.Hide();
                    verdetalle.ShowDialog();
                    ;
                }
                
            }
        }
        
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;

            Cliente cliente = new Cliente();
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = "Data Source=.;Initial Catalog=NuevaImagen;Integrated Security=True";
            string sql = "SELECT Nombre as NOMBRECOMPLETO, Telefono, Direccion, DescripcionCliente FROM Cliente WHERE Nombre =  '" + nombre +"'";
            connection = new SqlConnection(connetionString);
            try
            {
                int contador = 0;
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    contador++;
                    cliente.nombre = row[0].ToString();
                    txtTelefono.Text = row[1].ToString();
                    txtDireccion.Text = row[2].ToString();
                    txtDescripcion.Text = row[3].ToString();
                    txtTelefono.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtDescripcion.Enabled = false;
                }
                if (contador == 0)
                {
                    txtNombre.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtTelefono.Text = "";
                    txtDireccion.Text = "";
                    txtDescripcion.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Boolean isExito = false;
            if (validarFormulario())
            {
                String connetionString = "Data Source=.;Initial Catalog=NuevaImagen;Integrated Security=True";
                
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("IngresarAplicativo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreCliente", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Aplicativo", cmbAplicativo.SelectedItem);
                        cmd.Parameters.AddWithValue("@Tintura", txtTintura.Text);
                        cmd.Parameters.AddWithValue("@NroColor", txtColor.Text);
                        cmd.Parameters.AddWithValue("@Oxidante", txtOxidante.Text);
                        cmd.Parameters.AddWithValue("@FechaAplicacion", DateTime.Parse(dtpFechaAplicacion.Text));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        isExito = true;
                    }
                }
            }
            if (isExito)
            {
                cmbAplicativo.SelectedIndex = -1;
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
                txtDescripcion.Text = "";
                txtOxidante.Text = "";
                txtColor.Text = "";
                txtTintura.Text = "";
                MessageBox.Show("Ingresado correctamente");
                this.clienteTableAdapter.Fill(this.nuevaImagenDataSet.Cliente);
            }
            
        }
        public Boolean validarFormulario()
        {
            if (txtNombre.Text == "")
            {
                lblError.Text = "Debe ingresar un nombre de cliente";
                lblError.Visible = true;
                return false;
            }
            else
            {
                lblError.Visible = false;
            }

            if (cmbAplicativo.SelectedItem == null)
            {
                lblError.Text = "Debe seleccionar un aplicativo";
                lblError.Visible = true;
                return false;
            }
            else
            {
                lblError.Visible = false;
            }
            return true;
        }
    }
}
