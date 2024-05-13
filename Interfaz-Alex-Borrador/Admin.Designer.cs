
namespace Interfaz_Alex_Borrador
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Productos = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.INGcedula = new System.Windows.Forms.TextBox();
            this.INGstock = new System.Windows.Forms.TextBox();
            this.INGdes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.INGprecio = new System.Windows.Forms.TextBox();
            this.INGmarca = new System.Windows.Forms.TextBox();
            this.INGnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.dgvprovee = new System.Windows.Forms.DataGridView();
            this.ID_Provee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovee)).BeginInit();
            this.SuspendLayout();
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Productos.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.Location = new System.Drawing.Point(670, 570);
            this.Productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(149, 46);
            this.Productos.TabIndex = 63;
            this.Productos.Text = "Producto";
            this.Productos.UseVisualStyleBackColor = false;
            this.Productos.Click += new System.EventHandler(this.Productos_Click_1);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.agregar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(852, 570);
            this.agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(117, 46);
            this.agregar.TabIndex = 62;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 29);
            this.label8.TabIndex = 61;
            this.label8.Text = "Nombre del producto:";
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Limpiar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(1001, 570);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(117, 46);
            this.Limpiar.TabIndex = 60;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Menu.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(1149, 571);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(129, 46);
            this.Menu.TabIndex = 59;
            this.Menu.Text = "Regresar";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // INGcedula
            // 
            this.INGcedula.Enabled = false;
            this.INGcedula.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGcedula.Location = new System.Drawing.Point(1076, 241);
            this.INGcedula.Margin = new System.Windows.Forms.Padding(4);
            this.INGcedula.Multiline = true;
            this.INGcedula.Name = "INGcedula";
            this.INGcedula.Size = new System.Drawing.Size(163, 35);
            this.INGcedula.TabIndex = 50;
            // 
            // INGstock
            // 
            this.INGstock.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGstock.Location = new System.Drawing.Point(872, 311);
            this.INGstock.Margin = new System.Windows.Forms.Padding(4);
            this.INGstock.Multiline = true;
            this.INGstock.Name = "INGstock";
            this.INGstock.Size = new System.Drawing.Size(97, 35);
            this.INGstock.TabIndex = 51;
            // 
            // INGdes
            // 
            this.INGdes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGdes.Location = new System.Drawing.Point(776, 406);
            this.INGdes.Margin = new System.Windows.Forms.Padding(4);
            this.INGdes.Multiline = true;
            this.INGdes.Name = "INGdes";
            this.INGdes.Size = new System.Drawing.Size(491, 73);
            this.INGdes.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(771, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "stock: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(771, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 29);
            this.label6.TabIndex = 56;
            this.label6.Text = "Descripcion: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(771, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "Cedula del proveedor:";
            // 
            // INGprecio
            // 
            this.INGprecio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGprecio.Location = new System.Drawing.Point(359, 364);
            this.INGprecio.Margin = new System.Windows.Forms.Padding(4);
            this.INGprecio.Multiline = true;
            this.INGprecio.Name = "INGprecio";
            this.INGprecio.Size = new System.Drawing.Size(120, 35);
            this.INGprecio.TabIndex = 52;
            // 
            // INGmarca
            // 
            this.INGmarca.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGmarca.Location = new System.Drawing.Point(359, 312);
            this.INGmarca.Margin = new System.Windows.Forms.Padding(4);
            this.INGmarca.Multiline = true;
            this.INGmarca.Name = "INGmarca";
            this.INGmarca.Size = new System.Drawing.Size(271, 35);
            this.INGmarca.TabIndex = 53;
            // 
            // INGnombre
            // 
            this.INGnombre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGnombre.Location = new System.Drawing.Point(359, 242);
            this.INGnombre.Margin = new System.Windows.Forms.Padding(4);
            this.INGnombre.Multiline = true;
            this.INGnombre.Name = "INGnombre";
            this.INGnombre.Size = new System.Drawing.Size(391, 35);
            this.INGnombre.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 46);
            this.label1.TabIndex = 47;
            this.label1.Text = "Control de Inventariado";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1423, -1);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 28);
            this.button4.TabIndex = 64;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1375, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 28);
            this.button1.TabIndex = 65;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.LightGreen;
            this.Update.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(465, 570);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(169, 46);
            this.Update.TabIndex = 66;
            this.Update.Text = "Actualizar";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz_Alex_Borrador.Properties.Resources.ALEXNAFATESUPREMOMAYOR;
            this.pictureBox1.Location = new System.Drawing.Point(1200, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.Eliminar.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(294, 571);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(141, 46);
            this.Eliminar.TabIndex = 88;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 89;
            this.label2.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(220, 160);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(113, 29);
            this.txtcodigo.TabIndex = 90;
            // 
            // dgvprovee
            // 
            this.dgvprovee.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvprovee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprovee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Provee,
            this.Nombre});
            this.dgvprovee.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvprovee.Location = new System.Drawing.Point(766, 45);
            this.dgvprovee.Name = "dgvprovee";
            this.dgvprovee.RowHeadersWidth = 51;
            this.dgvprovee.RowTemplate.Height = 24;
            this.dgvprovee.Size = new System.Drawing.Size(375, 169);
            this.dgvprovee.TabIndex = 91;
            this.dgvprovee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprovee_CellClick);
            // 
            // ID_Provee
            // 
            this.ID_Provee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Provee.HeaderText = "ID_Proveedor";
            this.ID_Provee.MinimumWidth = 6;
            this.ID_Provee.Name = "ID_Provee";
            this.ID_Provee.Width = 124;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre Proveedor";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 144;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1468, 650);
            this.Controls.Add(this.dgvprovee);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.INGcedula);
            this.Controls.Add(this.INGstock);
            this.Controls.Add(this.INGdes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.INGprecio);
            this.Controls.Add(this.INGmarca);
            this.Controls.Add(this.INGnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.TextBox INGcedula;
        private System.Windows.Forms.TextBox INGstock;
        private System.Windows.Forms.TextBox INGdes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox INGprecio;
        private System.Windows.Forms.TextBox INGmarca;
        private System.Windows.Forms.TextBox INGnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.DataGridView dgvprovee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Provee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}