
namespace Interfaz_Alex_Borrador
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Informacion = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.Venta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Admini = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Informacion
            // 
            this.Informacion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Informacion.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacion.Location = new System.Drawing.Point(121, 558);
            this.Informacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(319, 58);
            this.Informacion.TabIndex = 0;
            this.Informacion.Text = "INFORMACIÓN\r\n";
            this.Informacion.UseVisualStyleBackColor = false;
            this.Informacion.Click += new System.EventHandler(this.Empleado_Click);
            // 
            // Cliente
            // 
            this.Cliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cliente.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(46, 263);
            this.Cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(319, 58);
            this.Cliente.TabIndex = 2;
            this.Cliente.Text = "CLIENTES";
            this.Cliente.UseVisualStyleBackColor = false;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // Producto
            // 
            this.Producto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Producto.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Producto.Location = new System.Drawing.Point(121, 156);
            this.Producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(319, 62);
            this.Producto.TabIndex = 3;
            this.Producto.Text = "PRODUCTOS";
            this.Producto.UseVisualStyleBackColor = false;
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // Venta
            // 
            this.Venta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Venta.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venta.Location = new System.Drawing.Point(46, 465);
            this.Venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(319, 59);
            this.Venta.TabIndex = 4;
            this.Venta.Text = "VENTAS";
            this.Venta.UseVisualStyleBackColor = false;
            this.Venta.Click += new System.EventHandler(this.Venta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1373, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1421, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Admini
            // 
            this.Admini.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Admini.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admini.Location = new System.Drawing.Point(46, 50);
            this.Admini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admini.Name = "Admini";
            this.Admini.Size = new System.Drawing.Size(343, 55);
            this.Admini.TabIndex = 8;
            this.Admini.Text = "ADMINISTRADOR";
            this.Admini.UseVisualStyleBackColor = false;
            this.Admini.Click += new System.EventHandler(this.Admini_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz_Alex_Borrador.Properties.Resources.ALEXNAFATESUPREMOMAYOR;
            this.pictureBox1.Location = new System.Drawing.Point(468, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(121, 363);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(319, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "PROVEEDORES";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1468, 650);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Admini);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Venta);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.Informacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Informacion;
        private System.Windows.Forms.Button Cliente;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Venta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Admini;
        private System.Windows.Forms.Button button3;
    }
}

