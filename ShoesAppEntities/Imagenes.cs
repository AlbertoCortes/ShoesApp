using System;
namespace ShoesAppEntities
{
    public class Imagenes
    {
        public int IdImage { get; set; }
        public int IdProduct { get; set; }
        public string Decription { get; set; }
        public byte[] Image { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public string IsEnabled { get; set; }

    }
}
