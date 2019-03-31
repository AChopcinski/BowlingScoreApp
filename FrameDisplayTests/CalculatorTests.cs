using System;
using System.Collections;
using System.Collections.Generic;
using BowlingScoreTracker;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FrameDisplayTests
{
    [TestClass]
    public class CalculatorTests
    {
        private FrameDisplay _frameDisplay;
        private BitArray onePins;
        private BitArray twoPins;

        private BitArray twoPinsTry;

        [TestInitialize]
        public void Setup()
        {
            _frameDisplay = new FrameDisplay();

            onePins = new BitArray(10);
            onePins.Set(0, true);

            twoPins = new BitArray(10);
            twoPins.Set(0, true);
            twoPins.Set(1, true);

            twoPinsTry = CreatePinFall(2);
        }
        
        private BitArray CreatePinFall(int pins)
        {
            BitArray pinsFelled = new BitArray(10);

            for (int i = 0; i < pins; i++)
            {
                pinsFelled.Set(i, true);
            }

            return pinsFelled;
        }

        [TestMethod]
        public void CalculateFirstFrameScoreReturnsFirstFrameScore_3_From_1and2()
        {
            
            Dictionary<int, BitArray> firstBall = new Dictionary<int, BitArray>();
           // Dictionary<int, BitArray> secondBall = new Dictionary<int, BitArray>();

            firstBall.Add(0, onePins);
          //  firstBall.Add(1, twoPins);

          //  firstBall.Add(1, twoPinsTry);

            firstBall.Add(1, CreatePinFall(2));


            List<BitArray> pinsKnockedDownOneFrame = new List<BitArray>();
            pinsKnockedDownOneFrame.Add(CreatePinFall(1));
            pinsKnockedDownOneFrame.Add(CreatePinFall(2));

            Frame frame = new Frame()
            {
                //MarkType = Enums.MarkType.Open,
                Ball = firstBall,
                PinsKnockedDown = pinsKnockedDownOneFrame
               // SecondBall = secondBall
                };


            var result = _frameDisplay.CalculateFrameScore(frame);

            Assert.AreEqual(3, result);
            
        }

        [TestMethod]
        public void CalculateGameScoreAddingTwoFramesNoMarks_8CountPlus7Count_Returns15()
        {
            List<BitArray> pinsKnockedDownOneFrame = new List<BitArray>();
            pinsKnockedDownOneFrame.Add(CreatePinFall(2));
            pinsKnockedDownOneFrame.Add(CreatePinFall(6));

            List<BitArray> pinsKnockedDownTwoFrame = new List<BitArray>();
            pinsKnockedDownTwoFrame.Add(CreatePinFall(3));
            pinsKnockedDownTwoFrame.Add(CreatePinFall(4));

            Frame firstFrame = new Frame()
            {
                PinsKnockedDown = pinsKnockedDownOneFrame,
                Score = null
            };

            Frame secondFrame = new Frame()
            {
                PinsKnockedDown = pinsKnockedDownTwoFrame,
                Score = null
            };

            List<Frame> testFrames = new List<Frame>();
            testFrames.Add(firstFrame);
            testFrames.Add(secondFrame);

            Game testGame = new Game()
            {
                Frames = testFrames,
                GameScore = 0
            };

            var result = _frameDisplay.CalcultateGameScore(testGame);

            Assert.AreEqual(15, result);
        }
    }
}
