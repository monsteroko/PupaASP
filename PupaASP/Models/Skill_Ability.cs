using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Skill_Ability
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
