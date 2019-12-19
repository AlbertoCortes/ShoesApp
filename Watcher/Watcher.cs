using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoesAppData;
using ShoesAppEntities;
using ShoesAppCommon;
using System.Xml.Linq;

namespace Watcher
{
    class Watcher
    {
        public static string path = $@"C:\Users\Curso\Documents\Academia\ShoesApp\Watcher\XML/Productos.xml";
        public static async void WatcherProducts()
        {
            List<Log> log = Data.Watcher();
            int current_id = (from l in log orderby l.idLog descending select l.idLog).First();
            Console.WriteLine("Monitoreando la base de datos");
            while (true)
            {
                List<Log> logaux = Data.Watcher();
                var aux_id = (from l in logaux orderby l.idLog descending select l).First();
                if (aux_id.idLog > current_id)
                {
                    List<Productos> productos = Data.SearchProducts(aux_id.idProduct, null);
                    Console.WriteLine("la tabla ha cambiado ");
                    switch (aux_id.ActionMade)
                    {
                        case 1:
                            Console.WriteLine("Se ha insertado un nuevo producto");
                            InsertPXML(productos.FirstOrDefault());
                            break;
                        case 2:
                            Console.WriteLine("Se ha Eliminado un producto");
                            DeletePXML(aux_id.idProduct);
                            break;
                        case 3:
                            Console.WriteLine("Se ha Modificado un producto");
                            UpdatePXML(productos.FirstOrDefault());
                            break;
                    }
                    current_id = aux_id.idLog;
                }
                await Task.Delay(100);
            }
        }
        public static void InizializeXML(List<Productos> prod)
        {
            Common.SerializeToXml<List<Productos>>(prod);
        }

        public static void InsertPXML(Productos prod)
        {
            XElement docXML = XElement.Load(path);
            XElement nuevo_prod = new XElement("Productos",
                new XElement("Id", prod.Id),
                new XElement("IdType", prod.IdType),
                new XElement("IdColor", prod.IdColor),
                new XElement("IdBrand", prod.IdBrand),
                new XElement("IdProvider", prod.IdProvider),
                new XElement("IdCatalog", prod.IdCatalog),
                new XElement("Title", prod.Title),
                new XElement("Nombre", prod.Nombre),
                new XElement("Descrpition", prod.Description),
                new XElement("Observations", prod.Observations),
                new XElement("PriceDistribuitor", prod.PriceDistributor),
                new XElement("PriceClient", prod.PriceClient),
                new XElement("PriceMember", prod.PriceMember),
                new XElement("IsEnabled", prod.IsEnabled),
                new XElement("Keywords", prod.Keywords),
                new XElement("DateUpdate", prod.DateUpdate)
                );
            docXML.Add(nuevo_prod);
            docXML.Save(path);
        }

        public static void UpdatePXML(Productos prod)
        {
            var doc = XDocument.Load(path);
            var node = doc.Descendants("Productos").FirstOrDefault(cd => cd.Element("Id").Value == prod.Id.ToString());
            node.SetElementValue("Id", prod.Id);
            node.SetElementValue("IdType", prod.IdType);
            node.SetElementValue("IdColor", prod.IdColor);
            node.SetElementValue("IdBrand", prod.IdBrand);
            node.SetElementValue("IdProvider", prod.IdProvider);
            node.SetElementValue("IdCatalog", prod.IdCatalog);
            node.SetElementValue("Title", prod.Title);
            node.SetElementValue("Nombre", prod.Nombre);
            node.SetElementValue("Descrpition", prod.Description);
            node.SetElementValue("Observations", prod.Observations);
            node.SetElementValue("PriceDistribuitor", prod.PriceDistributor);
            node.SetElementValue("PriceClient", prod.PriceClient);
            node.SetElementValue("PriceMember", prod.PriceMember);
            node.SetElementValue("IsEnabled", prod.IsEnabled);
            node.SetElementValue("Keywords", prod.Keywords);
            node.SetElementValue("DateUpdate", prod.DateUpdate);
            doc.Save(path);
        }

        public static void DeletePXML(int id)
        {
            var doc = XDocument.Load(path);
            doc.Descendants("Productos").FirstOrDefault(cd => cd.Element("Id").Value == id.ToString()).Remove();
            doc.Save(path);
        }

        public static void Main(string[] args)
        {
            List<Productos> prod = Data.SearchProducts(0, "%%");
            InizializeXML(prod);
            WatcherProducts();
            Console.ReadLine();
        }
    }
}
