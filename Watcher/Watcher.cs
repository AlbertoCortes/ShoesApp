using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoesAppData;
using ShoesAppEntities;

using ShoesAppCommon;

namespace Watcher
{
    class Watcher
    {
        public static async void WatcherProducts()
        {
            List<Log> log = Data.Watcher();
            int current_id = (from l in log orderby l.idLog descending select l.idLog).First();
            Console.WriteLine("Monitoreando la base de datos");
            while (true)
            {
                Console.Write(".");
                List<Log> logaux = Data.Watcher();
                var aux_id = (from l in logaux orderby l.idLog descending select l).First(); 
                if(aux_id.idLog > current_id)
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
                            break;
                        case 3:
                            Console.WriteLine("Se ha Modificado un producto");
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



        }

        public void UpdatePXML(Productos prod)
        {
        }

        public void DeletePXML()
        {

        }

        public static void Main(string[] args)
        {
            List<Productos> prod = Data.SearchProducts(0,"%%");
            InizializeXML(prod);
            WatcherProducts();
            Console.ReadLine();
            //Data.Watcher();
        }
    }
}
