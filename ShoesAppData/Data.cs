using ShoesAppCommon;
using ShoesAppEntities;
using System.Collections.Generic;
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

        public static List<Colores> GetColors()
        {
            var obj = model.ACOB_GetColors();
            return Common.SerializeJson<IEnumerable<ACOB_GetColors_Result>, List<Colores>>(obj);
        }

        public static List<Tallas> GetSizes()
        {
            var obj = model.ACOB_GetSizes();
            return Common.SerializeJson<IEnumerable<ACOB_GetSizes_Result>,List<Tallas>>(obj);
        }


        public static void InsertProduct(Productos prod)
        { 

            model.ACOB_InsertProduct(
                prod.IdType,
                prod.IdColor,
                prod.IdBrand,
                prod.IdProvider,
                prod.IdCatalog,
                prod.Title,
                prod.Nombre,
                prod.Description,
                prod.Observations,
                prod.PriceDistributor,
                prod.PriceClient,
                prod.PriceMember,
                prod.IsEnabled,
                prod.Keywords,
                prod.DateUpdate
                );
        }

    public static void UpdateProduct(Productos prod)
    {
        model.ACOB_UpdateProduct(
            prod.Id,
            prod.IdType,
            prod.IdColor,
            prod.IdBrand,
            prod.IdProvider,
            prod.IdCatalog,
            prod.Title,
            prod.Nombre,
            prod.Description,
            prod.Observations,
            prod.PriceDistributor,
            prod.PriceClient,
            prod.PriceMember,
            prod.IsEnabled,
            prod.Keywords,
            prod.DateUpdate
            );
    }

    public static void LogicalDelete(int id)
    {
        model.ACOB_DeleteProd(id);
    }



}
}
