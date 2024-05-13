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
    public partial class Venta : Form
    {
        private List<venta1> mventa2;
        private Consultas mconsulta;
        public Venta()
        {
            InitializeComponent();
            mventa2 = new List<venta1>();
            mconsulta = new Consultas();
            cargaventas();
           
        }

        private void cargaventas(string filtro = "")
        {
            dgvventa.Rows.Clear();
            dgvventa.Refresh();
            mventa2.Clear();
            mventa2 = mconsulta.getventa(filtro);

            for (int i= 0; i < mventa2.Count(); i++)
            {
                dgvventa.RowTemplate.Height = 50;
                dgvventa.Rows.Add(
                    mventa2[i].id_venta,
                    mventa2[i].id_cliente,
                    mventa2[i].id_producto,
                    mventa2[i].nombre,
                    mventa2[i].cantidad,
                    mventa2[i].fecha);
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            FrmMenu objuno = new FrmMenu();
            this.Hide();
            objuno.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
