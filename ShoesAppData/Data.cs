
using ShoesAppCommon;
using ShoesAppEntities;
using System.Linq;
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

        public static List<TallaPorProducto> GetSizesForEachProduct(int id) {
            var obj = model.ACOB_GetSizeForEachProduct(id);
            return Common.SerializeJson<IEnumerable<ACOB_GetSizeForEachProduct_Result>, List<TallaPorProducto>>(obj);
        }

        public static void InsertImages(Imagenes imag)
        {
            model.ACOB_InsertImages(
                imag.IdProduct,
                imag.Decription,
                imag.Image,
                imag.DateUpdate,
                imag.IsEnabled
                );
        }
        public static void InsertColor(Colores color) {
            model.ACOB_InsertColor(

                color.Name,
                color.Description,
                color.HexaDecimal,
                color.IsEnable
                );
        }
        public static void InserSizeProduct(TallaPorProducto talla)
        {
            model.ACOB_InsertSizeProduct(talla.IdProduct, int.Parse(talla.Code));
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

    public static List<Imagenes> GetImagenes(int id)
        {
            var obj = model.ACOB_GetImages(id);
            return Common.SerializeJson<IEnumerable<ACOB_GetImages_Result>, List<Imagenes>>(obj);
        }

        public static List<Log> Watcher()
        {
            //List<Log> log = new List<Log>();
            var ll = from m in model.ChangesOnProducts select m;
            // log.AddRange(ll);
            return Common.SerializeJson<IEnumerable<ChangesOnProduct>, List<Log>>(ll);
        }
}
}
