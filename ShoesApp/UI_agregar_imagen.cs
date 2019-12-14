using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesAppEntities;
using ShoesAppBuissnes;
using System.Windows.Forms;
using System.IO;

namespace ShoesApp
{
    public partial class UI_agregar_imagen : Form
    {
        Buissnes buissnes = new Buissnes();
        
        public UI_agregar_imagen()
        {
            InitializeComponent();
        }


        private byte[] GetBytesFromImage(String imageFile)
        {
            MemoryStream ms = new MemoryStream();
            Image img = Image.FromFile(imageFile);
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }



        public void fillCmbProd()
        {
            List<Productos> lista_productos = new List<Productos>();
            lista_productos.AddRange(buissnes.SearchProductos(0, "%%"));

            foreach (var item in lista_productos)
            {
                if(item.IsEnabled)
                    cmb_producto.Items.Add(item.Nombre);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_imagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Selecciona una imagen.";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imgUrl = @openFileDialog1.FileName;
                pictureBox1.ImageLocation = imgUrl;
                txt_image.Text = imgUrl;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Productos> lista_productos = new List<Productos>();
                lista_productos.AddRange(buissnes.SearchProductos(0, "%%"));
                int id = 0;
                foreach (var item in lista_productos)
                {
                    if (item.Nombre == cmb_producto.Text)
                        id = item.Id;

                }
                Imagenes imagen = new Imagenes
                {
                    IdProduct = id,
                    Decription = txt_desc.Text,
                    Image = GetBytesFromImage(txt_image.Text),
                    DateUpdate = DateTime.Now,
                    IsEnabled = true

                };

                buissnes.InsertImages(imagen);
                MessageBox.Show("Imagen Agregada");
            }
            catch { MessageBox.Show("Error al agregar imagen"); }

            this.Close();
        
        }

        private void UI_agregar_imagen_Load(object sender, EventArgs e)
        {
            fillCmbProd();
        }
    }

}
