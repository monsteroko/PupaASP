using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Bomb
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Damage { get; set; }
        public string Effect { get; set; }
    }
}
