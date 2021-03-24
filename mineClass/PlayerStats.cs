using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mineClass
{
    public class PlayerStats : IComparable<PlayerStats>
    {
        public string initials { get; set; }
        public int level { get; set; }
        public string timeScore { get; set; }

        public PlayerStats(string initials, int level, string timeScore)
        {
            this.initials = initials;
            this.level = level;
            this.timeScore = timeScore;
        }

        public int CompareTo(PlayerStats other)
        {
            return this.timeScore.CompareTo(other.timeScore);
        }

        public override string ToString()
        {
            return "Initials: " + this.initials + ", Time: " + this.timeScore;
        }
    }
}
