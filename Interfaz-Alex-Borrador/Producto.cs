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
    public partial class Producto : Form
    {
        private venta1 mventa;
        private List<Productos1> mProductos;
        private Consultas mconsulta;
        public Producto()
        {
            InitializeComponent();
            mProductos = new List<Productos1>();
            mconsulta = new Consultas();
            mventa = new venta1();
            cargarProductos();
        }

        private void cargarProductos(string filtro = "")
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mconsulta.getProductos(filtro);

            for (int i = 0; i < mProductos.Count(); i++)
            {
                dgvProductos.RowTemplate.Height = 50;
                dgvProductos.Rows.Add(
                    mProductos[i].id,
                    mProductos[i].idF,
                    mProductos[i].nombre,
                    mProductos[i].marca,
                    mProductos[i].descripcion,
                    mProductos[i].precio,
                    mProductos[i].stock);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (variableglobal.idCliente != 0)
                {
                    MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    button2.Enabled = true;

                }
                else {
                if (ID1 != 0)
                    {
                        Admin ope = new Admin(ID1, Cedula1, nombre1, marca1, Descripcion1, precio1, stock1);
                        this.Hide();
                        ope.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado nada para editar", "Sin elementos para editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Requiere ser administrado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Compra objform = new Compra();
            this.Hide();
            objform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(Buscar.Text.Trim());
        }

        public int ID1;
        public int Cedula1;
        public string nombre1;
        public string marca1;
        public string Descripcion1;
        public float precio1;
        public int stock1;
        
        private bool datocorrecto()
        {
            if (!int.TryParse(cantidad.Text.Trim(), out int stock))
            {
                MessageBox.Show("Ingrese una cantidad correcta (numero entero)", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                ID1 = Convert.ToInt16(fila.Cells[0].Value);
                Cedula1 = Convert.ToInt16(fila.Cells[1].Value);
                nombre1 = Convert.ToString(fila.Cells[2].Value);
                marca1 = Convert.ToString(fila.Cells[3].Value);
                Descripcion1 = Convert.ToString(fila.Cells[4].Value);
                precio1 = Convert.ToInt16(fila.Cells[5].Value);
                stock1 = Convert.ToInt16(fila.Cells[6].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciones una celda correcta", "Error En Obtención de Datos", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void cargarventa()
        {
            mventa.id_cliente = variableglobal.idCliente;
            mventa.id_producto = ID1;
            mventa.nombre = nombre1;
            mventa.cantidad = int.Parse(cantidad.Text.Trim());
            mventa.fecha = dtpfecha.Value;
        }

        private void Añadir_Compra_Click(object sender, EventArgs e)
        {
            
            
            if (!datocorrecto())
            {
                return;
            }
            int id = int.Parse(cantidad.Text.Trim());
            DateTime fecha1 = dtpfecha.Value;
            if (id > 0)
            {
                if (id <= stock1)
                {
                    cargarventa();
                    if (mconsulta.añadircompra(id, ID1))
                    {

                        if (mconsulta.addcompra(mventa))
                        {
                            MessageBox.Show("Producto comprado, GRACIAS POR COMPRAR EN FERRETRIA DON CAMACHO " + fecha1.ToShortDateString(),"Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarProductos();
                            cantidad.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar producto","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No hay Suficientes producto para vender","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("La cantidad supera a la del Stock Disponible","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
