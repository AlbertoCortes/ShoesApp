namespace ShoesApp
{
    partial class UI_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtg_productos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_buscar_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_buscar_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bnt_agregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 56);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Image = global::ShoesApp.Properties.Resources.iconfinder_Delete_132192;
            this.btn_salir.Location = new System.Drawing.Point(747, 3);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 49);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dtg_productos
            // 
            this.dtg_productos.AllowUserToAddRows = false;
            this.dtg_productos.AllowUserToDeleteRows = false;
            this.dtg_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Ver,
            this.Editar,
            this.Eliminar});
            this.dtg_productos.Location = new System.Drawing.Point(12, 144);
            this.dtg_productos.Name = "dtg_productos";
            this.dtg_productos.ReadOnly = true;
            this.dtg_productos.RowTemplate.Height = 28;
            this.dtg_productos.Size = new System.Drawing.Size(802, 240);
            this.dtg_productos.TabIndex = 2;
            this.dtg_productos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_productos_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver detalles";
            this.Ver.Image = global::ShoesApp.Properties.Resources.iconfinder_View_132429;
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ShoesApp.Properties.Resources.iconfinder_Notes_132293;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::ShoesApp.Properties.Resources.iconfinder_Delete_132192;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // txt_buscar_name
            // 
            this.txt_buscar_name.Location = new System.Drawing.Point(87, 106);
            this.txt_buscar_name.Name = "txt_buscar_name";
            this.txt_buscar_name.Size = new System.Drawing.Size(265, 26);
            this.txt_buscar_name.TabIndex = 3;
            this.txt_buscar_name.TextChanged += new System.EventHandler(this.txt_buscar_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id:";
            // 
            // txt_buscar_id
            // 
            this.txt_buscar_id.Location = new System.Drawing.Point(577, 106);
            this.txt_buscar_id.Name = "txt_buscar_id";
            this.txt_buscar_id.Size = new System.Drawing.Size(112, 26);
            this.txt_buscar_id.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(704, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Ver detalles";
            this.dataGridViewImageColumn1.Image = global::ShoesApp.Properties.Resources.iconfinder_View_132429;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 108;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::ShoesApp.Properties.Resources.iconfinder_Notes_132293;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 109;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Eliminar";
            this.dataGridViewImageColumn3.Image = global::ShoesApp.Properties.Resources.iconfinder_Delete_132192;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 108;
            // 
            // bnt_agregar
            // 
            this.bnt_agregar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bnt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_agregar.ForeColor = System.Drawing.Color.White;
            this.bnt_agregar.Image = global::ShoesApp.Properties.Resources.iconfinder_Add_132496;
            this.bnt_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_agregar.Location = new System.Drawing.Point(631, 420);
            this.bnt_agregar.Name = "bnt_agregar";
            this.bnt_agregar.Size = new System.Drawing.Size(183, 69);
            this.bnt_agregar.TabIndex = 8;
            this.bnt_agregar.Text = "Nuevo Producto";
            this.bnt_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnt_agregar.UseVisualStyleBackColor = false;
            this.bnt_agregar.Click += new System.EventHandler(this.bnt_agregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ShoesApp.Properties.Resources.iconfinder_Add_132496;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(631, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "Agregar Imagen";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UI_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(826, 688);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bnt_agregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_buscar_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar_name);
            this.Controls.Add(this.dtg_productos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UI_principal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UI_principal_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtg_productos;
        private System.Windows.Forms.TextBox txt_buscar_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_buscar_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button bnt_agregar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button2;
    }
}

