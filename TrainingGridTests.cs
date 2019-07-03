using BowlingScoreTracker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameDisplayTests
{
    [TestClass]
    public class TrainingGridTests
    {
        private TrainingGridCreator _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new TrainingGridCreator();

        }


        [TestMethod]
        public void CreateGridWordWordWord_Returns3By3Grid()
        {
            var result = _sut.CreateTrainingGrid("one", "two", "three");

            Assert.AreEqual("one", result[0][0]);
            Assert.AreEqual("one | two", result[0][1]);
            Assert.AreEqual("one | three", result[0][2]);

            Assert.AreEqual("two | one", result[1][0]);
            Assert.AreEqual("two", result[1][1]);
            Assert.AreEqual("two | three", result[1][2]);

            Assert.AreEqual("three | one", result[2][0]);
            Assert.AreEqual("three | two", result[2][1]);
            Assert.AreEqual("three", result[2][2]);



        }


        [TestMethod]
        public void CreateRowReturnsCorrectRow__One_OneTwo_OneThree()
        {
            var testArray = _sut.CreateInitialRow("one", "two", "three");
            var result = _sut.CreateRow(testArray, "one");

            Assert.AreEqual("one", result[0]);
            Assert.AreEqual("one | two", result[1]);
            Assert.AreEqual("one | three", result[2]);
        }



    }
}
