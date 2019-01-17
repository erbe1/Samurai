using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Domain
{
    public class Battle
    {
        public int BattleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Brutal { get; set; }
        public DateTime BattleStart { get; set; }
        public DateTime BattleEnd { get; set; }

        public List<SamuraiBattle> SamuraiBattles { get; set; }

    }
}
