using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesAppEntities
{
    public class Log
    {
        public int idLog { set; get; }
        public int idProduct { set; get; }
        public byte? ActionMade { set; get; }
    }
}
