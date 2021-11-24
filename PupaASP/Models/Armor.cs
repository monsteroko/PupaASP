using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Armor
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public bool IsHeavy { get; set; }
        public int AC { get; set; }
        public string Effect { get; set; }
    }
}
