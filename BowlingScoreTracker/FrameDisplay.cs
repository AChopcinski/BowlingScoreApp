using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScoreTracker
{
    public class FrameDisplay
    {
        public int CalculateFrameScore(Frame frame)
        {
            int ballOne = 0;
            int ballTwo = 0;

            foreach (bool ball in frame.PinsKnockedDown[0])
            {
                if (ball == true)
                {
                    ballOne = ballOne + 1;
                }
            }

            foreach (bool ball in frame.PinsKnockedDown[1])
            {
                if (ball == true)
                {
                    ballTwo = ballTwo + 1;
                }
            }

            int calculatedScore = ballOne + ballTwo;

            return calculatedScore; 
        }

        public int CalcultateGameScore(Game game)
        {
            var score = game.GameScore;
            foreach (var frame in game.Frames)
            {
                score = score + CalculateFrameScore(frame);
            }
            return score;
        }
    }
}
