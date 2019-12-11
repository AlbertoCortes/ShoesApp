using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesAppEntities;
using ShoesAppCommon;
namespace ShoesAppData
{
    public class Data
    {
        static DataProductsEntities model = new DataProductsEntities();

        public static List<Productos> SearchProducts(int id, string name)
        {
            var obj = model.ACOB_SearchByIdOrName(id, name);
            return Common.SerializeJson<IEnumerable<ACOB_SearchByIdOrName_Result>, List<Productos>>(obj);
        }


    }
}
