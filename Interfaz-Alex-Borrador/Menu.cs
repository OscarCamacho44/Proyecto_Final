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
    public partial class FrmMenu : Form
    {
        
        
        public FrmMenu()
        {
            InitializeComponent();
            
        }

        private void Empleado_Click(object sender, EventArgs e)
        {
                    Informacion objform = new Informacion();
                    this.Hide();
                    objform.Show();    
        }
        
        

        

        private void Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (variableglobal.idCliente != 0)
                {
                    MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Cliente.Enabled = true;
                    
                }
                else
                {
                    Frm_Usuarios objform = new Frm_Usuarios();
                    this.Hide();
                    objform.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            Producto objform = new Producto();
            this.Hide();
            objform.Show();
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            try
            {
                if (variableglobal.idCliente != 0)
                {
                    MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Venta.Enabled = true;

                }
                else
                {
                    Venta objform = new Venta();
                    this.Hide();
                    objform.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Registro_Click(object sender, EventArgs e)
        {
        }

        private void Admini_Click(object sender, EventArgs e)
        {
            try
            {
                if (variableglobal.idCliente != 0)
                {
                    MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Admini.Enabled = true;

                }
                else
                {
                    Admin ira = new Admin();
                    this.Hide();
                    ira.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (variableglobal.idCliente != 0)
                {
                    MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    button3.Enabled = true;

                }
                else
                {
                    Cliente objform3 = new Cliente();
                    this.Hide();
                    objform3.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
