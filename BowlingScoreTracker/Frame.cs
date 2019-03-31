using System;
using System.Collections;
using System.Collections.Generic;
using static BowlingScoreTracker.Enums;

namespace BowlingScoreTracker
{
    public class Frame
    {
        public MarkType MarkType { get; set; }
        public Dictionary<int, BitArray> Ball { get; set; }
        public Dictionary<int, BitArray> SecondBall { get; set; }
        public int? Score { get; set; }
        public List<BitArray> PinsKnockedDown { get; set; }
    }


}
