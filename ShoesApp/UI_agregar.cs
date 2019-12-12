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
    public partial class UI_agregar : Form
    {
        Buissnes buissnes = new Buissnes();
        public UI_agregar()
        {
            InitializeComponent();
            fillCmbColors();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fillCmbColors()
        {
            List<Colores> colores = new List<Colores>();
            colores.AddRange(buissnes.GetColores());
            foreach (var item in colores)
            {
                cmb_color.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos {
                IdColor = buissnes.GetColorId(cmb_color.Text),
                Title = txt_nombre.Text,
                Nombre = txt_nombre.Text,
                Description = txt_descripcion.Text,
                Observations = txt_descripcion.Text,
                PriceDistributor = int.Parse(txt_precio_dist.Text),
                PriceClient = int.Parse(txt_precio_publico.Text),
                IsEnabled = true,
                DateUpdate = DateTime.Now

        };
            buissnes.InsertProductos(prod);
        }
    }
}
