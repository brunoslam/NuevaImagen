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
    public partial class VerDetalle : Form
    {
        public VerDetalle(int idCliente)
        {

            InitializeComponent();
            escribirDatosCliente(idCliente);
            idClienteToolStripTextBox.Text = idCliente.ToString();
            fillByIdButton.PerformClick();
        }
        private void VerDetalle_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MantenedorClientes mantenedor = new MantenedorClientes();
            this.Hide();
            mantenedor.ShowDialog();
        }

        private void escribirDatosCliente(int idCliente)
        {

            Cliente cliente = new Cliente();
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = "Data Source=LS-DEV\\SQLEXPRESS;Initial Catalog=NuevaImagen;User ID=sa;password=nuevaimagen";
            connetionString = "Data Source=.;Initial Catalog=NuevaImagen;Integrated Security=True";
            string sql = "SELECT Nombre,  Telefono, Direccion, DescripcionCliente FROM Cliente WHERE ID_Cliente = " + idCliente + "";
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
                    txtNombre.Text = row[0].ToString();
                    txtTelefono.Text = row[1].ToString();
                    txtDireccion.Text = row[2].ToString();
                    txtDescripcion.Text = row[3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Boolean isExito = false; 
            if (btnEditar.Text == "Editar Cliente")
            {
                txtTelefono.Enabled = true;
                txtDireccion.Enabled = true;
                txtDescripcion.Enabled = true;
                btnEditar.Text = "Confirmar Cambios";
                btnCancelar.Visible = true;

            }
            else
            {
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                connetionString = "Data Source=LS-DEV\\SQLEXPRESS;Initial Catalog=NuevaImagen;User ID=sa;password=nuevaimagen";
                connetionString = "Data Source=.;Initial Catalog=NuevaImagen;Integrated Security=True";
                string sql = "UPDATE Cliente SET Telefono = '" + txtTelefono.Text + "', Direccion = '" + txtDireccion.Text + "', DescripcionCliente = '" + txtDescripcion.Text + "' WHERE ID_Cliente =" + idClienteToolStripTextBox.Text;
                connection = new SqlConnection(connetionString);
                try
                {
                    command = new SqlCommand(sql, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    isExito = true;
                }
                catch (Exception ex)
                {
                    isExito = false;
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
            }

            if (isExito)
            {
                btnEditar.Text = "Editar Cliente";
                txtNombre.Enabled = false;
                txtTelefono.Enabled = false;
                txtDireccion.Enabled = false;
                txtDescripcion.Enabled = false;
                MessageBox.Show("Editado correctamente");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtDescripcion.Enabled = false;
            btnCancelar.Visible = false;
            btnEditar.Text = "Editar Cliente";
        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.aplicativoTableAdapter.FillBy1(this.nuevaImagenDataSet.Aplicativo, ((int)(System.Convert.ChangeType(idClienteToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
