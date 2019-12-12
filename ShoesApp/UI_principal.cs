using System;
using System.Windows.Forms;
using ShoesAppBuissnes;
using ShoesAppEntities;
using System.Collections.Generic;

namespace ShoesApp
{
    public partial class UI_principal : Form
    {
        Buissnes buissnes = new Buissnes(); 

        public int xClick = 0, yClick = 0;

        private void UI_principal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        public void buscar(int id, string name)
        {
            List<Productos> producto = new List<Productos>();
            producto.AddRange(buissnes.SearchProductos(id,name));
            fillGrid(producto);
        
            }

        private void txt_buscar_name_TextChanged(object sender, EventArgs e)
        {
            buscar(0, "%" + txt_buscar_name.Text + "%");
        }

        public void fillGrid(List <Productos> prod)
        {
            dtg_productos.Rows.Clear();
            foreach (var item in prod)
            {
                if (item.IsEnabled)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Description });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PriceClient });

                    dtg_productos.Rows.Add(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar((txt_buscar_id.Text=="") ? 0 : Int32.Parse(txt_buscar_id.Text), null);
        }

        private void UI_principal_Load(object sender, EventArgs e)
        {
            buscar(0, "%" + txt_buscar_name.Text + "%");
        }

        private void dtg_productos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                MessageBox.Show("Estoy en Editar");
            }
            else if(e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Eliminar producto", "Confirmar",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = Int32.Parse(dtg_productos.CurrentRow.Cells["Id"].Value.ToString());
                    buissnes.DeleteProductos(id);
                    MessageBox.Show("Producto Eliminado");
                }
            }
        }

        private void bnt_agregar_Click(object sender, EventArgs e)
        {
            UI_agregar frm_agregar = new UI_agregar();
            frm_agregar.Show();
        }

        public UI_principal()
        {
            InitializeComponent();
        }
    } 
}
