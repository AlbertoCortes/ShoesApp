using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesAppEntities;
using ShoesAppBuissnes;

namespace ShoesApp
{
    public partial class UI_editar_producto : Form
    {
        Buissnes buissnes = new Buissnes();

        public int ID;
        public UI_editar_producto(int id)
        {
            InitializeComponent();
            ID = id;
        }


        List<Productos> producto = new List<Productos>();
        List<Colores> lista_colores = new List<Colores>();
        List<Tallas> lista_tallas = new List<Tallas>();

        public void fillData(int id)
        {

            producto.AddRange(buissnes.SearchProductos(id, null));
           // MessageBox.Show(id.ToString() + producto.FirstOrDefault().Nombre);
            txt_id.Text = producto.FirstOrDefault().Id.ToString();
            txt_nombre.Text = producto.FirstOrDefault().Nombre;
            txt_descripcion.Text = producto.FirstOrDefault().Description;
            txt_observaciones.Text = producto.FirstOrDefault().Observations;
            txt_precioDist.Text = producto.FirstOrDefault().PriceDistributor.ToString();
            txt_precioCli.Text = producto.FirstOrDefault().PriceClient.ToString();
            txt_precioEmp.Text = producto.FirstOrDefault().PriceMember.ToString();
            txt_habilitado.Text = producto.FirstOrDefault().IsEnabled.ToString();
            txt_fecha_modig.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lista_tallas.AddRange(buissnes.GetTallas());
            foreach (var item in lista_tallas)
            {
                cmb_tallas.Items.Add(item.Code);

            }

            lista_colores.AddRange(buissnes.GetColores());
            foreach (var item in lista_colores)
            {
                cmb_color.Items.Add(item.Name);
            }
        }

        private void UI_editar_producto_Load(object sender, EventArgs e)
        {
            fillData(ID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int id_color = 0;
                foreach (var item in lista_colores)
                {
                    if (item.Name == cmb_color.Text)
                    {
                        id_color = item.IdColor;
                    }
                }
                Productos prod = new Productos
                {
                    Id = int.Parse(txt_id.Text),
                    IdColor = id_color,
                    Title = txt_nombre.Text,
                    Nombre = txt_nombre.Text,
                    Description = txt_descripcion.Text,
                    Observations = txt_observaciones.Text,
                    PriceDistributor = decimal.Parse(txt_precioDist.Text),
                    PriceClient = decimal.Parse(txt_precioCli.Text),
                    IsEnabled = true,
                    PriceMember = decimal.Parse(txt_precioEmp.Text),
                    DateUpdate = DateTime.Now
                };

                buissnes.UpdateProductos(prod);
                MessageBox.Show("Producto modificado");
            }
            catch {
                MessageBox.Show("Error al modificar");
            }
            this.Close();
        }
    }
}
