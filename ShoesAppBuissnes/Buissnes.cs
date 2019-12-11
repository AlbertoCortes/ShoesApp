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

        public void UpdateProductos(Productos prod)
        {
            Data.UpdateProduct(prod);
        }

        public void DeleteProductos(int id)
        {
            Data.LogicalDelete(id);
        }
    }
}
