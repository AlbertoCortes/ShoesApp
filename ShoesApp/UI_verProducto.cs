using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesAppBuissnes;
using ShoesAppEntities;

namespace ShoesApp
{
    public partial class UI_verProducto : Form
    {
        Buissnes buissnes = new Buissnes();
        
        public int ID;
        public UI_verProducto(int id)
        {
            InitializeComponent();
            ID = id;
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream);
            mStream.Dispose();
            return bm;
        }

        private void UI_verProducto_Load(object sender, EventArgs e)
        {
            fillData(ID);
            fillImages();
        }
       

        public async void fillImages()
        {
            bool status = true;
            while (status)
            {
                List<Imagenes> lista_de_imagenes = new List<Imagenes>();
                lista_de_imagenes.AddRange(buissnes.GetImagenes(ID));
                foreach (var item in lista_de_imagenes)
                {
                    if (item.IdProduct == ID)
                    {
                        pictureBox1.Image = ByteToImage(item.Image);
                        await Task.Delay(3000);
                    }
                }
                if (lista_de_imagenes.Count == 0)
                    status = false;
            }
        }

        public void fillData(int id)
        {
            List<TallaPorProducto> tallas = new List<TallaPorProducto>();
            tallas.AddRange(buissnes.GetTallaPorProductos(id));
            List<Productos> producto = new List<Productos>();
            List<Colores> lista_colores = new List<Colores>();
            producto.AddRange(buissnes.SearchProductos(id, null));
            //MessageBox.Show(id.ToString() + producto.FirstOrDefault().Nombre);
            txt_id.Text = producto.FirstOrDefault().Id.ToString();
            if(tallas.FirstOrDefault() != null)
                cmb_tallas.Text = tallas.FirstOrDefault().Code;
            txt_nombre.Text = producto.FirstOrDefault().Nombre;
            txt_descripcion.Text = producto.FirstOrDefault().Description;
            txt_observaciones.Text = producto.FirstOrDefault().Observations;
            txt_precioDist.Text = producto.FirstOrDefault().PriceDistributor.ToString();
            txt_precioCli.Text = producto.FirstOrDefault().PriceClient.ToString();
            txt_precioEmp.Text = producto.FirstOrDefault().PriceMember.ToString();
            txt_habilitado.Text = producto.FirstOrDefault().IsEnabled.ToString();
            txt_fecha_modig.Text = producto.FirstOrDefault().DateUpdate.ToString();
            lista_colores.AddRange(buissnes.GetColores());
            foreach (var item in lista_colores)
            {
                if(item.IdColor == producto.FirstOrDefault().IdColor)
                {
                    txt_color.Text = item.Name;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
