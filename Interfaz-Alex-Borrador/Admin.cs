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
    
    public partial class Admin : Form
    {
        private Productos1 mProducto;
        private Consultas mconsultas;
        private List<Proveedores1> mproveedor;

        private int ID;
        private int Cedula2;
        private string Nombre2;
        private string Marca2;
        private string Descripcion2;
        private float Precio2;
        private int Stock2;
        public Admin()
        {
            InitializeComponent();
            mProducto = new Productos1();
            mconsultas = new Consultas();
            CargarProvedor();
        }

        private void CargarProvedor(string filtro = "")
        {
            dgvprovee.Rows.Clear();
            dgvprovee.Refresh();
            mproveedor = mconsultas.verproveedor(filtro);

            for (int i = 0; i<mproveedor.Count; i++)
            {
                dgvprovee.RowTemplate.Height = 50;
                dgvprovee.Rows.Add(
                    mproveedor[i].cedula,
                    mproveedor[i].Nombre);
            }
        }

        public Admin(int idProducto, int cedulaProducto, string nombreProducto, string marcaProducto, string descripcionProducto, float precioProducto, int stockProducto)
        {
            InitializeComponent();
            mconsultas = new Consultas();
            mProducto = new Productos1();
            ID = idProducto;
            Cedula2 = cedulaProducto;
            Nombre2 = nombreProducto;
            Marca2 = marcaProducto;
            Descripcion2 = descripcionProducto;
            Precio2 = precioProducto;
            Stock2 = stockProducto;
            CargarProvedor();
        }
        private bool datosCorrectos()
        {
            if(INGnombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (INGmarca.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la marca", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (INGprecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el precio", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (INGcedula.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la cedula del proveedor", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (INGdes.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la descripcion del producto", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (INGstock.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese ingrese la cantidad disponible", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (!float.TryParse(INGprecio.Text.Trim(), out float precio))
            {
                MessageBox.Show("Ingrese un precio correcto (numero 00.00)", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (!int.TryParse(INGstock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Ingrese un stock correcto (numero entero)", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (!int.TryParse(INGcedula.Text.Trim(), out int cedula))
            {
                MessageBox.Show("Ingrese una cedula correcta", "Campo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            CargarDatosProducto();


            if (mconsultas.agregarProducto(mProducto))
            {
                MessageBox.Show("Producto agregado", "Nuevo Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
            }
        }
        private void CargarDatosProducto()
        {
            mProducto.id = ID;
            mProducto.nombre = INGnombre.Text.Trim();
            mProducto.marca = INGmarca.Text.Trim();
            mProducto.descripcion = INGdes.Text.Trim();
            mProducto.idF = int.Parse(INGcedula.Text.Trim());
            mProducto.precio = float.Parse(INGprecio.Text.Trim());
            mProducto.stock = int.Parse(INGstock.Text.Trim());
        }

        private void LimpiarCampos()
        {
            ID = 0 ;
            txtcodigo.Text = "";
            INGnombre.Text = "";
            INGmarca.Text = "";
            INGprecio.Text = "";
            INGcedula.Text = "";
            INGdes.Text = "";
            INGstock.Text = "";
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            FrmMenu go = new FrmMenu();
            this.Hide();
            go.Show();
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            ID = 0;
            txtcodigo.Text = "";
            INGnombre.Text = "";
            INGmarca.Text = "";
            INGprecio.Text = "";
            INGcedula.Text = "";
            INGdes.Text = "";
            INGstock.Text = "";

          
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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
        private void Productos_Click_1(object sender, EventArgs e)
        {
            Producto asd = new Producto();
            this.Hide();
            asd.Show();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Producto?", "Eliminar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    bool eliminado = mconsultas.eliminarProducto(ID);

                    if (eliminado)
                    {
                        MessageBox.Show("Producto eliminado correctamente", "Eliminación correcta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                    }

                    else
                    {
                        MessageBox.Show("Error al eliminar el producto", "Eliminación no ejecutada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar", "Sin registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

            private void Admin_Load(object sender, EventArgs e)
        {
            if(ID != 0)
            {
                txtcodigo.Text = ID.ToString();
                INGcedula.Text = Cedula2.ToString();
                INGnombre.Text = Nombre2.ToString();
                INGmarca.Text = Marca2.ToString();
                INGprecio.Text = Precio2.ToString();
                INGdes.Text = Descripcion2.ToString();
                INGstock.Text = Stock2.ToString();
            }
            else
            {
                txtcodigo.Text = "";
                INGnombre.Text = "";
                INGmarca.Text = "";
                INGprecio.Text = "";
                INGcedula.Text = "";
                INGdes.Text = "";
                INGstock.Text = "";
            }
        }
        public int cedula1;
        public string nombre1;
        private void Update_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            CargarDatosProducto();
            if (ID != 0)
            {
                if (mconsultas.UpdateProdu(mProducto))
                {
                    MessageBox.Show("Producto Actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Se Necesita un Codigo de producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgvprovee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvprovee.Rows[e.RowIndex];
            cedula1 = Convert.ToInt16(fila.Cells[0].Value);
            nombre1 = Convert.ToString(fila.Cells[1].Value);
            INGcedula.Text = cedula1.ToString();
        }
    }
}
