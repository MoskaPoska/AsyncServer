using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodLibrary
{
    public class Good
    {      
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Producer { get; set; }
        public override string ToString()
        {
            return $"{Name}, {Price}, {Producer}";
        }
    }
}

