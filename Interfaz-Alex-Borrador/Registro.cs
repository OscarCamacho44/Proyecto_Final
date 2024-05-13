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
    public partial class Registro : Form
    {
        private Clientes1 mcliente;
        private Consultas mconsulta;
        public Registro()
        {
            InitializeComponent();
            mcliente = new Clientes1();
            mconsulta = new Consultas();
        }

       


        private void button2_Click(object sender, EventArgs e)
        {
            txtAPM.Text = "";
            txtNombre.Text = "";
            txtAPP.Text = "";
            txtDire.Text = "";
            txtCell.Text = "";
            TXTContra.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private bool DatosCorrectos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre", "Campo Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtAPM.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese su apellido paterno", "Campo Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtAPP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese su apellido materno", "Campo Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (TXTContra.Text.Trim().Equals("") || TXTContra.TextLength != 8)
            {
                MessageBox.Show("Ingrese una contraseña de 8 caracteres", "Campo Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!long.TryParse(txtCell.Text.Trim(), out long cel) || txtCell.Text.Length != 10)
            {
                MessageBox.Show("Ingrese su numero de telefono o Celular", "Campo Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtDire.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese su Dirección", "Campo Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
            return true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (!DatosCorrectos())
            {
                return;
            }
            CargData();

            if (mconsulta.addcliente(mcliente))
            {
                MessageBox.Show("Nueva cuenta agregada, BIENVENIDO!!", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiardata();
                Inicio objuno = new Inicio();
                this.Hide();
                objuno.Show();

            }
        }

        private void limpiardata()
        {
            txtNombre.Text = "";
            txtAPP.Text = "";
            txtAPM.Text = "";
            TXTContra.Text = "";
            txtCell.Text = "";
            txtDire.Text = "";
        }

        private void CargData()
        {
            mcliente.nombre = txtNombre.Text.Trim();
            mcliente.ape_pate = txtAPP.Text.Trim();
            mcliente.ape_mate = txtAPM.Text.Trim();
            mcliente.contrasena = TXTContra.Text.Trim();
            mcliente.celular = long.Parse(txtCell.Text.Trim());
            mcliente.direccion = txtDire.Text.Trim();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio objuno = new Inicio();
            this.Hide();
            objuno.Show();


        }
    }
}
