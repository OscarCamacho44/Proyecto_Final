using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Alex_Borrador
{
    public partial class Compra : Form
    {
        private ConexionMYSQL union;
        private List<venta1> mventa;
        private Consultas mconsulta;
        public Compra()
        {
            InitializeComponent();
            mventa = new List<venta1>();
            mconsulta = new Consultas();
            union = new ConexionMYSQL();

            cargarcompra();
        }

        private void cargarcompra(string filtro = "")
        {
            try
            {
                dgvcompra.Rows.Clear();
            dgvcompra.Refresh();
            

            foreach (venta1 venta in mventa)
            {
                dgvcompra.RowTemplate.Height = 50;
                dgvcompra.Rows.Add(
                    venta.id_venta,
                    venta.id_cliente,
                    venta.id_producto,
                    venta.nombre,
                    venta.cantidad,
                    venta.fecha);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras en el DataGridView: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacion objform = new Informacion();
            this.Hide();
            objform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto objform = new Producto();
            this.Hide();
            objform.Show();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            try
            {
                string QUERY = "SELECT * FROM venta WHERE id_cliente = @id ;";
                MySqlCommand mComando = new MySqlCommand(QUERY, union.GetConnection());
                mComando.Parameters.Add(new MySqlParameter("@id", variableglobal.idCliente));

                using (MySqlDataReader Reader = mComando.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        venta1 mventa2 = new venta1();
                        mventa2.id_venta = Reader.GetInt16("id_venta");
                        mventa2.id_cliente = Reader.GetInt16("id_cliente");
                        mventa2.id_producto = Reader.GetInt16("id_producto");
                        mventa2.nombre = Reader.GetString("nombre_p");
                        mventa2.cantidad = Reader.GetInt16("cantidad");
                        mventa2.fecha = Reader.GetDateTime("fecha");
                        mventa.Add(mventa2);
                    }
                }

                cargarcompra();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un problema al cargar las compras: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
