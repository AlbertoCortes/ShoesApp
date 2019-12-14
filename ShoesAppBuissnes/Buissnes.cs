using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesAppEntities;
using ShoesAppData;

namespace ShoesAppBuissnes
{
    public class Buissnes
    {
        public List<Productos> SearchProductos(int id, string name)
        {
            return Data.SearchProducts(id, name);
        }

        public void InsertProductos(Productos prod)
        {
            Data.InsertProduct(prod);
        }
        public void InsertColor(Colores color)
        {
            Data.InsertColor(color);
        }
        
        public void InsertImages(Imagenes imag)
        {
            Data.InsertImages(imag);
        }

        public void InsertProductSize(TallaPorProducto size)
        {
            Data.InserSizeProduct(size);
        }

        public void UpdateProductos(Productos prod)
        {
            Data.UpdateProduct(prod);
        }

        public void DeleteProductos(int id)
        {
            Data.LogicalDelete(id);
        }

        public List<Colores> GetColores()
        {
            return Data.GetColors();
        }

        public int GetColorId(String nameIn)
        {
            List<Colores> ListaColores = new List<Colores>();
            ListaColores.AddRange(Data.GetColors());

            int Id = (from n in ListaColores
                     where n.Name == nameIn
                     select n.IdColor).FirstOrDefault();
            return Id;
        }
        public List<TallaPorProducto> GetTallaPorProductos(int id)
        {
            return Data.GetSizesForEachProduct(id);
        }


        public List<Tallas> GetTallas()
        {
            return Data.GetSizes();
        }

        public List<Imagenes> GetImagenes(int id)
        {
            return Data.GetImagenes(id);
        }
    }
}
