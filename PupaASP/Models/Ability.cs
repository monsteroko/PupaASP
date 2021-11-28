using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Ability
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Effect { get; set; }
        public int AP { get; set; }
        public double Range { get; set; }
        public string AttackType { get; set; }
        public string Damage { get; set; }
        public string Requirements { get; set; }
    }
}
