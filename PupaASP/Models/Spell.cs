using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Spell
    {
        public int Id { get; set; }
        public int AbilityId { get; set; }
        public Ability Ability { get; set; }
        public int AP { get; set; }
        public int PP { get; set; }
        public ICollection<Item> Items { get; set; }
        public double Radius { get; set; }
        public double Area { get; set; }
    }
}
