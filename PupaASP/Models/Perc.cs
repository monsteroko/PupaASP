using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Perc
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int Level { get; set; }
        public int Number { get; set; }
        public string Effect { get; set; }
        public int PP { get; set; }
        public string Requirements { get; set; }
    }
}
