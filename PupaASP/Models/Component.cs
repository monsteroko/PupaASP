using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Component
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Alcali { get; set; }
        public int Organicum { get; set; }
        public int Tentatio { get; set; }
        public int Fortis { get; set; }
        public int Sommificus { get; set; }
        public int Exonero { get; set; }
    }
}
