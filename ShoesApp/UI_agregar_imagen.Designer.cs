namespace ShoesApp
{
    partial class UI_agregar_imagen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_producto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.btn_buscar_imagen = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(60, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(175, 147);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(454, 85);
            this.txt_desc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto:";
            // 
            // cmb_producto
            // 
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(175, 85);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Size = new System.Drawing.Size(454, 28);
            this.cmb_producto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(60, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Imagen:";
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(175, 260);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(351, 26);
            this.txt_image.TabIndex = 7;
            // 
            // btn_buscar_imagen
            // 
            this.btn_buscar_imagen.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_buscar_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_imagen.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_imagen.Location = new System.Drawing.Point(533, 260);
            this.btn_buscar_imagen.Name = "btn_buscar_imagen";
            this.btn_buscar_imagen.Size = new System.Drawing.Size(96, 26);
            this.btn_buscar_imagen.TabIndex = 8;
            this.btn_buscar_imagen.Text = "Buscar";
            this.btn_buscar_imagen.UseVisualStyleBackColor = false;
            this.btn_buscar_imagen.Click += new System.EventHandler(this.btn_buscar_imagen_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Image = global::ShoesApp.Properties.Resources.iconfinder_Add_132496;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(489, 330);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(140, 64);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Agregar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::ShoesApp.Properties.Resources.iconfinder_Delete_132192;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(328, 330);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 64);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(64, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // UI_agregar_imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(669, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_buscar_imagen);
            this.Controls.Add(this.txt_image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_agregar_imagen";
            this.Text = "UI_agregar_imagen";
            this.Load += new System.EventHandler(this.UI_agregar_imagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.Button btn_buscar_imagen;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}