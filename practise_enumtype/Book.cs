using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_enumtype
{
    internal sealed class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public Author? author { get; set; }
    }
}
