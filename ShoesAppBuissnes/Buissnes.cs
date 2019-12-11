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
    }
}
