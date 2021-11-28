using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupaASP.Models
{
    public class Shield
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public bool IsHeavy { get; set; }
        public string Damage { get; set; }
        public int AC { get; set; }
        public string Requirements { get; set; }

    }
}
