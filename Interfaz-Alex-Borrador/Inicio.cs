using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Interfaz_Alex_Borrador
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "ADMIN44" && txtContrasena.Text == "Pasword123")
                {
                    int idCliente = 0;
                    variableglobal.idCliente = idCliente;
                    FrmMenu llamar = new FrmMenu();
                    llamar.Show();
                    this.Hide();
                }
                else
                {
                    using (MySqlConnection connection = ConexionInicio.conexioninicio())
                    {
                        connection.Open();

                        string consulta = "SELECT * FROM cliente WHERE  BINARY nombre = @nombre AND BINARY contrasena = @contrasena";
                        MySqlCommand codigoCliente = new MySqlCommand(consulta, connection);
                        codigoCliente.Parameters.AddWithValue("@nombre", txtUsuario.Text);
                        codigoCliente.Parameters.AddWithValue("@contrasena", txtContrasena.Text);

                        using (MySqlDataReader leer = codigoCliente.ExecuteReader())
                        {
                            if (leer.Read())
                            {
                                int idCliente = leer.GetInt32("id_cliente");
                                variableglobal.idCliente = idCliente;
                                FrmMenu llamar = new FrmMenu();
                                llamar.Show();
                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrecta", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtContrasena.Clear();
                                txtUsuario.Clear();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema de Conexión ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Registro ira = new Registro();
            this.Hide();
            ira.Show();
        }
    }
}
