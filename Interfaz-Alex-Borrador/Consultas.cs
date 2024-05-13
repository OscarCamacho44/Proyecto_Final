
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Alex_Borrador
{
    internal class Consultas
    {
        private ConexionMYSQL union;
        private List<Productos1> mProductos;
        private List<Clientes1> mcliente;
        private List<Proveedores1> mprovee;
        private List<venta1> mVenta;

        public Consultas()
        {
            union = new ConexionMYSQL();
            mProductos = new List<Productos1>();
            mcliente = new List<Clientes1>();
            mprovee = new List<Proveedores1>();
            mVenta = new List<venta1>();
        }

       

        public List<Productos1> getProductos(object filtro)
        {
            string QUERY = "SELECT * FROM producto ";
            MySqlDataReader Reader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += "WHERE " +
                        "codigo LIKE '%" + filtro + "%' OR " +
                        "cedula LIKE '%" + filtro + "%' OR " +
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "marca LIKE '%" + filtro + "%' OR " +
                        "descripcion LIKE '%" + filtro + "%' OR " +
                        "precio LIKE '%" + filtro + "%' OR " +
                        "stock LIKE '%" + filtro + "%' ;";
                }
                
                MySqlCommand mcomando = new MySqlCommand(QUERY);
                mcomando.Connection = union.GetConnection();
                Reader = mcomando.ExecuteReader();
                Productos1 mproducto = null;
                
                while (Reader.Read())
                {
                    mproducto = new Productos1();
                    mproducto.id = Reader.GetInt16("codigo");
                    mproducto.idF = Reader.GetInt16("cedula");
                    mproducto.nombre = Reader.GetString("nombre");
                    mproducto.marca = Reader.GetString("marca");
                    mproducto.descripcion = Reader.GetString("descripcion");
                    mproducto.precio = Reader.GetUInt16("precio");
                    mproducto.stock = Reader.GetUInt16("stock");
                    mProductos.Add(mproducto);
                }
                Reader.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error de consulta.");
            }
            return mProductos;
        }

        internal List<Proveedores1> verproveedor(object filtro)
        {
            string QUERT = "SELECT * FROM proveedor ";
            MySqlDataReader Read = null;
            try
            {
                if (filtro != "")
                {
                    QUERT += "WHERE " +
                        "cedula LIKE '%" + filtro + "%' OR " +
                        "Nombre LIKE '%" + filtro + "%' OR " +
                        "APE_paterno LIKE '%" + filtro + "%' OR " +
                        "APE_materno LIKE '%" + filtro + "%' OR " +
                        "direccion LIKE '%" + filtro + "%' OR " +
                        "celular LIKE '%" + filtro + "%'  ";
                }
                MySqlCommand mcomando = new MySqlCommand(QUERT);
                mcomando.Connection = union.GetConnection();
                Read = mcomando.ExecuteReader();
                Proveedores1 mproveedor = null;
                while (Read.Read())
                {
                    mproveedor = new Proveedores1();
                    mproveedor.cedula = Read.GetInt16("cedula");
                    mproveedor.Nombre = Read.GetString("Nombre");
                    mprovee.Add(mproveedor);
                }
                Read.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR de Conexión");
            }
            return mprovee;
        }

        internal List<venta1> getventa(object filtro)
        {
            string QUERY = "SELECT * FROM venta ";
            MySqlDataReader Reader = null;
            try 
            { 
                if (filtro != "")
                {
                    QUERY += "WHERE " +
                        "id_venta LIKE '%" + filtro + "%' OR " +
                        "id_cliente LIKE '%" + filtro + "%' OR " +
                        "id_producto LIKE '%" + filtro + "%' OR " +
                        "nombre_p LIKE '%" + filtro + "%' OR " +
                        "cantidad LIKE '%" + filtro + "%' OR " +
                        "fecha LIKE '%" + filtro + "%' ;";
                }
                MySqlCommand mcomando = new MySqlCommand(QUERY);
                mcomando.Connection = union.GetConnection();
                Reader = mcomando.ExecuteReader();
                venta1 mventa1 = null;

                while (Reader.Read())
                {
                    mventa1 = new venta1();
                    mventa1.id_venta = Reader.GetInt16("id_venta");
                    mventa1.id_cliente = Reader.GetInt16("id_cliente");
                    mventa1.id_producto = Reader.GetInt16("id_producto");
                    mventa1.nombre = Reader.GetString("nombre_p");
                    mventa1.cantidad = Reader.GetInt16("cantidad");
                    mventa1.fecha = Reader.GetDateTime("fecha");
                    mVenta.Add(mventa1);
                }
                Reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de consulta.");
            }
            return mVenta;
        }

        internal List<Proveedores1> getproveedor(object filtro)
        {
                string QUERY = "SELECT * FROM proveedor ";
                MySqlDataReader Read = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += "WHERE " +
                        "cedula LIKE '%" + filtro + "%' OR " +
                        "Nombre LIKE '%" + filtro + "%' OR " +
                        "APE_paterno LIKE '%" + filtro + "%' OR " +
                        "APE_materno LIKE '%" + filtro + "%' OR " +
                        "direccion LIKE '%" + filtro + "%' OR " +
                        "celular LIKE '%" + filtro + "%'  ";
                }
                MySqlCommand mcomando = new MySqlCommand(QUERY);
                mcomando.Connection = union.GetConnection();
                Read = mcomando.ExecuteReader();
                Proveedores1 mproveedor = null;
                while (Read.Read())
                {
                    mproveedor = new Proveedores1();
                    mproveedor.cedula = Read.GetInt16("cedula");
                    mproveedor.Nombre = Read.GetString("Nombre");
                    mproveedor.APE_paterno = Read.GetString("APE_paterno");
                    mproveedor.APE_materno = Read.GetString("APE_materno");
                    mproveedor.direccion = Read.GetString("direccion");
                    mproveedor.celular = Read.GetInt64("celular");
                    mprovee.Add(mproveedor);
                }
                Read.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error de consulta.");
            }
            return mprovee;
        }

        internal bool addcompra(venta1 mventa)
        {
            string INSERT1 = "INSERT INTO venta (id_cliente, id_producto, nombre_p, cantidad, fecha) values(@idc, @idp, @name, @canti, @date);";

            MySqlCommand mComando = new MySqlCommand(INSERT1, union.GetConnection());
            mComando.Parameters.Add(new MySqlParameter("@idc", variableglobal.idCliente)); ;
            mComando.Parameters.Add(new MySqlParameter("@idp", mventa.id_producto));
            mComando.Parameters.Add(new MySqlParameter("@name", mventa.nombre));
            mComando.Parameters.Add(new MySqlParameter("@canti", mventa.cantidad));
            mComando.Parameters.Add(new MySqlParameter("@date", mventa.fecha));
            return mComando.ExecuteNonQuery() > 0;
        }

        internal bool añadircompra(int var, int id)
        {
            string AÑADIR = "UPDATE producto set stock = stock- @var Where codigo = @id;";
            MySqlCommand mComando = new MySqlCommand(AÑADIR, union.GetConnection());

            mComando.Parameters.Add(new MySqlParameter("@var", var));
            mComando.Parameters.Add(new MySqlParameter("@id", id));
            return mComando.ExecuteNonQuery() > 0;
        }

        internal bool agregaproveedor(Proveedores1 mproveedor)
        {
            string INSERT1 = "INSERT INTO proveedor (Nombre, APE_paterno, APE_materno, Direccion, celular) values(@nom, @app, @apm, @dire, @cell);";

            MySqlCommand mComando = new MySqlCommand(INSERT1, union.GetConnection());

            mComando.Parameters.Add(new MySqlParameter("@nom", mproveedor.Nombre));
            mComando.Parameters.Add(new MySqlParameter("@app", mproveedor.APE_paterno));
            mComando.Parameters.Add(new MySqlParameter("@apm", mproveedor.APE_materno));
            mComando.Parameters.Add(new MySqlParameter("@dire", mproveedor.direccion));
            mComando.Parameters.Add(new MySqlParameter("@cell", mproveedor.celular));
            return mComando.ExecuteNonQuery() > 0;
        }

        public List<Clientes1> GetCliente(object filtro1)
        {
            string QUERY1 = "SELECT * FROM cliente ";
            MySqlDataReader Read = null;
            try
            {
                if (filtro1 != "")
                {
                    QUERY1 += "WHERE " +
                        "id_cliente LIKE '%" + filtro1 + "%' OR " +
                        "nombre LIKE '%" + filtro1 + "%' OR " +
                        "ape_paterno LIKE '%" + filtro1 + "%' OR " +
                        "ape_materno LIKE '%" + filtro1 + "%' OR " +
                        "contrasena LIKE '%" + filtro1 + "%' OR " +
                        "celular LIKE '%" + filtro1 + "%' OR " +
                        "direccion LIKE '%" + filtro1 + "%' ;";
                }
                MySqlCommand mcomando = new MySqlCommand(QUERY1);
                mcomando.Connection = union.GetConnection();
                Read = mcomando.ExecuteReader();
                Clientes1 mproducto2 = null;
                while (Read.Read())
                {
                    mproducto2 = new Clientes1();
                    mproducto2.ID = Read.GetInt16("id_cliente");
                    mproducto2.nombre = Read.GetString("nombre");
                    mproducto2.ape_pate = Read.GetString("ape_paterno");
                    mproducto2.ape_mate = Read.GetString("ape_materno");
                    mproducto2.contrasena = Read.GetString("contrasena");
                    mproducto2.celular = Read.GetInt64("celular");
                    mproducto2.direccion = Read.GetString("direccion");
                    mcliente.Add(mproducto2);
                }
                Read.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de consulta.");
            }

            return mcliente;
        }

        internal bool UpdateProdu(Productos1 Producto2)        
        {
            
                string UPDATE = "UPDATE producto SET " +
                                        "cedula=@cedula, " +
                                        "Nombre=@name, " +
                                        "marca=@marca, " +
                                        "descripcion=@desc, " +
                                        "precio=@precio, " +
                                        "stock=@stock " +
                                        "WHERE codigo=@id;";

                MySqlCommand command = new MySqlCommand(UPDATE, union.GetConnection());

                command.Parameters.Add(new MySqlParameter("@cedula", Producto2.idF));
                command.Parameters.Add(new MySqlParameter("@name", Producto2.nombre));
                command.Parameters.Add(new MySqlParameter("marca", Producto2.marca));
                command.Parameters.Add(new MySqlParameter("@desc", Producto2.descripcion));
                command.Parameters.Add(new MySqlParameter("@precio", Producto2.precio));
                command.Parameters.Add(new MySqlParameter("@stock", Producto2.stock));
                command.Parameters.Add(new MySqlParameter("@id", Producto2.id));
                return command.ExecuteNonQuery() > 0;
            
        }

        internal bool eliminarproveedor(Proveedores1 mProveedor)
        {
            try
            {
                string DELETE = "DELETE FROM proveedor WHERE cedula=@id;";

                MySqlCommand command = new MySqlCommand(DELETE, union.GetConnection());

                command.Parameters.Add(new MySqlParameter("@id", mProveedor.cedula));
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar al proveedor.");
                return false;
            }
        }

        internal bool Modificarproveedor(Proveedores1 mProveedor)
        {
            
                    string UPDATE = "UPDATE proveedor SET " +
                                    "Nombre=@nombre, " +
                                    "APE_paterno=@app, " +
                                    "APE_materno=@apm, " +
                                    "direccion=@direccion, " +
                                    "celular=@cell " +
                                    "WHERE cedula=@id;";

            MySqlCommand command = new MySqlCommand(UPDATE, union.GetConnection());
                    
                        command.Parameters.Add(new MySqlParameter("@nombre", mProveedor.Nombre));
                        command.Parameters.Add(new MySqlParameter("@app", mProveedor.APE_paterno));
                        command.Parameters.Add(new MySqlParameter("@apm", mProveedor.APE_materno));
                        command.Parameters.Add(new MySqlParameter("@direccion", mProveedor.direccion));
                        command.Parameters.Add(new MySqlParameter("@cell", mProveedor.celular));
                        command.Parameters.Add(new MySqlParameter("@id", mProveedor.cedula));
                        return command.ExecuteNonQuery() > 0;
                        
        }

        internal bool addcliente(Clientes1 mcliente)
        {
            
                string INSERT1 = "INSERT INTO cliente (nombre, ape_paterno, ape_materno, contrasena, celular, direccion) values(@nombre, @app, @apm, @contra, @cell, @direc);";

                MySqlCommand mComando = new MySqlCommand(INSERT1, union.GetConnection());

                mComando.Parameters.Add(new MySqlParameter("@nombre", mcliente.nombre));
                mComando.Parameters.Add(new MySqlParameter("@app", mcliente.ape_pate));
                mComando.Parameters.Add(new MySqlParameter("@apm", mcliente.ape_mate));
                mComando.Parameters.Add(new MySqlParameter("@contra", mcliente.contrasena));
                mComando.Parameters.Add(new MySqlParameter("@cell", mcliente.celular));
                mComando.Parameters.Add(new MySqlParameter("@direc", mcliente.direccion));
            return mComando.ExecuteNonQuery() > 0;
            
        }

        internal bool agregarProducto(Productos1 mproducto)
        {
            try
            {
                string INSERT = "INSERT INTO producto(nombre, marca, descripcion, precio, stock, cedula) values(@nombre, @marca, @descripcion, @precio, @stock, @cedula);";

                MySqlCommand mComando = new MySqlCommand(INSERT, union.GetConnection());

                mComando.Parameters.Add(new MySqlParameter("@nombre", mproducto.nombre));
                mComando.Parameters.Add(new MySqlParameter("@marca", mproducto.marca));
                mComando.Parameters.Add(new MySqlParameter("@descripcion", mproducto.descripcion));
                mComando.Parameters.Add(new MySqlParameter("@precio", mproducto.precio));
                mComando.Parameters.Add(new MySqlParameter("@stock", mproducto.stock));
                mComando.Parameters.AddWithValue("@cedula", mproducto.idF);
                return mComando.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Numero de cedula incorrecto.");
                return false;
            }

        }
        internal bool eliminarProducto(int idproducto)
        {
            
                string DELETE = "DELETE FROM producto WHERE codigo = @id_producto;";

                MySqlCommand mComando = new MySqlCommand(DELETE, union.GetConnection());

                mComando.Parameters.Add(new MySqlParameter("@id_producto", idproducto));
                return mComando.ExecuteNonQuery() > 0;
            
            
        }
        


    }
    
}        





