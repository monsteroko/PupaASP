using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Context : DbContext
    {
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Bomb> Bombs { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Perc> Percs { get; set; }
        public DbSet<Potion> Potions { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Shield> Shields { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillAbility> SkillAbilities { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
