using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Material { get; set; }
        public string Stat { get; set; }
        public int AC { get; set; }
        public string Damage { get; set; }
        public string Effect { get; set; }
        public string Type { get; set; }
        public string Skill_Type { get; set; }
    }
}
