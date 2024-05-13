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
    public partial class Frm_Usuarios : Form
    {
        private List<Clientes1> mcliente;
        private Consultas cconsultas;
        public Frm_Usuarios()
        {
            InitializeComponent();
            mcliente = new List<Clientes1>();
            cconsultas = new Consultas();
            CargarProductos();
        }

        private void CargarProductos(string filtro1 = "")
        {
            DGVcliente.Rows.Clear();
            DGVcliente.Refresh();
            mcliente.Clear();
            mcliente = cconsultas.GetCliente(filtro1);

            for(int i=0; i < mcliente.Count(); i++)
            {
                DGVcliente.RowTemplate.Height = 50;
                DGVcliente.Rows.Add(
                    mcliente[i].ID,
                    mcliente[i].nombre,
                    mcliente[i].contrasena,
                    mcliente[i].ape_mate,
                    mcliente[i].ape_pate,
                    mcliente[i].celular,
                    mcliente[i].direccion);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            FrmMenu obj = new FrmMenu();
            this.Hide();
            obj.Show();
        }

        private void DGVcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
