using ShoesAppBuissnes;
using ShoesAppEntities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShoesApp
{
    public partial class IU_agregar_color : Form
    {
        public IU_agregar_color()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_hexa.Text = "#"+(colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                panel2.BackColor = Color.FromArgb(colorDialog1.Color.ToArgb()); ; 
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Colores color = new Colores
                {
                    Name = txt_name.Text,
                    Description = txt_desc.Text,
                    HexaDecimal = lbl_hexa.Text,
                    IsEnable = true

                };
                Buissnes buis = new Buissnes();
                buis.InsertColor(color);
                MessageBox.Show("Color agregado");
            }
            catch {

                MessageBox.Show("Error al crear color");
            }
            this.Close();
        }
    }
}
