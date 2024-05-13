using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Interfaz_Alex_Borrador
{
    public partial class Cliente : Form
    {
        public SerialPort Ardu { get; }
        private List<Proveedores1> mproveedor;
        private Consultas mconsultas;
        private Proveedores1 MProveedor;
        public Cliente()
        {
            InitializeComponent();
            Ardu = new System.IO.Ports.SerialPort();
            Ardu.PortName = "COM3";
            Ardu.BaudRate = 9600;
            Ardu.Open();
            
            mproveedor = new List<Proveedores1>();
            mconsultas = new Consultas();
            MProveedor = new Proveedores1();
            CargarProductos();
        }

        private void CargarProductos(string filtro = "")
        {
            dgvprovee.Rows.Clear();
            dgvprovee.Refresh();
            mproveedor.Clear();
            mproveedor = mconsultas.getproveedor(filtro);

            for( int i=0; i <mproveedor.Count(); i++)
            {
                dgvprovee.RowTemplate.Height = 50;
                dgvprovee.Rows.Add(
                    mproveedor[i].cedula,
                    mproveedor[i].Nombre,
                    mproveedor[i].APE_paterno,
                    mproveedor[i].APE_materno,
                    mproveedor[i].direccion,
                    mproveedor[i].celular);
            }
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            if (Ardu.IsOpen) Ardu.Close();
            FrmMenu objuno = new FrmMenu();
            this.Hide();
            objuno.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txrPate.Text = "";
            txtMate.Text = "";
            txtMate.Text = "";
            txtCedula.Text = "";
            txtDire.Text = "";
            txtCell.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            if (Ardu.IsOpen) Ardu.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(Buscar.Text.Trim());
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!datosCorrecto())
            {
                return;
            }
            CargarDatosProveedores();
            if (mconsultas.agregaproveedor(MProveedor))
            {
                MessageBox.Show("Proveedor nuevo agregado", "Ingreso correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarProductos();
                Limpiarcampos();

            }
        }

        private void Limpiarcampos()
        {
            txtNombre.Text = "";
            txrPate.Text = "";
            txtMate.Text = "";
            txtMate.Text = "";
            txtCedula.Text = "";
            txtDire.Text = "";
            txtCell.Text = "";
        }

        private void CargarDatosProveedores()
        {
            MProveedor.cedula = getfolioexist();
            MProveedor.Nombre = txtNombre.Text.Trim();
            MProveedor.APE_paterno = txrPate.Text.Trim();
            MProveedor.APE_materno = txtMate.Text.Trim();
            MProveedor.direccion = txtDire.Text.Trim();
            MProveedor.celular =long.Parse(txtCell.Text.Trim());    
        }

        private int getfolioexist()
        {
            if (!txtCedula.Text.Trim().Equals(""))
            {
                if(int.TryParse(txtCedula.Text.Trim(), out int cedu))
                {
                    return cedu;
                }
                else return -1;
            }
            else return -1;
        }

        private bool datosCorrecto()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (txrPate.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Apellido Paterno", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (txtMate.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Apellido Materno", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (txtDire.Text.Trim().Equals(""))
            {
                MessageBox.Show( "Ingrese la Dirección","Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (!long.TryParse(txtCell.Text.Trim(), out long cell) || txtCell.Text.Length != 10)
            {
                MessageBox.Show("Ingrese el numero de telefono (10 Digitos","Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private void dgvprovee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvprovee.Rows[e.RowIndex];
            txtCedula.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txrPate.Text = Convert.ToString(fila.Cells[2].Value);
            txtMate.Text = Convert.ToString(fila.Cells[3].Value);
            txtDire.Text = Convert.ToString(fila.Cells[4].Value);
            txtCell.Text = Convert.ToString(fila.Cells[5].Value);
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {

            if (!datosCorrecto())
            {
                return;
            }

            if (getfolioexist() != -1)
            {
                int Decimal = getfolioexist();
                string Octal = Convert.ToString(Decimal, 8);
                string Binario = Convert.ToString(Decimal, 2);
                Ardu.Write("UPDATE:");
                Ardu.Write(Binario);
                Ardu.Write(Octal);
            }
            CargarDatosProveedores();
            if (mconsultas.Modificarproveedor(MProveedor))
            {
                MessageBox.Show("Proveedor Modificado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarProductos();
                Limpiarcampos();

            }
            

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if(getfolioexist() == -1)
            {
                return;
            }
            

            if(MessageBox.Show("¿Desea eliminar el proveedor?", "Eliminar Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CargarDatosProveedores();
                if (mconsultas.eliminarproveedor(MProveedor))
                {
                    MessageBox.Show("Producto Eliminado");
                    CargarProductos();
                    Limpiarcampos();
                }
            }
           
            
        }
    }
}
