using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesAppBuissnes;
using ShoesAppEntities;

namespace ShoesAppTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Productos> lista = new List<Productos>();
            Buissnes n = new Buissnes();
            lista = n.SearchProductos(0, "p");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nombre);
            }
            Console.ReadLine();

        }
    }
}
