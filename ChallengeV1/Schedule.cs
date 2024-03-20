using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeV1
{
    public class Schedule
    {
        public Dictionary<string, YearData> Years { get; set; }
        public double DefaultMarketRatio { get; set; }
        public double DefaultAuctionRatio { get; set; }
    }
}
