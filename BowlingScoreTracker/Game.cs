using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScoreTracker
{
    public class Game
    {
        public int GameNumber { get; set; }
        public List<Frame> Frames { get; set; }
        public int GameScore { get; set; }
        public int ScratchScore { get; set; }
        public int HandicapAmount { get; set; }
    }
}
